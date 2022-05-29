using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Students
    {
        [Key]
        [Required]
        public int StudentId { get; set; }
        [Required]
        public string StudentNombre { get; set; }
        [Required]
        public string StudentApellido { get; set; }
        [Required]
        public string StudentFacultad { get; set; }
        [Required]
        public string StudentPrograma { get; set; }



    }
}
