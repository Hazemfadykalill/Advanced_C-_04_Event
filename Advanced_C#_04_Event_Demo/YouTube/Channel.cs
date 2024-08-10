using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__04_Event_Demo.YouTube
{
    public  class Channel
    {
        #region Property
        public string? ChannelName { get; set; }
        public List<Video>? Videos { get; set; }
        #endregion
        #region Constructor
        public Channel()
        {
                Videos = new List<Video>();
        }
        #endregion
        #region Delegate Event
        public event Action? UploadVideo;
        #endregion
        #region Method

        public void AddVideo(Video video)
        {
            if (video is not    null )
            {
                Videos?.Add(video);
                //notify 
                UploadVideo?.Invoke();
            }
            
        }
        public override string ToString()
        {
            return $"Channel Name Is {ChannelName}";
        } 
         
        #endregion

    }
}
