namespace BlazorApp2.Entities
{
    public class NewAnimal
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public DateTime BirthDate { get; set; }
        public string Sex { get; set; }
        public int Price { get; set; } = 1;
        public string Status { get; set; }
    }
}
