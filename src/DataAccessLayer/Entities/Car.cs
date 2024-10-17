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
    [Table("CARS"),PrimaryKey("Car_ID")]
    public class Car
    {
        [StringLength(6),NotNull]
        public string Car_ID { get; set; }
        [StringLength(20)]
        public string Model_Name { get; set; }
        [StringLength(4),ForeignKey("MANUFACTURER")]
        public string Man_ID { get; set; }
        public int Model_Year {  get; set; }
        [StringLength(6)]
        public string PaintColor {  get; set; }
        public int Price {  get; set; }       
    }
}
