using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6.Data
{
    // Атрибут, позволяющий задать имя таблицы, по умолчанию имя таблицы = {Имя класса}
    [Table("tblUsers")]
    public class User
    {
        // Свойства класса будут трасформированы в столбцы в таблице

        // Атрибут указывающий что данное свойство является первичным ключом в таблице
        [Key]
        public int Id { get; set; }
        // Атрибут указывающий что данное свойсвто является обязательным к заполнению
        // По умолчанию все типы данных, которые могут хранить в себе null являются НЕ обязательными к заполнению
        [Required]
        // Указание максимальной длины строки, которая может храниться в данном столбце
        [MaxLength(50)]
        public string UserName { get; set; }
        public DateTime RegistrationDate { get; set; }

        // Навигационное свойсвто, связывающее таблицы между собой
        // У одного пользователя может быть множество постов
        public List<Post> Posts { get; set; }

        // Для использования LazyLoading все навигационные свойства должны быть virtual
        //public virtual List<Post> Posts { get; set; }

    }
}
