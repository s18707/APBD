using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cw11.Models
{
    [Table("Lekarstwo")]
    public class Medicament
    {
        [Key]
        [Required]
        public int IdMedicament { get; set; }
        [Required]
        [MaxLength(100)]
        public String Name { get; set; }
        [Required]
        [MaxLength(100)]
        public String Description { get; set; }
        [Required]
        [MaxLength(100)]
        public String Type { get; set; }
    }
}
