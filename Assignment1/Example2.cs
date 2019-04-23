using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DateTime = System.DateTime;

namespace Assignment1
{
	public class Example2
	{

		public static Boolean CheckSaverTicket(TimeSpan time)
		{
			TimeSpan saverTicketStart930 = new TimeSpan(9, 30, 00);
			TimeSpan saverTicketEnd1600 = new TimeSpan(16, 00, 00);
			TimeSpan saverTicketStart1930 = new TimeSpan(19, 30, 00);
			TimeSpan saverTicketEnd2359 = new TimeSpan(23, 59, 59);

			if (time > saverTicketStart930 && time < saverTicketEnd1600)
			{
				return true;
			}

			if (time > saverTicketStart1930 && time < saverTicketEnd2359)
			{
				return true;
			}

			return false;
		}
	}
}
