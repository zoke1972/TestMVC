using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestniCMS2.Models
{
    public class BookletdruckContext : DbContext
    {
        public DbSet<Bookletdruck> Booklets { get; set; }
    }
}