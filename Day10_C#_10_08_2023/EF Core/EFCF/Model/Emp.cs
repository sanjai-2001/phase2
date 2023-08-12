using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCF.Model
{
    internal class Emp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpNo { get; set; }
        [Required]
        public string? EmpName { get; set; }

        public string? Empadd { get; set;}

        public Dept? DeptNav { get; set; }
    }
}
