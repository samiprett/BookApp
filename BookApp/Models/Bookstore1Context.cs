using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BookApp.Models
{
    public class Bookstore1Context : DbContext
    {
        public Bookstore1Context()
        {
        }

        public Bookstore1Context(DbContextOptions<Bookstore1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Books> Books { get; set; }
    }
}
