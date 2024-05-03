using System.Drawing;

namespace assignment_four.Models
{
    public enum AnimalCategory
    {
        DOG,
        CAT,
        CAPYBARA
    }

    public class Animal
    {
        static int nextId;
        public int Id { get; private set; }
        public string Name { get; set; }
        public AnimalCategory AnimalCategory { get; set; }
        public int Weight { get; set; }
        public Color? FurColor { get; set; }

        public List<Visit>? Visits { get; set; }

        public Animal(string name, int weight, AnimalCategory animalCategory, Color? furColor)
        {
            if (furColor != null)
            {
                this.FurColor = furColor;
            }
            else
            {
                this.FurColor = Color.Black;
            }

            this.Name = name;
            this.AnimalCategory = animalCategory;
            this.Weight = weight;
            Id = ++nextId;
        }
    }
}
