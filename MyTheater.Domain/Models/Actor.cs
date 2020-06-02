using System;
using System.Collections.Generic;
using System.Text;

namespace MyTheater.Domain.Models
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ActorMovie> ActorMovies { get; set; } = new List<ActorMovie>();
    }
}
