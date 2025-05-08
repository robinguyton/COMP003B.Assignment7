namespace COMP003B.Assignment7.Models
{
    public class Director
    {
        public int DirectorID { get; set; }
        
        public string Name { get; set; }
        // Collection
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
