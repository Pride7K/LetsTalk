using LetsTalk.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LetsTalk.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public DbSet<Chat> Chat { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<ChatUser> ChatUser { get; set; }
        public DbSet<Message> Message { get; set; }
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            base.OnModelCreating(builder);
            
            builder.Entity<ChatUser>().HasKey(user => new { user.ChatId, user.UserId });
            
            
        }
    }
}