using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__04_Event_Demo.Fifa
{
    public  struct Location
    {
        #region Property
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        #endregion
        #region Method
        public override string ToString()
        {
            return $"( {X}, {Y} , {Z})";
        } 
        #endregion
    }
}
