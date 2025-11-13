using Microsoft.EntityFrameworkCore;
using MyBlog.DAL.Entities;

namespace MyBlog.DAL.Context
{
    public class Myblogcontext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Initial Catalog=MyBlogDb;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Contac> Contacs { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<SocialMedai> SocialMedais { get; set; }
       
        public DbSet<Featcher> Featchers { get; set; }

        public DbSet<ExceptionEntity> ExceptionEntitys { get; set; }
        public DbSet<Skill>Skills { get; set; }
       
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }


    }
}
