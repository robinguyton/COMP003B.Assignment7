namespace COMP003B.Assignment7.Models
{
    public class Actor
    {
        public int ActorId { get; set; }

        public string Name { get; set; }

        // Collection

        public virtual ICollection<Movie> Movies { get; set; }

        public int Age { get; set; }
    }
}
