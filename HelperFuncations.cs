using System;

namespace data_structure
{
    public static class Helper
    {
        public static void PrintNumbers(int number)
        {
            if (number == 0)
            {
                return;
                //PrintNumbers(number - 1);
            }
            Console.WriteLine(number + " , ");
            PrintNumbers(number - 1);
        }
    }

}