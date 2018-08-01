using System.Data.Entity;

namespace TodoNet.Models.Seeds
{
    public class Seeder : DropCreateDatabaseAlways<Context>
    {
        private Context db;

        protected override void Seed(Context db)
        {
            this.db = db;

            this.Users();
            this.Todos();

            base.Seed(this.db);
        }

        private void Users()
        {
            // users
            this.db.Users.Add(new User
            {
                // id: 1
                Email = "n.ponich@gmail.com",
                Name = "Nikolay Ponich",
                Password = "1111"
            });
            
            base.Seed(this.db);
        }

        private void Todos()
        {
            this.db.Todos.Add(new Todo
            {
                UserId = 1, // 
                Title = "Тестовая задача №1",
                Content = "Контент для задачи номер один"
            });

            this.db.Todos.Add(new Todo
            {
                UserId = 1, // 
                Title = "Тестовая задача №2",
                Content = "Контент для задачи номер два"
            });
        }
    }
}