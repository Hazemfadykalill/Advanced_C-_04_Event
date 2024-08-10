using Advanced_C__04_Event_Demo.Fifa;
using Advanced_C__04_Event_Demo.YouTube;

namespace Advanced_C__04_Event_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Example 01 Event Fife

            //Ball ball = new Ball() { Id = 1 };
            //Console.WriteLine(ball);
            //ball.Location = new Location() { X = 1, Y = 1, Z = 1 };
            //Console.WriteLine(ball);
            //Player player01T01 = new Player() { NamePlayer = "Hazem", NameTeam = "Zamlek" };
            //Player player02T01 = new Player() { NamePlayer = "Fady", NameTeam = "Zamlek" };

            //Player player01T02 = new Player() { NamePlayer = "Mohamed", NameTeam = "AlAhly" };
            //Player player02T02 = new Player() { NamePlayer = "Mahmoud", NameTeam = "AlAhly" };

            //ReFree ReF01 = new ReFree() { ReFreeName = "Abrahim Nour El_Deen" };
            //ball.Location = new Location() { X = 1, Y = 1, Z = 1 };
            ////Subsciber
            //ball.BallEventChangedLocation += player01T01.Run;
            //ball.BallEventChangedLocation += player02T01.Run;
            //ball.BallEventChangedLocation += player01T02.Run;
            //ball.BallEventChangedLocation += player02T02.Run;
            //ball.BallEventChangedLocation += ReF01.Look;

            //ball.Location = new Location() { X = 1, Y = 1, Z = 1 };

            //Id Ball Is 1 And Location Is(0, 0, 0)
            //Id Ball Is 1 And Location Is(1, 1, 1)
            //Player Is : Hazem And Your Team Is: Zamlek Is Running
            //Player Is: Fady And Your Team Is: Zamlek Is Running
            //Player Is: Mohamed And Your Team Is: AlAhly Is Running
            //Player Is: Mahmoud And Your Team Is: AlAhly Is Running
            //ReFree Is Abrahim Nour El_Deen Is Looking








            #endregion

            #region Example 02 Event YouTube
            //Channel channel01 = new Channel()
            //{
            //    ChannelName = "ABC",

            //};

            //channel01.AddVideo(new Video() { VideoName = "C#Event", Discribtion = "Event Ahmed Amin" });
            //Subscriber Sub01 = new Subscriber() { SubscriberName = "Ahmed" };
            //Subscriber Sub02 = new Subscriber() { SubscriberName = "Ali" };
            //Subscriber Sub03 = new Subscriber() { SubscriberName = "Mariem" };
            //Subscriber Sub04 = new Subscriber() { SubscriberName = "Mahmoud" };
            //Subscriber Sub05 = new Subscriber() { SubscriberName = "Zyad" };

            //channel01.UploadVideo += Sub01.Notify;
            //channel01.UploadVideo += Sub02.Notify;
            //channel01.UploadVideo += Sub03.Notify;
            //channel01.UploadVideo += Sub04.Notify;
            //channel01.UploadVideo += Sub05.Notify;

            //channel01.AddVideo(new Video() { VideoName = "C#Delegate", Discribtion = "Delegate Ahmed Amin" });

            //channel01.UploadVideo -= Sub03.Notify;

            //channel01.AddVideo(new Video() { VideoName = "C#23", Discribtion = "23 Ahmed Amin" });


            #endregion


        }
    }
}
