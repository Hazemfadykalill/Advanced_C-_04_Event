using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__04_Event_Demo.Fifa
{
    public class ReFree
    {
        #region Property

        public string? ReFreeName { get; set; }
        #endregion
        #region Method
        //call BackFunction
        public void Look()
        {
            Console.WriteLine($"ReFree Is {ReFreeName} Is Looking ");
        } 
        #endregion
    }
}
