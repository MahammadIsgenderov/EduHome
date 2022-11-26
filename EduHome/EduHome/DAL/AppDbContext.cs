using EduHome.Models;
using Microsoft.EntityFrameworkCore;

namespace EduHome.DAL
{
    public class AppDbContext: DbContext
    {
        internal object bios;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Slider> sliders { get; set; }
        public DbSet<Service> services { get; set; }
        public DbSet<About> abouts { get; set; }
        public DbSet<Courses> courses { get; set; }
        public DbSet<NoticeBoard> noticeboards { get; set; }
        public DbSet<Info> infos { get; set; }
        public DbSet<Blog> blogs { get; set; }
        public DbSet<Bio> Bios { get; set; }
        
    }
}
