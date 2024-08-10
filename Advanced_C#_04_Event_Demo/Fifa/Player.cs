using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__04_Event_Demo.Fifa
{
    public class Player
    {
        #region Property
        public string? NamePlayer { get; set; }
        public string? NameTeam { get; set; }
        #endregion
        #region Method
        //call BackFunction
        public void Run()
        {
            Console.WriteLine($"Player Is : {NamePlayer} And Your Team Is : {NameTeam} Is Running ");
        } 
        #endregion
    }
}
