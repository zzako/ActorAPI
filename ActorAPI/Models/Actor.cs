using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActorAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("MovieActor")]
    public class Actor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public String name { get; set; }
        public String lastname { get; set; }
        public int Age { get; set; }
        public String standoutmovie { get; set; }
        public String gender { get; set; }


    }
}
