using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingDB.Models
{
    public class Group
    {
        public int Id { get; set; }

        [StringLength(256)]
        public string Name { get; set; }
    }
}
