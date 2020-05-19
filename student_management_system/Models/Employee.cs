using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace student_management_system.Models
{
    public class Employee
    {

        [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName="nvarchar(250)")]
        [DisplayName("Full Name")]
        [Required(ErrorMessage="This field is required")]
        public string FullName { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Office Location")]
        public string OfficeLocation { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Emp.Code")]
        public string EmpCode { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string Position { get; set; }
    }
}
