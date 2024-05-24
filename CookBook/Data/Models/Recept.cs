namespace CookBook
{
    public class Recept
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DishType DishType { get; set; }
        public FoodCulture FoodCulture { get; set; }
        public int From { get; set; }
        public int Till { get; set; }
        public int Amount { get; set; }
        public byte[]? ImageData { get; set; }
    }
}
