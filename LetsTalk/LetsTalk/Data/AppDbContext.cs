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
            
            builder.Entity<ChatUser>()
                .HasOne<Chat>(sc => sc.Chat)
                .WithMany(s => s.ChatUser)
                .HasForeignKey(sc => sc.ChatId);

            builder.Entity<ChatUser>().HasOne(pt => pt.User)
                .WithMany(p => p.ChatUser)
                .HasForeignKey(pt => pt.UserId);

            builder.Entity<Chat>().HasMany(pt => pt.Messages).WithOne(message => message.Chat);
        }
    }
}