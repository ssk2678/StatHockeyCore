using System;
using System.Collections.Generic;
using System.Text;

namespace StatHockey.BusinessLayer.BOImplementation
{
    public class TeamInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public Venue Venue { get; set; }
        public string Abbreviation { get; set; }
        public string TeamName { get; set; }
        public string LocationName { get; set; }
        public string FirstYearOfPlay { get; set; }
        public Division Division { get; set; }
        public Conference Conference { get; set; }
        public Franchise Franchise { get; set; }
        public string ShortName { get; set; }
        public string OfficialSiteUrl { get; set; }
        public int FranchiseId { get; set; }
        public string LogoName { get; set; }
        public string LogoPath { get; set; }
        public bool Active { get; set; }
        public TeamSeasonRoster Roster { get; set; }
        public TeamStat SeasonPerformanceStats { get; set; }
        public TeamStat SeasonRankStats { get; set; }
        public string Season { get; set; }
    }
}
