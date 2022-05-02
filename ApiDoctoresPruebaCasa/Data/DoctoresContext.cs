using ApiDoctoresPruebaCasa.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDoctoresPruebaCasa.Data
{
    public class DoctoresContext: DbContext
    {
        public DoctoresContext(DbContextOptions<DoctoresContext> options) : base(options) { }
        public DbSet<Doctor> Doctores { get; set; }
    }
}
