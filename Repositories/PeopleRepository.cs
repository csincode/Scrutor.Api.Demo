using Scrutor.Api.Demo.Models;

namespace Scrutor.Api.Demo.Repositories
{
    public class PeopleRepository : IRepository<Person>
    {
        private static List<Person> _people = new()
        {
            new Person(1, "Celso Soares")
        };

        public Task AddAsync(Person entity)
        {
            _people.Add(entity);
            return Task.CompletedTask;
        }

        public Task<Person?> GetByIdAsync(int id)
        => Task.FromResult(_people.FirstOrDefault(house => house.Id == id));
    }
}