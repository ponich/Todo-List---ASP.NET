namespace TodoNet.Models
{
    // @todo реализовать валидацию
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public User User { get; set; }
    }
}