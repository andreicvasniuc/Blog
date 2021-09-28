using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Db
{
    [Table("Articles")]
    public class Article
    {
        [Column("ArticleId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ArticleId { get; set; }

        [Column("Title")]
        [Required]
        public string Title { get; set; }

        [Column("Content")]
        [Required]
        public string Content { get; set; }

        [Column("Author")]
        [Required]
        public string Author { get; set; }
    }
}
