namespace StringExtensionsLibrary
{
    public static class StringExtensions
    {
        public static bool StartsWithUppercase(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return false;

            return char.IsUpper(value[0]);
        }
    }
}