using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewVlc
{
    class Program
    {
        static void Main(string[] args)
        {
            Core.Initialize();

            var libVLC = new LibVLC();

            var media = new Media(libVLC, "tcp://127.0.0.1:27184", FromType.FromLocation);

            //var media = new Media(libVLC, "e:\\Risen.mp4");
           // var media = new Media(libVLC, "http://127.0.0.1:27183", FromType.FromLocation);

            var mp = new MediaPlayer(media);
            
            Console.WriteLine(media.Duration);


            mp.Play();

            

            Console.ReadKey();
        }
    }
}
