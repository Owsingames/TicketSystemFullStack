using System;
using System.Collections.Generic;

#nullable disable

namespace TicketDeck.Models
{
    public partial class Bookmark
    {
        public int? PersonId { get; set; }
        public int? TicketId { get; set; }

        public virtual User Person { get; set; }
        public virtual Ticket Ticket { get; set; }
    }
}
