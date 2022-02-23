using System;

namespace KeyGeneretorTutorial
{

    public class CreateKeys
    {
        string YourNewKey;
        int charAmount = 4; // 20 letters

        string letters = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";

        public void GenerateKey()
        {
            YourNewKey = GiveRandomStringLetters();

            for (int i = 0; i < charAmount; i++)
            {
                if (IsNumber())
                {
                    YourNewKey = YourNewKey + GiveRandomNumber().ToString();
                }
                else
                {
                    YourNewKey = YourNewKey + GiveRandomStringLetters();
                }
            }

            Console.WriteLine(YourNewKey);
        }

        private bool IsNumber()
        {
            Random random = new Random();
            int num = random.Next(2);

            if(num == 0)
            {
                return false;
            }

            return true;
        }

        private int GiveRandomNumber()
        {
            Random random = new Random();

            int randNum = random.Next(0, 10);

            return randNum;
        }

        private string GiveRandomStringLetters()
        {
            Random random = new Random();

            string letter;

            int randNum = random.Next(letters.Length);
            char c = letters[randNum];
            letter = c.ToString();

            return letter;
        }
    }
}
