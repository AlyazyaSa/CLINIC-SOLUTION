using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CLINIC.Mdbcontext
{
    public class Applicationdbcontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(" Data Source=LAPTOP-OH39326H\\MSSQLSERVER01;Initial Catalog=ClinicManagementSystemDB;Integrated Security=True;");
        }

    }
}
