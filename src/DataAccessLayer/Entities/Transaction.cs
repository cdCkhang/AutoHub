using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    [Table("TRANSACTIONS"),PrimaryKey("Transaction_ID")]
    public class Transaction
    {
        [StringLength(6), RegularExpression(@"^[A-Z][A-Z]-[0-9][0-9][0-9]$")]
        public string Transaction_ID { get; set; }
        [StringLength(6),ForeignKey("CUSTOMERS")]
        public string Customer_ID { get; set; }
        [StringLength(8), ForeignKey("SALESPERSON")]
        public string SalesPerson_ID { get; set; }
        [StringLength(6),ForeignKey("CARS")]
        public string Car_ID { get; set; }
        public int Taxes_Fees {  get; set; }
        
    }
}
