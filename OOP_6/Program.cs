// Для работы с БД необходимо установить NuGet пакеты:
// 1. Microsoft.EntityFrameworkCore
// 2. Microsoft.EntityFrameworkCore.SqlServer
// 3. Microsoft.EntityFrameworkCore.Tools
// 4. Microsoft.EntityFrameworkCore.Proxies - для использования Lazy Loading

using Microsoft.EntityFrameworkCore;
using OOP_6.Data;

// Using определяет область действия экземпляра dbContext, вне using экземпляр dbContext не существует
using (DataContext dbContext = new DataContext())
{
    User newUser = new User();

    // Задание значений свойст, определенных в классе (определение значений в столбцацх таблицы)
    newUser.UserName = "Паша";
    newUser.RegistrationDate = DateTime.Now;

    var newPost = new Post();
    newPost.Geolocation = "Море";
    newPost.ContentPath = "C:";

    var newPost2 = new Post();
    newPost2.Geolocation = "Новосиб";
    newPost2.ContentPath = "C:";

    newUser.Posts = new List<Post>();
    newUser.Posts.Add(newPost);
    newUser.Posts.Add(newPost2);

    dbContext.Users.Add(newUser);
    // Сохранение изменений, внесенных в БД. До сохранения все изменения существуют только в оперативной памяти
    dbContext.SaveChanges();

    // Выбор записи из БД
    var User = dbContext.Users
        // EaderLoading - жадная загрузка. Загрузка связанных сущностей
        // Без Include связанные сущности загружены не будут и в свойстве Posts будет null
        .Include(x => x.Posts)
        .FirstOrDefault(x => x.UserName == "Паша");
    // Изменение данных в БД
    User.UserName = "Павел";

    foreach(var userPost in User.Posts)
    {
        userPost.ContentPath = "d:";
    }

    dbContext.SaveChanges();

    var UserToDelete = dbContext.Users.FirstOrDefault(x => x.UserName == "Павел");
    dbContext.Users.Remove(UserToDelete);
    // По умолчанию все связанные свойства* тоже будут удалены (каскадное удаление)
    // Если навигационное свойство не было помечено как nullable
    dbContext.SaveChanges();
}
