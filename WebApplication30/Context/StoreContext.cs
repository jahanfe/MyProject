using Microsoft.EntityFrameworkCore;
using StoreProductCRUD.Models;


namespace WebApplication30.DbContext;


    public class StoreContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }