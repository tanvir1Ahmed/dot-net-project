namespace RecipeShare.Api.Models.Domain
{
    public class User
    {
        public Guid id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public Guid categoryId { get; set; }
        //navigator 
        public Category category { get; set; }
    }
}
