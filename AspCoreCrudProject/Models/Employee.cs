using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AspCoreCrudProject.Models
{
    public class Employee
    {
        [Key]
        public int Emp_Id { get; set; }
        public string? Emp_Name { get; set; }  // Changed to string instead of int
        public int Emp_Age { get; set; }
        public string? Emp_Gender { get; set; }
        public DateTime Emp_JoiningDate { get; set; }
        public string? Designation { get; set; }
        public decimal Emp_Salary { get; set; } // Changed to decimal for salary
    }
}
