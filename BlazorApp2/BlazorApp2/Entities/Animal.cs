namespace BlazorApp2.Entities
{
    [Serializable]
    public class Animal
    {
        public int AnimalId { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public DateTime BirthDate { get; set; }
        public string Sex { get; set; }
        public int Price { get; set; }
        public string Status { get; set; }
        public bool IsSelected { get; set; }
    }
}
