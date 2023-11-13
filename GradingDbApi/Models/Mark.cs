using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingDB.Models
{
    public class Mark
    {
        public int Id { get; set; }

        [Required]
        public int mark { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        public int StudentId { get; set; }
        [Required]
        public Student Student { get; set; }
        [Required]
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
