using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1;
using Xunit;
namespace Assignment1.Tests
{
	public class Example2Tests
	{
		static TimeSpan timeTest1 = new TimeSpan(0, 00, 00);

		[Fact]
		public void TicketIsASaverTicket()
		{
			bool result = Example2.CheckSaverTicket(time);

			Assert.InRange(TimeSpan timeTest1);
		}
	}
}
