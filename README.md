# Test1

Exercise 1

I've created two projects. One for the code called Assignment1 and one for the tests called Assignment1.Tests

The Code coverage is in following .coveragexm file aul_WSSIMTEST 2019-04-23 11_44_00.coveragexml

Currently 81.25% of the code is tested.

Exercise 2

We need to check the actual time.

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
    
Afterwards we could write a test that checks if the time is in the range we're talking about.

	public void TicketIsASaverTicket()
		{		
      boolean ticketBool = CheckSaverTicket(Timespan time)
			Assert.InRange(time, ticketSaverStart930, saverTicketEnd1600);
      Assert.InRange(time, saverTicketStart1930, saverTicketEnd2359);
      Assert.Equal(True, ticketBool)
		}
    
One of the issues with the testcase is that it is not determined when between 7.30 pm and 9.30 am, the ticket changes back to a full fare ticket.
