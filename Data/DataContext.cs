using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using rpg2.Models;
namespace rpg2.Data
{
    // public class DataContext :DbContext
    // {
    //     public DataContext(DbContextOptions<DataContext> options) : base(options){}
    //     public DbSet<Character> Characters { get; set; }
        
    // }
    public class DataContext1:DbContext
    {
        public DataContext1(DbContextOptions<DataContext1> options) : base(options){}
        public DbSet<Settings> Settings { get; set; }
        // public DbSet<UserData> UserData { get; set; }
        
    }
}

