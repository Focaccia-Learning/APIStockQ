using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIStockQ;
using APIStockQ.Model;

namespace APIStockQ.Context
{
    public class StockQContext : DbContext
    {
        public StockQContext(DbContextOptions<StockQContext> options) : base(options) { }
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseSqlite("Data Source=StockQ.db");
        //public DbSet<Home> Homes { get; set; }
        //public DbSet<Markets> Markets { get; set; }

        public DbSet<WeatherForecast> WeatherForecast { get; set; }
    }
}
