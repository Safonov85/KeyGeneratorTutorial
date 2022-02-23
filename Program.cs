using System;

namespace KeyGeneretorTutorial
{
    class MainClass
    {
        static CreateKeys keys = new CreateKeys();

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("New password:");
                Console.WriteLine("");
                keys.GenerateKey();
                Console.ReadKey();
            }

        }
    }
}
