namespace UtilityLibraries {

    public static class StringLibrary
    {
        public static string convertTest(int i)
        {

            if (i % 3 == 0)
            {
                return "Fizz";
            }
            if (i % 5 == 0)
            {
                return "Buzz";
            }
            return i.ToString();
        }
    }
}