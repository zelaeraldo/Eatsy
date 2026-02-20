using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eatsy1.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public string PaymentMethod { get; set; } // CreditCard, PayPal, Cash
        public DateTime PaymentDate { get; set; }
        [Precision(18, 2)]
        public decimal Amount { get; set; }
        public bool IsSuccessful { get; set; }
    }

}
