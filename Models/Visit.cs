namespace assignment_four.Models
{
    public class Visit
    {
        public DateOnly visitDate {get; private set;}
        public Animal animal {get; private set;}
        public string description {get; private set;}
        public int priceInCents {get; private set;}

    }
}