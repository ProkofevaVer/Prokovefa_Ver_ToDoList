using Microsoft.EntityFrameworkCore;
using Prokovefa_Ver_ToDoList.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prokovefa_Ver_ToDoList.Date
{
     public class TaskDbContact:DbContext
    {
        public DbSet<Model.Task> task { get; set; }
        public DbSet<DeleteTask> Deletetask { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Task_Ver;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder md)
        {
            md.Entity<DeleteTask>()
           .HasOne(x => x.task)
           .WithMany()
           .HasForeignKey(x => x.taskID);

            base.OnModelCreating(md);
        }
    }
}
