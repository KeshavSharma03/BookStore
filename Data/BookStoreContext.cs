using System;
using System.Collections.Generic;
using System.Collection;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BookStore.API.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options)
        {

        }
        public DbSet<Books> Books {  get; set; }

        

    }
}
