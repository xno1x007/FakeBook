using System.ComponentModel.DataAnnotations.Schema;

namespace FakeBookApi.Data.Entities
{
    [Table("category")]
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}