using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6.Data
{
    // Контекст - класс, используемый для доступа к БД. Для того, чтобы класс стал контекстом он должен быть унаследован от DbContext
    public class DataContext : DbContext 
    {
        // Добавление таблиц в контекст, используя данные свойства через экземпляр контекста осуществляется доступ к соответствующим таблицам
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Определение строки подключения
            // Server - адрес SQL сервера, localhost указывает на то, что сервер установлен на той же машине, на которой запускается программа
            // Database - наименование БД, к которой подключаемся
            // Trusted_Connection=True - для подключения к БД используется учетная запись Windows
            // TrustServerCertificate=true - доверять сертификату, установленному на сервере
            optionsBuilder
                //.UseLazyLoadingProxies() - для использования LazyLoading, все связанные свойства загружаются автоматически
                .UseSqlServer("Server=localhost;Database=myDataBase;Trusted_Connection=True; TrustServerCertificate=true");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Определение связи один (Пользователь) ко многим (Посты)
            modelBuilder.Entity<User>()
                .HasMany(x => x.Posts)
                .WithOne(x => x.User);
        }
    }
}
