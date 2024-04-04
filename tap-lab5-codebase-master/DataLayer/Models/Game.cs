using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Numele jocului este obligatoriu.")]
        public string Name { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Dimensiunea jocului trebuie să fie mai mare decât 0.")]
        public int SizeInGB { get; set; }
    }
}
