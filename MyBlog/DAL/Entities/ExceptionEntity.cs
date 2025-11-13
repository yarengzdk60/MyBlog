using System.ComponentModel.DataAnnotations;

namespace MyBlog.DAL.Entities
{
    public class ExceptionEntity
    {
        [Key] // EF Core'a bu property'sinin Primary Key olduğunu belirtir
        public int Id { get; set; }

        public string Message { get; set; }
        public string StackTrace { get; set; }
        public DateTime Date { get; set; }
    }
}
