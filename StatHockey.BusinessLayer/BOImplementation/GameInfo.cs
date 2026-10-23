using System;
using StatHockey.BusinessLayer.BOInterfaces;
using System.Collections.Generic;
using System.Text;


namespace StatHockey.BusinessLayer.BOImplementation
{
    public class GameInfo : IGameInfo
    {
        public Game Game { get; set; }
    }
}
