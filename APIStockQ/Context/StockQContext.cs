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
        public DbSet<WeatherForecast> WeatherForecast { get; set; }
    }
}
