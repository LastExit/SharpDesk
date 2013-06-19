using SharpDesk.Services;
using Xunit;

namespace SharpDesk.Tests
{
    public class TicketTests
    {
        [Fact]
        public void Can_Get_Ticket_By_Ticket_Id()
        {
            var service = new TicketService();
            service.args.Add("id","495");
            var ticket = service.Get();
            Assert.NotNull(ticket);
        }

        [Fact]
        public void Can_Get_All_Tickets_Open_Unassigned()
        {
            var service = new TicketService();
            var tickets = service.GetAllNewAndMyOpen();
            Assert.NotNull(tickets);
            Assert.True(tickets.Count > 0);
        }

    }
}
