using Microsoft.EntityFrameworkCore;
using SharkTDS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharkTDS.Controllers
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Flow> Flows { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Stat> Stats { get; set; }
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
           // Database.EnsureCreated();
        }
    }
}
