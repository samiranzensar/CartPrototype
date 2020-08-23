namespace ConEFCodeFirst
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class CodeFirst : DbContext
	{
		public CodeFirst()
			: base("name=CodeFirst")
		{
		}

		public virtual DbSet<DepartmentTbl> DepartmentTbls { get; set; }
		public virtual DbSet<EmployeeTbl> EmployeeTbls { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<DepartmentTbl>()
				.Property(e => e.DeptName)
				.IsUnicode(false);

			modelBuilder.Entity<EmployeeTbl>()
				.Property(e => e.empName)
				.IsUnicode(false);
		}
	}
}
