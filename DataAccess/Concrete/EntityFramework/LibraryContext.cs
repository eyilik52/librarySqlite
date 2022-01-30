using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class LibraryContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=LibraryDB;Trusted_Connection=true");
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ClassRoom> classRooms { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Stock> stocks { get; set; }
        public DbSet<Reader> Readers { get; set; }
        public DbSet<EscrowBook> EscrowBooks { get; set; }

    }
}
