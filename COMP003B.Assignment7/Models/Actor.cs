﻿namespace COMP003B.Assignment7.Models
{
    public class Actor
    {
        public int ActorID { get; set; }

        public string Name { get; set; }

        // Collection

        public virtual ICollection<Movie> Movies { get; set; }


    }
}
