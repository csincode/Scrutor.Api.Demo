using Scrutor.Api.Demo.Models;

namespace Scrutor.Api.Demo.Repositories
{
    public class HouseRepository : IRepository<House>
    {
        private static List<House> _houses = new()
        {
            new House(1, "Av. Brasil")
        };

        public Task AddAsync(House entity)
        {
            _houses.Add(entity);
            return Task.CompletedTask;
        }

        public Task<House?> GetByIdAsync(int id)
        => Task.FromResult(_houses.FirstOrDefault(house => house.Id == id));
    }
}