using Microsoft.EntityFrameworkCore;
using Students.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options){}

        public DbSet<Student> Students { get; set; }
        public DbSet<Classe> Classes{ get; set; }
    }
}
