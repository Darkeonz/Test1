using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Example
    {
	    public static void Main(String[] args)
	    {
		    string result = GetStringResult(args);
		    Console.Write(result);
	    }

	    public static string GetStringResult(String[] args)
	    {
		    int mi, ma;
		    if (args.Length == 0) /* 1 */
		    {			    
			    return "No numbers";
		    }
		    else
		    {
			    mi = ma = int.Parse(args[0]);
			    for (int i = 1; i < args.Length; i++) /* 2 */
			    {
				    int obs = int.Parse(args[i]);
				    if (obs > ma) ma = obs; /* 3 */
				    else if (mi < obs) mi = obs; /* 4 */
			    }
			    return "Minimum = " + mi + "; maximum = " + ma;
		    }
	    }
	}
}
