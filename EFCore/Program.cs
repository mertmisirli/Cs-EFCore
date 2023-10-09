using EFCore;
using EFCore.Entities;


using (var context = new AppDbContext())
{
    var entityToDelete = context.persons.FirstOrDefault(e => e.Id == 2);

    if (entityToDelete != null)
    {
        context.persons.Remove(entityToDelete);
        context.SaveChanges();
    }
}


using (var context = new AppDbContext())
{
    Random random = new Random();

    var entitiesToAdd = new List<Person>
    {
        new Person
        {
            Name = "Person1 name",
            Surname = "Person1 Surname",
            Id = random.Next(1, 101) 
        },
        new Person
        {
            Name = "Person2 name",
            Surname = "Person2 Surname",
            Id = random.Next(1, 101) 
        },
    };

    context.persons.AddRange(entitiesToAdd);
    context.SaveChanges();
}


using (var context = new AppDbContext())
{
    var entityToUpdate = context.persons.FirstOrDefault(e => e.Id == 3);

    if (entityToUpdate != null)
    {
        entityToUpdate.Name = "new Name";
        entityToUpdate.Surname = "new Surname";
        context.SaveChanges();
    }
}

