using System;

namespace December1st
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int lastDepth = 0;
            // Read the file and display it line by line.  
            foreach (string line in System.IO.File.ReadLines(@"depthreadings.txt"))
            {
                int depthInInt = int.Parse(line);
                if(DepthIsLarger(lastDepth, depthInInt))
                {
                    counter++;
                }

                lastDepth = depthInInt;
            }

            Console.WriteLine("There were {0} depths increasing.", counter);
            Console.ReadLine();
        }

        private static bool DepthIsLarger(int depth1, int depth2)
        {
            if (depth1 == 0)
                return false;
            return depth1 <= depth2;
        }
    }
}
