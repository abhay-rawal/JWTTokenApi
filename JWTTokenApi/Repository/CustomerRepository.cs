using JWTTokenApi.Model;

namespace JWTTokenApi.Repository
{
    public class CustomerRepository
    {
        //Dummy data for customers
        public static List<Customer> customers = new List<Customer>()
        {
            new Customer()
            {
                Id = Guid.NewGuid(),
                Name = "Abhay Rawal",
                Address ="Maitidevi"
            },
            new Customer()
            {
                Id = Guid.NewGuid(),
                Name = "Aditya Chauhan",
                Address ="Ratopul"
            },
            new Customer()
            {
                Id = Guid.NewGuid(),
                Name = "Ankur ",
                Address ="Maitidevi"
            },
        };
    }
}
