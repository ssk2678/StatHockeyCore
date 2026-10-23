using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatHockey.BusinessLayer.BOInterfaces
{
    interface ISeason
    {
        string SeasonId { get; set; }
        DateTime RegularSeasonStartDate { get; set; }
        DateTime RegularSeasonEndDate { get; set; }
        int NumberOfGames { get; set; }
        bool TiesInUse { get; set; }
        bool OlympicsParticipation { get; set; }
        bool ConferencesInUse { get; set; }
        bool DivisionsInUse { get; set; }
        bool WildCardInUse { get; set; }

    }
}
