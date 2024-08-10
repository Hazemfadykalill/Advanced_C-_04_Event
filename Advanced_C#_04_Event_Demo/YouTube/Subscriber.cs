using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__04_Event_Demo.YouTube
{
    public  class Subscriber
    {

        #region Property
        public string? SubscriberName { get; set; }
        #endregion

        #region Method
        public void Notify()
        {
            Console.WriteLine($"Note Video Added Successfully !! {SubscriberName}");
        }

        public override string ToString()
        {
            return $"SubscriberName Is {SubscriberName}";
        }
        #endregion


    }
}
