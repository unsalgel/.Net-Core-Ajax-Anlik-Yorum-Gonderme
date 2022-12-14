
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMessage.Models.Concrete

{
	public class Context:DbContext
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
              optionsBuilder.UseSqlServer("server=UNSAL\\SQLEXPRESS;database=MessageDB;integrated security=true");
        }
        public DbSet<Message> Messages { get; set; }
    }
}
