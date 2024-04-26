using System.Drawing;

namespace assignment_four.Models
{
    public class Animal
    {

        static int nextId;
        public int id {get; private set;}
        public string name {get; private set;}
        public int weight {get; private set;}
        public Color furColor {get; private set;}
        public Animal(string name, int weight) {
            this.furColor = Color.Black;
            this.name = name;
            this.weight = weight;
            id = ++nextId;
        }
    }
}