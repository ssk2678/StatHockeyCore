using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatHockey.BusinessLayer.BOImplementation;

namespace StatHockey.BusinessLayer.BOInterfaces
{
    public interface ITeam
    {
        int Id { get; set; }
        string Name { get; set; }
        string Link { get; set; }
        Venue Venue { get; set; }
        string Abbreviation { get; set; }
        string TeamName { get; set; }
        string LocationName { get; set; }
        string FirstYearOfPlay { get; set; }
        Division Division { get; set; }
        Conference Conference { get; set; }
        Franchise Franchise { get; set; }
        string ShortName { get; set; }
        string OfficialSiteUrl { get; set; }
        int FranchiseId { get; set; }
        string LogoName { get; set; }
        string LogoPath { get; set; }
        bool Active { get; set; }
        TeamSeasonRoster Roster { get; set; }
        List<TeamSeasonStatistics> TeamStats { get; set; }

    }
}

