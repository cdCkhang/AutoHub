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
    [Table("SALESPERSON"),PrimaryKey("SalesPerson_ID")]
    public class Saler
    {
        [StringLength(8),NotNull]
        public string SalesPerson_ID { get; set; }
        [StringLength(30)]
        public string FullName { get; set; }
        [StringLength(20)]
        public string ContactNumber {  get; set; }
        [StringLength(30)]
        public string Email {  get; set; }
        [StringLength(30)]
        public string Info_Address { get; set; }
        public int Salary {  get; set; }
    }
}
