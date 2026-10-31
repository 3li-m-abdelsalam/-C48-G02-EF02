using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm_2_EF.Model
{
    public class Badge
    {
        public int Id { get; set; }

        public int BadgeNumber { get; set; }

        public DateTime IssuedDate { get; set; }

        public BadgeTier Tier { get; set; }

        public int AttendeeId { get; set; }

        public Attendee Attendee { get; set; }
    }

    public enum BadgeTier
    {
        Standard,
        VIP
    }
}
