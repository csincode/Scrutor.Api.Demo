using Scrutor.Api.Demo.Models;

namespace Scrutor.Api.Demo.Repositories
{
    public class CarRepository : IRepository<Car>
    {
        private static List<Car> _cars = new()
        {
            new Car(1, "New Fiesta")
        };

        public Task AddAsync(Car entity)
        {
            _cars.Add(entity);
            return Task.CompletedTask;
        }

        public Task<Car?> GetByIdAsync(int id)
        => Task.FromResult(_cars.FirstOrDefault(house => house.Id == id));
    }
}