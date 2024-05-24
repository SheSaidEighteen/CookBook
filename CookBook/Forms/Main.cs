namespace CookBook
{
    public partial class Main : Form
    {
        #region Declarations
        private Recept currentRecipe;
        #endregion

        #region Constructor
        public Main()
        {
            InitializeComponent();

            txtSearch.TextChanged += TxtSearch_TextChanged;
        }
        #endregion

        #region FormEvents

        #region ButtonEvents
        private void BtnNew_Click(object sender, EventArgs e)
        {
            Helper.OpenForm(new NewRecipe(null, State.New), this);
        }
        
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Helper.OpenForm(new NewRecipe(currentRecipe, State.Update), this);
        }
        #endregion

        private void Main_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void TxtSearch_TextChanged(object? sender, EventArgs e)
        {
            dgvRecepts.DataSource = SQLHelper.GetRecipes(txtSearch.Text.Trim());
            dgvRecepts.CurrentCell = null;
        }

        private void DgvRecepts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentRecipe = (Recept)dgvRecepts.Rows[e.RowIndex].DataBoundItem;
            btnUpdate.Enabled = true;
        }

        private void DgvRecepts_DoubleClick(object sender, EventArgs e)
        {
            Helper.OpenForm(new NewRecipe(currentRecipe, State.ReadOnly), this);
        }
        #endregion

        #region Private Methods
        private void PopulateGrid()
        {
            dgvRecepts.ClearSelection();

            foreach (DataGridViewColumn col in dgvRecepts.Columns)
            {
                dgvRecepts.Columns[col.Name].DataPropertyName = dgvRecepts.Columns[col.Name].Name;
            }

            dgvRecepts.DataSource = SQLHelper.GetRecipes(null);

            dgvRecepts.ReadOnly = true;
            dgvRecepts.Columns[0].Visible = false;
            dgvRecepts.Columns[4].Visible = false;
            dgvRecepts.Columns[5].Visible = false;
            dgvRecepts.Columns[6].Visible = false;
            dgvRecepts.Columns[7].Visible = false;
            dgvRecepts.ClearSelection();
            dgvRecepts.Refresh();
            dgvRecepts.CurrentCell = null;
        }
        #endregion
    }
}
