using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeAPI.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key] 
        public int id { get; set; }
        public string? name { get; set; }
        public string? designation { get; set; }
        public decimal age { get; set; }
    }
}
