namespace IT_ELECTIVE_2_Midterm_A1_Antonio_MarcKevin.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string ShortDescription { get; set; } = string.Empty;
        public string FullDescription { get; set; } = string.Empty;
        public string ThumbnailUrl { get; set; } = string.Empty;
        public string GitHubUrl { get; set; } = string.Empty;
        public List<Comment> Comments { get; set; } = new();
    }
}