using System.Data;
using System.Drawing;
using assignment_four.Models;

public static class AnimalManager
{
    static Dictionary<short, Animal> animDict =
        new()
        {
            { 1, new Animal("Ana", 50, AnimalCategory.CAT, null) },
            { 2, new Animal("Filipe", 60, AnimalCategory.CAT, Color.Green) },
            { 3, new Animal("Lena", 40, AnimalCategory.CAT, Color.Black) }
        };

    public static Dictionary<short, Animal> GetAnimals()
    {
        return animDict;
    }

    public static string GetAnimalById(short id)
    {
        return animDict[id].Name;
    }

    public static void AddAnimal(
        short id,
        string name,
        int weight,
        AnimalCategory animCategory,
        string color
    )
    {
        animDict.Add(id, new Animal(name, weight, animCategory, Color.FromName(color)));
    }

    public static void RemoveAnimal(short id)
    {
        animDict.Remove(id);
    }

    public static IResult? EditAnimal(
        short id,
        string? name,
        int? weight,
        AnimalCategory? animCategory
    )
    {
        if (animDict[id] != null)
        {
            if (name != null)
            {
                animDict[id].Name = name;
            }

            if (weight != null)
            {
                animDict[id].Weight = (int)weight;
            }

            if (animCategory != null)
            {
                animDict[id].AnimalCategory = (AnimalCategory)animCategory;
            }
            return Results.Ok(animDict[id]);
        }
        return null;
    }

    public static List<Visit>? GetVisits(short id)
    {
        return animDict[id].Visits;
    }

    public static void AddVisit(short id, DateTime date, string description, int priceInCents)
    {
        if (animDict[id].Visits != null)
        {
            animDict[id].Visits.Add(new Visit(date, description, animDict[id], priceInCents));
        }
    }
}
