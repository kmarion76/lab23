using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace lab23.Models
{
    public class MovieViewModel
    {
        //[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(20)]
        public string Genre { get; set; }
        public double Runtime { get; set; }

    }
}
