using Microsoft.EntityFrameworkCore;

namespace Connect_four
{
    
    public class UserContext : DbContext
    {

        public DbSet<User> Users { get; set; }

        private string DbPath { get; }

        public UserContext()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            DbPath = System.IO.Path.Join(path, "users.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite($"Data Source={DbPath}");

    }

    public class User
    {

        public int UserId { get; set; }

        public string UserUUID { get; set; }

        public string UserName { get; set; }

        public string UserPassword { get; set; }

    }

    public class Score
    {
        
        public int ScoreId { get; set; }
        
        public int UserId { get; set; }
        
        public int Result { get; set; }
        
        public bool IsAgainstAI { get; set; }
        
    }

}
