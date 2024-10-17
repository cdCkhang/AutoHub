using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    [Table("CUSTOMERS"),PrimaryKey("Customer_ID")]
    public class Customer
    {
        [StringLength(6),NotNull]
        public string Customer_ID { get; set; }
        [StringLength(50)]
        public string FullName { get; set; }
        [StringLength(50)]
        public string CreditCardNumber {  get; set; }
        [StringLength(20)]
        public string Contact_Number { get; set; }
        [StringLength(30)]
        public string Email { get; set; }
        [StringLength(30)]
        public string Info_Address { get; set; }
    }
}
