public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string delimiter)
    {
        List<string> subStrings = [..str.Split(delimiter)];
        subStrings.RemoveAt(0);

        if (subStrings.Count == 0)
        {
            return str;
        }
        else
        {
            return String.Join("", subStrings);
        }
    }

    public static string SubstringBetween(this string str, string firstDelimiter, string lastDelimiter)
    {
        int firstDelimiterIndex = str.IndexOf(firstDelimiter);
        int lastDelimiterIndex = str.IndexOf(lastDelimiter);

        firstDelimiterIndex = firstDelimiterIndex != -1 ? firstDelimiterIndex : 0;
        lastDelimiterIndex = lastDelimiterIndex != -1 ? lastDelimiterIndex : str.Length - 1;

        int subStringStart = firstDelimiterIndex + firstDelimiter.Length;
        int subStringLength = lastDelimiterIndex - subStringStart;

        return str.Substring(subStringStart, subStringLength);
    }
    
    public static string Message(this string str)
    {
        return str.SubstringAfter(": ");
    }
        
    public static string LogLevel(this string str)
    {
        return str.SubstringBetween("[", "]");
    }

}