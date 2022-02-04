using System;
using System.ComponentModel.DataAnnotations;

namespace WebApiPayments.ViewModel
{
    public class PaymentViewModel
    {
        public PaymentViewModel()
        {
            Transaction = Guid.NewGuid();
        }

        [Required]
        public string Cardnumber { get; set; }

        [Required]
        public string Cvv { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public long Amount { get; set; }

        public Guid Transaction { get; set; }
    }
}
