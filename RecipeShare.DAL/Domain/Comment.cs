namespace RecipeShare.Api.Models.Domain
{
    public class Comment
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public DateTime date { get; set; }
        public string description { get; set; }
        public int like { get; set; }
        public Guid postId { get; set; }
        
        //navigator
        public Post post { get; set; }
    }
}
