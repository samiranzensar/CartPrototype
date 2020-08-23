using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConLeftover
{
	public class AGenericClass<T> where T : IComparable<T> { }
	{

		
	}
	public class UsingEnum<T> where T : System.Enum { }
class Program
	{
		static void Main(string[] args)
		{
		ConLeftover.AGenericClass<string> obj = new ConLeftover.AGenericClass<string>();
		
		}
	}
}
