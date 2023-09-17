namespace BlazorApp2.Entities
{
    public class AnimalSelectionService
    {
        public Dictionary<int, bool> SelectedAnimalIds { get; } = new Dictionary<int, bool>();

        public void ToggleSelection(int animalId)
        {
            if (SelectedAnimalIds.ContainsKey(animalId))
            {
                SelectedAnimalIds[animalId] = !SelectedAnimalIds[animalId];
            }
            else
            {
                SelectedAnimalIds[animalId] = true;
            }
        }
    }
}
