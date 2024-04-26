namespace Cinema.Model
{

    public class Movie
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int duration { get; set; }

        public Movie()
        {
            Id=1;
            Name="Star Wars";
            duration = 120;
        }
    }
}

