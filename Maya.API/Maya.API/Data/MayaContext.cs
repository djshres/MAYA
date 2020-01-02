using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Maya.API.Models;

public class MayaContext : DbContext
{
    public MayaContext(DbContextOptions<MayaContext> options)
        : base(options)
    {
    }

    public DbSet<Value> Value { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Photo> Photos { get; set; }
}
