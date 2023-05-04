using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6.Data
{
    [Table("tblPosts")]
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Geolocation { get; set; }
        [Required]
        public string ContentPath { get; set; }

        // У каждого поста может быть только 1 пользователь, опубликовавший его
        public User User { get; set; }

        // Для использования LazyLoading все навигационные свойства должны быть virtual
        //public virtual User User { get; set; }

    }
}
