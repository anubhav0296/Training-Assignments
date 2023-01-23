using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_3_Entity.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
             : base("name=conn")
        {

        }
        public DbSet<User> Users { get; set; }

    }
}
