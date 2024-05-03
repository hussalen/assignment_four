namespace assignment_four.Models
{
    public class Visit
    {
        public DateTime visitDate { get; private set; }
        public Animal animal { get; private set; }
        public string description { get; private set; }
        public int priceInCents { get; private set; }

        public Visit(DateTime visitDate, string description, Animal animal, int priceInCents)
        {
            this.visitDate = visitDate;
            this.description = description;
            this.animal = animal;
            this.priceInCents = priceInCents;
        }
    }
}
