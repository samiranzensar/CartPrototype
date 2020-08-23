using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConEFDataFirst
{
	class Program
	{
		
		static void Main(string[] args)
		{
			using (ZensarTrainingEntities db = new ZensarTrainingEntities())
			{
				var allEmplys = db.EmployeeTbls.OrderBy(e => e.empName);
				Console.WriteLine("-----------------------");
				foreach (var emplys in allEmplys)
				{
					Console.WriteLine($"{emplys.empId}			{emplys.empName}			{emplys.DepartmentTbl.DeptName}");
				}
			}
			
		}
	}
}
