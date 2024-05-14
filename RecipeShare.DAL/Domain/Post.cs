namespace RecipeShare.Api.Models.Domain
{
    public class Post
    {
        public Guid id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int like { get; set; }
        public int share { get; set; }
        public string ingredient { get; set; }
    }
}
