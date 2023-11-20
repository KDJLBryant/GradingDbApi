using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingDbApi.DTO
{
    public class SubjectDTO
    {
        [Required]
        [StringLength(255)]
        public string Title { get; set; }
    }
}
