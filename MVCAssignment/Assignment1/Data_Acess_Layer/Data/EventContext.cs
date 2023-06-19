using BookReadingEvent1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReadingEvent1.Data    
{
    public class EventContext:IdentityDbContext<ApplicationUser>
    {
        public EventContext(DbContextOptions<EventContext> options) : base(options)
        {

        }
        public DbSet<Events> Event { get; set; }
        public DbSet<BookReadingEvent1.Models.EventModel> EventModel { get; set; }

    }
}
