using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolManagementWebApp.Models;

namespace SchoolManagementWebApp.Data
{
    public class SchoolManagementWebAppContext : DbContext
    {
        public SchoolManagementWebAppContext (DbContextOptions<SchoolManagementWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<SchoolManagementWebApp.Models.Faculty> Faculty { get; set; } = default!;

        public DbSet<SchoolManagementWebApp.Models.Student> Student { get; set; } = default!;
    }
}
