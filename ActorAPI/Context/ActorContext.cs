using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActorAPI.Context
{
    using Microsoft.EntityFrameworkCore;
    using ActorAPI.Models;
    public class ActorContext : DbContext
    {

        public ActorContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Actor> actors { get; set; }
    }
}
