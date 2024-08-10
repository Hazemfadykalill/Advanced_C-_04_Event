using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__04_Event_Demo.Fifa
{
    public class Ball
    {
        #region Attributes
        Location location;
        #endregion

        #region Property Prop
        public int Id { get; set; }
        #endregion

        #region Property PropFull
        public Location Location
        {
            get { return location; }
            //Event
            set {
                if (!value.Equals(location))
                {
                    location = value;
                    //Notify Subscribe
                    BallEventChangedLocation?.Invoke();
                }
                
            }
        }
        #endregion

        #region Delegate
        public event Action? BallEventChangedLocation;
        #endregion
        #region Method
        public override string ToString()
        {
            return $"Id Ball Is {Id} And Location Is {location}";
        } 
        #endregion

    }
}
