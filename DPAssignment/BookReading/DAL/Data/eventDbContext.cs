using CommonModel.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Data
{
    public class eventDbContext:DbContext
    {
       

        public eventDbContext(DbContextOptions<eventDbContext> options):base(options)
        {

        }

        public DbSet<AddEvent> Events { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
