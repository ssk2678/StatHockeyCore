using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatHockey.BusinessLayer.BOImplementation;

namespace StatHockey.BusinessLayer.BOInterfaces
{
    interface IPerson
    {
        string Id { get; set; }
        string FullName { get; set; }
        string Link { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        int PrimaryNumber { get; set; }
        DateTime BirthDate { get; set; }
        int CurrentAge { get; set; }
        string BirthCity { get; set; }
        string BirthStateProvince { get; set; }
        string BirthCountry { get; set; }
        string Nationality { get; set; }
        string Height { get; set; }
        int Weight { get; set; }
        bool Active { get; set; }
        bool AlternativeCaptain { get; set; }
        bool Captain { get; set; }
        bool Rookie { get; set; }
        char ShootsCatches { get; set; }
        char RosterStatus { get; set; }
        Team CurrentTeam { get; set; }
        Position PrimaryPosition { get; set; }
    }
}
