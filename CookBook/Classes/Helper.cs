namespace CookBook
{
    public class Helper
    {
        public static void OpenForm(Form form, Form parent)
        {
            form.Show();

            if(parent != null) 
            {
                parent.Close();
            }
        }
    }
}
