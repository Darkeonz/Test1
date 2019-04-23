# Test1

Exercise 1

I've created two projects. One for the code called Assignment1 and one for the tests called Assignment1.Tests

The Code coverage is in following .coveragexm file aul_WSSIMTEST 2019-04-23 11_44_00.coveragexml

Currently 81.25% of the code is tested.

Exercise 2

We need to check the actual time. Now since this is a blackbox technique, we only know that the metod CheckSaverTicket() returns a true boolean if it is such a ticket, and a false if it is not.

So in our test method we can check if it is within the timepan
	public void TicketIsASaverTicket()
		{		
      		boolean ticketBool = CheckSaverTicket(time)
		Assert.InRange(time, ticketSaverStart930, saverTicketEnd1600);
      		Assert.InRange(time, saverTicketStart1930, saverTicketEnd2359);
      		Assert.Equal(True, ticketBool)
		}
    
One of the issues with the testcase is that it is not determined when between 7.30 pm and 9.30 am, the ticket changes back to a full fare ticket.
