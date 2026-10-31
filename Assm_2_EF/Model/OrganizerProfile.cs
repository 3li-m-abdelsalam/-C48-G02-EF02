using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm_2_EF.Model
{
    public class OrganizerProfile
    {
        public int Id { get; set; }

        public string? Bio { get; set; }

        public string? Website { get; set; }

        public string? Logo { get; set; }

        public int OrganizerId { get; set; }

        public Organizer Organizer { get; set; }
    }
}
