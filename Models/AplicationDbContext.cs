using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CvNetCore2.Models
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) { }

        public DbSet<Courses> Courses { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<UserDetails> UserDetails { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<Language>Languages { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<UserAdress> UserAdress { get; set; }
        public DbSet<Work> Works { get; set; }
    }
}
