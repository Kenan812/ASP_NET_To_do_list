using ASP_NET_To_do_list.Models;

namespace ASP_NET_To_do_list.Services
{
    public interface IToDoListService
    {
        void Add(string task);
        void Remove(int id);
        ToDoListViewModel Get();
    }
}
