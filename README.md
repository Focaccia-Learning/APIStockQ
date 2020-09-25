# APIStockQ

> 專案將使用.netCore+EF+Sqlite+Swagger的方式為基本架構。



[2020-09-25]

Python相關：

- [ ] 1.使用Pyhton爬出 http://www.stockq.org/的結構，看是轉成JSON or Array
- [ ] 2.實作C#與Python相關操作。

結構設計：

- [ ] 1.Model 針對各個頁面建立出相對應的

- [ ] 2.(最好情況)Controller 如果清單可以直接透過Python爬出結果直接Get

- [ ] 3.(太久)存到DB再顯示。



## ⚙ 使用套件

- EF相關
  - Microsoft.EntityFrameworkCore.SqlServer
  - Microsoft.EntityFrameworkCore.Sqlite
  - Microsoft.EntityFrameworkCore.Tools

- Swagger
  - Swashbuckle.AspNetCore.Swagger
  - Swashbuckle.AspNetCore.SwaggerGen
  - Swashbuckle.AspNetCore.SwaggerUI



## 📘首次建立起來步驟及相關紀錄

1. StockQContext.cs

   1. 建立一個資料庫連線的Class並且繼承DbContext

      ```c#
       public class StockQContext : DbContext
          {
              public StockQContext(DbContextOptions<StockQContext> options) : base(options) { }
              public DbSet<WeatherForecast> WeatherForecast { get; set; }
          }
      ```

      

2. 初始設定

   1. Startup.cs 加入連線相關設定

      ```c#
       public void ConfigureServices(IServiceCollection services)
              {
                  services.AddControllers();
                  //設定資料庫連線
           services.AddDbContext<StockQContext>(options =>
                      options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));
              }
      ```

      2. appsettings.json

         ```json
         {
           "ConnectionStrings": {
             "DefaultConnection": "Data Source=Backend.db"
           },
           "Logging": {
             "LogLevel": {
               "Default": "Information",
               "Microsoft": "Warning",
               "Microsoft.Hosting.Lifetime": "Information"
             }
           },
           "AllowedHosts": "*"
         }
         
         ```

3. 設定完畢後先假設Model&Controller都已經建好了，就可以執行Migration的語法(於套件管理主控台中執行)

```powershell
Install-Package Microsoft.EntityFrameworkCore.Tools
Add-Migration InitialCreate
Update-Database
```

