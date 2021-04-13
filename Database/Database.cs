using Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Text;

namespace Database
{
    public class Database : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-0TUFHPTU\SQLEXPRESS;Initial Catalog=DatabaseSanatorium;Integrated Security=True;MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<User> Users { set; get; }
        public virtual DbSet<Client> Clients { set; get; }
        public virtual DbSet<NumberRoom> NumberRooms { set; get; }
        public virtual DbSet<Setting> Settings { set; get; }
    }
}
