using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatHockey.BusinessLayer.BOImplementation;

namespace StatHockey.BusinessLayer.BOInterfaces
{
    interface IGame
    {
        
        string Copyright { get; set; }

        
        int CurrentPeriod { get; set; }

        
        string CurrentPeriodOrdinal { get; set; }

        
        string CurrentPeriodTimeRemaining { get; set; }

        
        List<Period> periods { get; set; }

        
        string GamePk { get; set; }

        
        string Link { get; set; }

        
        string GameType { get; set; }

        
        public string Season { get; set; }

        
        public DateTime GameDate { get; set; }

        
        public ShootoutInfo ShootoutInfo { get; set; }

        
        public GameTeams Teams { get; set; }

        
        public string PowerPlayStrength { get; set; }

        
        public bool HasShootout { get; set; }

       
        public IntermissionInfo IntermissionInfo { get; set; }

       
        public PowerPlayInfo PowerPlayInfo { get; set; }

       
        public Venue Venue { get; set; }
    }
}