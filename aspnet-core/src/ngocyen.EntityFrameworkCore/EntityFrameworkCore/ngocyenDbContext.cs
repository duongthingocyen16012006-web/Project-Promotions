using Microsoft.EntityFrameworkCore; //CPSD DbContext
                                     // DbSet
                                     // DbContextOptions
                                     // Migration
using Abp.Zero.EntityFrameworkCore;// ngocyenDbContext kế thừa từ AbpZeroDbContext
using ngocyen.Authorization.Roles;// kế thừa role
using ngocyen.Authorization.Users;// kế thừa user
using ngocyen.MultiTenancy;//Vì bên trong namespace đó có entity Tenant
using ngocyen.Promotions;//Vì entity Promotion nằm trong namespace đó
namespace ngocyen.EntityFrameworkCore// Thông báo file này thuộc namespace trên
{
   
    public class ngocyenDbContext : AbpZeroDbContext<Tenant, Role, User, ngocyenDbContext>// Quản lý mapping giữa Code ↔ Database
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Promotion> Promotions { get; set; }//DbSet<Promotion> Promotions dùng để khai báo rằng
                                                        // entity Promotion sẽ được map thành bảng Promotions trong database,
                                                        // và bảng này chứa nhiều record Promotion.
        public ngocyenDbContext(DbContextOptions<ngocyenDbContext> options)//Là object chứa cấu hình database.
            : base(options)
        {
        }
    }
}
