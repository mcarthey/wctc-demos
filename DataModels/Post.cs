namespace EFPart1.DataModels
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        // EF
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}