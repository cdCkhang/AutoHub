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
    [Table("MANUFACTURER"),PrimaryKey("Man_ID")]
    public class Manufacturer
    {
        [StringLength(4),NotNull]
        public string Man_ID {  get; set; }
        [StringLength(20)]
        public string Man_Name { get; set; }
        [StringLength(20)]
        public string Man_Location { get; set; }        
    }
}
