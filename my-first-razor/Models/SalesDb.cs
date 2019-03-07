using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace my_first_razor.Models
{
    public class SalesDb : DbContext

    {
        public DbSet<Product> Products { get; set; }

    }
}