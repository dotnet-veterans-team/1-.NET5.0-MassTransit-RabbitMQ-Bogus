using System;

namespace AppQueueClient.Models
{
    public class Sales
    {
        public Sales()
        {
            Transaction = Guid.NewGuid();
        }

        public string Cardnumber { get; set; }

        public string Cvv { get; set; }

        public string Name { get; set; }

        public long Amount { get; set; }

        public Guid Transaction { get; set; }
    }
}
