namespace CookBook
{
    public class SQLHelper
    {
        private static readonly AppDbContext ctx = new();

        public static List<Recept> GetRecipes(string filterText)
        {
            if(filterText == null)
            {
                var sortedRecipes = ctx.recepts.OrderBy(x => x.DishType).ToList();
                return sortedRecipes;
            }
            else
            {
                var filtered = ctx.recepts.Where(x => x.Name.Contains(filterText)).ToList();
                return filtered.OrderBy(x => x.DishType).ToList();
            }
            
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
