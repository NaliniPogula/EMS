using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EMSLite.Models
{
    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        [Column("EmpID")]
        public int EmpId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string FirstName { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string LastName { get; set; } = null!;
        [StringLength(10)]
        [Unicode(false)]
        public string Gender { get; set; } = null!;
        [Column(TypeName = "date")]
        public DateTime DateofBirth { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Email { get; set; } = null!;
        [StringLength(20)]
        [Unicode(false)]
        public string MobileNo { get; set; } = null!;
        [StringLength(255)]
        [Unicode(false)]
        public string CurrentAddress { get; set; } = null!;
        [Column(TypeName = "date")]
        public DateTime DateofJoining { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Position { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string DepartmentName { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Manager { get; set; } = null!;
    }
}
