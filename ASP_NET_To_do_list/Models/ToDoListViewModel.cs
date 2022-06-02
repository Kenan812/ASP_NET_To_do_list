using System.Collections.Generic;

namespace ASP_NET_To_do_list.Models
{
    public class ToDoListViewModel
    {
        public TaskViewModel Task { get; set; }
        public List<TaskViewModel> ToDoList { get; set; }
        public ToDoListViewModel()
        {
            ToDoList = new List<TaskViewModel>();
        }
    }
}
