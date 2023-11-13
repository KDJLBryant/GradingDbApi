using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingDB.Models
{
    public class Mark
    {
        public int Id { get; set; }
        public int mark { get; set; }

        [NotMapped]
        public DateTime DateTime { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
