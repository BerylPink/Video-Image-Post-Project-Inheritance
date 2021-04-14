using System;

namespace VideoImagePostProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes", true, "Timi Adiel");
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("Check out my new shoes",
                "Timi Adiel", "https://images.com/shoes", true);

            Console.WriteLine(imagePost1.ToString());

            VideoPost videoPost1 = new VideoPost("I love this video", "Timi Adiel", 
                "https://www.youtube.com/watch?v=iSgUMPHQEWw", 10, true);

            Console.WriteLine(videoPost1.ToString());

            videoPost1.Play();
            Console.WriteLine("Press any key to stop the video1");
            Console.ReadKey();
            videoPost1.Stop();


            Console.ReadLine();
        }
    }
}
