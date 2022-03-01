namespace WebApplication1.Models
{
    public class DbInitializer
    {
        public static void Initialize(MyContext context)
        {
            context.Persons.Add(new Person
            {
                Id = 1,
                Name = "Иван",
                Surname = "Иванов"
            });
            context.SaveChanges();
          
        }
    }
}

