using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using xujh.Portal.Model.Entity;

namespace xujh.Portal.DAL.SqlConnetion
{
    public class sqlConnection :DbContext
    {
        public sqlConnection() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=HOME-PC;Initial Catalog=UserInfo;User ID=sa;Password=123456", b=>b.UseRowNumberForPaging());
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<UserInfoModel> UserInfo { get; set; }
    }
}
