namespace MyPortofolio.Models
{
    public class Project
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Technologies { get; set; } = new List<string>();
        public string Link { get; set; }

    }
}
