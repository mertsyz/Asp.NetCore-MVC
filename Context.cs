using System;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;


namespace DataAccessLayer.Concrete
{
	public class Context : DbContext
	{

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=127.0.0.1;Port=3306;database=BlogDb;uid=root;pwd=Mac033189;", ServerVersion.AutoDetect("server=127.0.0.1;Port=3306;database=BlogDb;uid=root;pwd=Mac033189;"));
        }



        public DbSet<About> Abouts { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Content> Contents { get; set; }
		public DbSet<Heading> Headings { get; set; }
		public DbSet<Writer> Writers { get; set; }

	}
}

