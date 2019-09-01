using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ConsoleApp.SQLite
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

      //  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      //  {
       //     optionsBuilder.UseSqlite("Data Source=blogging.db");
      //  }
    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }

        public ICollection<Post> Posts { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
    public class Delivery
    {
        public int DeliveryId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

    }

    public class Payment
    {
        public int PaymentId { get; set; }
        public string Order { get; set; }
        public string Amount { get; set; }

    }
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Zipcode { get; set; }
        
    }
    public class Order
    {
        public int OrderId { get; set; }
        public string Payment { get; set; }
        public string Shipping { get; set; }
        public int Customer { get; set; }
        public string Product { get; set; }
        public string Totalamount { get; set; }
        public int Email { get; set; }
        public string Productprice { get; set; }
        public int Ordertype { get; set; }

    }
    public class product
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Zipcode { get; set; }

    }
  
    public class Category
    {
        public int CategoryId { get; set; }
        public string Categoryname { get; set; }
     
    }
}