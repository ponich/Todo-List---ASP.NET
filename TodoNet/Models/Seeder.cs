using System.Data.Entity;

namespace TodoNet.Models.Seeds
{
    public class Seeder : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context db)
        {
            db.Todos.Add(new Todo
            {
                Title = "Тестовая задача №1",
                Content = "Контент для задачи номер один"
            });

            base.Seed(db);
        }
    }
}