using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DevOpsApp.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? ERP { get; set; }
        public string? Course { get; set; }
    }
}
