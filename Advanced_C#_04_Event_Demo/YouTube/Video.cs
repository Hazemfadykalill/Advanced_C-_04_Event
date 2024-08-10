using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__04_Event_Demo.YouTube
{
    public class Video
    {
        #region Property
        public string? VideoName { get; set; }
        public string? Discribtion { get; set; }
        #endregion
        #region Method
        public override string ToString()
        {
            return $"This Video Is {VideoName} And Discribtions Is {Discribtion} ";
        }

        #endregion
    }
}
