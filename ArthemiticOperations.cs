namespace data_structure
{
    public static class Operations
    {
        public static int Exponitiation(int number, int oos)
        {
            if (oos == 1) return number;
            else return number * Exponitiation(number, oos - 1);
        }
          public static int Factorial(int number)
        {
            if (number == 1) return 1;
            else return number * Factorial(number - 1);
        }
    }
}