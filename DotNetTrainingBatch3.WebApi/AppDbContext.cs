using DotNetTrainingBatch3.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTrainingBatch3.WebApi
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
            {
                DataSource = "DESKTOP-G92HAN0\\SQLEXPRESS01",
                InitialCatalog = "TestDb",
                UserID = "sa",
                Password = "yy@79250",
                TrustServerCertificate = true,
            };
            optionsBuilder.UseSqlServer(sqlConnectionStringBuilder.ConnectionString);
            
        }
        public DbSet<BlogModel> blogs { get; set; }
    }
}
