using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingDB.Models
{
    public class Subject
    {
        public int Id { get; set; }

        [StringLength(256)]
        public string Title { get; set; }
        public List<Teacher> Teachers { get; } = new();
        public List<Mark> Marks { get; } = new();
    }
}
