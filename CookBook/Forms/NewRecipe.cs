using System.Text;

namespace CookBook
{
    public partial class NewRecipe : Form
    {
        #region Declarations
        private readonly AppDbContext ctx = new();
        private Recept? currentRecipe;
        private State currentState;
        #endregion

        #region Constructor
        public NewRecipe(Recept recept, State state)
        {
            InitializeComponent();

            currentRecipe = recept;
            currentState = state;
        }
        #endregion

        #region FormEvents
        private void NewRecipe_Load(object sender, EventArgs e)
        {
            SetFieldValues(currentRecipe, currentState);

            switch (currentState)
            {
                case State.New:
                    txtType.Visible = false;
                    txtCulture.Visible = false;
                    break;
                case State.ReadOnly:
                    cbDishType.Visible = false;
                    cbCulture.Visible = false;
                    btnNew.Visible = false;
                    btnSave.Visible = false;
                    btnCancel.Text = "Afsluiten";
                    SetReadOnly(this);
                    break;
                case State.Update:
                    txtType.Visible = false;
                    txtCulture.Visible = false;
                    btnSave.Text = "Aanpassen";
                    break;
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new())
            {
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                dialog.Filter = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";
                dialog.FilterIndex = 1;
                dialog.RestoreDirectory = true;
                dialog.Multiselect = false;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pbItem.Image = new Bitmap(dialog.FileName);
                }
            }
        }

        private void TextBox_Changed(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { txtName, txtFrom, txtTill, txtAmount };

            if (currentState == State.New)
            {
                if (textBoxes.Any(tb => string.IsNullOrEmpty(tb.Text)))
                    btnSave.Enabled = false;
                else
                    btnSave.Enabled = true;
            }
            else if (currentState == State.Update)
            {
                btnSave.Enabled = IsDirty();
            }
        }

        private void RtxtIngrediënts_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
                rtxtIngrediënts.SelectionIndent = 30;
            if (e.KeyCode == Keys.Enter)
                rtxtIngrediënts.SelectionIndent = 0;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Helper.OpenForm(new Main(), this);
        }

        private void TxtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (currentRecipe == null)
            {
                using (MemoryStream ms = new())
                {
                    pbItem.Image.Save(ms, pbItem.Image.RawFormat);
                    byte[] imageData = ms.ToArray();

                    Recept recept = new()
                    {
                        Name = txtName.Text,
                        DishType = ((DishType?)cbDishType.SelectedItem).Value,
                        FoodCulture = ((FoodCulture?)cbCulture.SelectedItem).Value,
                        From = int.Parse(txtFrom.Text),
                        Till = int.Parse(txtTill.Text),
                        Amount = int.Parse(txtAmount.Text),
                        ImageData = imageData
                    };

                    ctx.Add(recept);
                    ctx.SaveChanges();

                    string richText = rtxtIngrediënts.Text;
                    string[] lines = richText.Split(new[] { '\n' }, StringSplitOptions.None);

                    foreach (string line in lines)
                    {
                        ReceptItem item = new()
                        {
                            Item = line,
                            ReceptId = recept.Id
                        };

                        ctx.Add(item);
                    }

                    ctx.SaveChanges();
                }
                MessageBox.Show("Recept aangemaakt!", "Aanmaak successful", MessageBoxButtons.OK);

                Helper.OpenForm(new Main(), this);
            }
            else
            {
                using (MemoryStream ms = new())
                {
                    pbItem.Image.Save(ms, pbItem.Image.RawFormat);
                    byte[] imageData = ms.ToArray();

                    currentRecipe.Name = txtName.Text;
                    currentRecipe.DishType = ((DishType?)cbDishType.SelectedItem).Value;
                    currentRecipe.FoodCulture = ((FoodCulture?)cbCulture.SelectedItem).Value;
                    currentRecipe.From = int.Parse(txtFrom.Text);
                    currentRecipe.Till = int.Parse(txtTill.Text);
                    currentRecipe.Amount = int.Parse(txtAmount.Text);
                    currentRecipe.ImageData = imageData;
                }

                SQLHelper.UpdateRecept(currentRecipe);
                Helper.OpenForm(new Main(), this);
            }
        }
        #endregion

        #region Private Methods
        private void SetFieldValues(Recept recipe, State state)
        {
            if (recipe != null)
            {
                txtName.Text = currentRecipe.Name;
                txtFrom.Text = currentRecipe.From.ToString();
                txtTill.Text = currentRecipe.Till.ToString();
                txtAmount.Text = currentRecipe.Amount.ToString();
                BinaryToImage(currentRecipe.ImageData);

                if (state == State.ReadOnly)
                {
                    txtType.Text = currentRecipe.DishType.ToString();
                    txtCulture.Text = currentRecipe.FoodCulture.ToString();
                }
                else if (state == State.Update)
                {
                    cbDishType.DataSource = Enum.GetValues(typeof(DishType));
                    cbDishType.SelectedItem = currentRecipe.DishType;

                    cbCulture.DataSource = Enum.GetValues(typeof(FoodCulture));
                    cbCulture.SelectedItem = currentRecipe.DishType;
                }

                FillIngrediëntsList(recipe);
            }
            else
            {
                cbDishType.DataSource = Enum.GetValues(typeof(DishType));
                cbDishType.SelectedIndex = 0;

                cbCulture.DataSource = Enum.GetValues(typeof(FoodCulture));
                cbDishType.SelectedIndex = 0;

                rtxtIngrediënts.SelectionBullet = true;
            }
        }

        private void FillIngrediëntsList(Recept recipe)
        {
            StringBuilder stringBuilder = new();
            List<ReceptItem> ingrediënts = SQLHelper.GetRecipesItem(recipe.Id);

            rtxtIngrediënts.SelectionBullet = true;

            foreach (var item in ingrediënts)
            {
                stringBuilder.Append(item.Item);
                stringBuilder.AppendLine();
            }

            rtxtIngrediënts.Text = stringBuilder.ToString();
        }

        private void SetReadOnly(Control parent)
        {
            foreach (GroupBox groupBox in parent.Controls.OfType<GroupBox>())
            {
                foreach (TextBox textBox in groupBox.Controls.OfType<TextBox>())
                {
                    textBox.ReadOnly = true;
                    textBox.BackColor = SystemColors.Window;
                }

                foreach (RichTextBox richTextBox in groupBox.Controls.OfType<RichTextBox>())
                {
                    richTextBox.ReadOnly = true;
                    richTextBox.BackColor = SystemColors.Window;
                }
            }
        }

        private void BinaryToImage(byte[]? imageData)
        {
            MemoryStream ms = new(imageData);
            Bitmap image = new(ms);
            pbItem.Image = image;
        }

        private bool IsDirty()
        {
            while (txtName.Text == currentRecipe.Name && txtTill.Text == currentRecipe.Till.ToString()
               && txtFrom.Text == currentRecipe.From.ToString() && txtAmount.Text == currentRecipe.Amount.ToString())
            {
                return false;
            }

            return true;
        }

        #endregion
    }
}