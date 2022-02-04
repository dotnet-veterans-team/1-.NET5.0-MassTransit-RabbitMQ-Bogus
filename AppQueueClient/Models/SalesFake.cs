using Bogus;
using System.Collections.Generic;

namespace AppQueueClient.Models
{
    public static class SalesFake
    {
        public static List<Sales> ListSalesFake(int numberOfSales)
        {
            var salesFaker = new Faker<Sales>("pt_BR")
                .RuleFor(c => c.Cardnumber, f => f.Finance.CreditCardNumber())
                .RuleFor(c => c.Cvv, f => f.Finance.CreditCardCvv())
                .RuleFor(c => c.Name, f => f.Name.FullName(Bogus.DataSets.Name.Gender.Female))
                .RuleFor(c => c.Amount, f => f.Random.Long(100, 2000));

            var sales = salesFaker.Generate(numberOfSales);
            
            return sales;
        }
    }
}
