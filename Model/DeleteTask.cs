using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prokovefa_Ver_ToDoList.Model
{
   public class DeleteTask
    {
        public int Id { get; set; }
        public Task task { get; set; }
        public int taskID { get; set; }
        public DateTime dateTimev { get; set; }
    }
}
