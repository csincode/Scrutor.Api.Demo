namespace Scrutor.Api.Demo.Models
{
    public class Person
    {
        public int Id {get; set;}
        public string? FirstName {get; set;}

        public Person(int id, string firstName)
        {
            Id = id;
            FirstName = firstName;   
        }
    }
}