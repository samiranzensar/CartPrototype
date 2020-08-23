namespace EFCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeTbl")]
    public partial class EmployeeTbl
    {
        [Key]
        public int empId { get; set; }

        [StringLength(20)]
        public string empName { get; set; }

        public double? empSal { get; set; }

        public int? deptId { get; set; }

        public virtual DepartmentTbl DepartmentTbl { get; set; }
    }
}
