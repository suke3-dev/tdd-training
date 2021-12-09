namespace UtilityLibraries {

public static class StringLibrary
{
    public static bool StartsWithUpper(this string? str)
    {
        if (string.IsNullOrWhiteSpace(str))
            return false;

        char ch = str[0];
        return char.IsUpper(ch);
    }

    public static string convertTest(int i) {
        return "1";
    }
}
}