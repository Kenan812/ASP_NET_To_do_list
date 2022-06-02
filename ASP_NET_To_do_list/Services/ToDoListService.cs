using ASP_NET_To_do_list.Models;
using System.Collections.Generic;
using System.Linq;

namespace ASP_NET_To_do_list.Services
{
    public class ToDoListService : IToDoListService
    {
        //private readonly TaskViewModel _taskViewModel;
        private readonly ToDoListViewModel _toDoListViewModel;
        private int _idCounter = 0;
        public ToDoListService()
        {
            _toDoListViewModel = new ToDoListViewModel();
        }
        public void Add(string task)
        {
            _toDoListViewModel.ToDoList.Add(new TaskViewModel { Id = _idCounter, Task = task });
            _idCounter++;
        }

        public void Remove(int id)
        {
            _toDoListViewModel.ToDoList.Remove(_toDoListViewModel.ToDoList.Where(x => x.Id == id).FirstOrDefault());
        }

        public ToDoListViewModel Get()
        {
            return _toDoListViewModel;
        }
    }
}
