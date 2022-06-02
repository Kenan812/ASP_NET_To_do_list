using System.ComponentModel.DataAnnotations;

namespace ASP_NET_To_do_list.Models
{
    public class TaskViewModel
    {
        public int Id { get; set; }
        public string Task { get; set; }
    }
}
