namespace COMP003B.Assignment7.Models
{
    public class Movie
    {
        public int ID { get; set; }

        public int ActorID { get; set; }

        public int DirectorID { get; set; }

        public virtual Actor? Actor { get; set; }

        public virtual Director? Director { get; set; }


    }
}
