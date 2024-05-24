namespace CookBook
{
    public class SQLHelper
    {
        private static readonly AppDbContext ctx = new();

        public static List<Recept> GetRecipes()
        {
            return ctx.recepts.ToList();
        }

        public static List<ReceptItem> GetRecipesItem(int id)
        {
            return ctx.receptItems.Where(x => x.ReceptId == id).ToList();
        }

        public static void UpdateRecept(Recept recept)
        {
            ctx.recepts.Update(recept);
            ctx.SaveChanges();
        }
    }
}
