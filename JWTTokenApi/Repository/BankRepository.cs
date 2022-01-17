using JWTTokenApi.Model;

namespace JWTTokenApi.Repository
{
    public class BankRepository
    {
        //Dummy data for Banks
        public static List<Bank> banks = new List<Bank>()
        {
            new Bank()
            {
                Id = Guid.NewGuid(),
                Name = "Everest",
                Address ="Maitidevi"
            },
            new Bank()
            {
                Id = Guid.NewGuid(),
                Name = "Megha",
                Address ="Ratopul"
            },
            new Bank()
            {
                Id = Guid.NewGuid(),
                Name = "Nabil",
                Address ="Maitidevi"
            },
        };
    }
}
