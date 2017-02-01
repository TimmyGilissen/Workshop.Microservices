using System.Collections.Generic;
using NServiceBus;

namespace Divergent.Sales.Messages.Events
{
    public class OrderSubmittedEvent
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }

        public List<int> Products { get; set; }
    }
}
