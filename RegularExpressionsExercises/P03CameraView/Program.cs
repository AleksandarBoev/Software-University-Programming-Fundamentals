using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P03CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] skipAndTake = Console.ReadLine().Split();
            string skip = skipAndTake[0];
            string take = skipAndTake[1];
            Regex regex = new Regex(@"\|<\w{" + skip + @"}(?<cameraView>\w{0," + take + "})");
            string camera = Console.ReadLine();

            MatchCollection matches = regex.Matches(camera);

            List<string> places = new List<string>();

            foreach (Match match in matches)
            {
                places.Add(match.Groups["cameraView"].ToString());
            }

            Console.WriteLine(string.Join(", ", places));
            //main ends here
        }
    }
}
