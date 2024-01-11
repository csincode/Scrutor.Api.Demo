namespace Scrutor.Api.Demo.Models
{
    public class House
    {
        public int Id {get; set;}
        public string? Address {get; set;}

        public House(int id, string address)
        {
            Id = id;
            Address = address;   
        }
    }
}