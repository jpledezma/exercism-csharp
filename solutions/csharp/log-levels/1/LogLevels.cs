static class LogLine
{
    public static string Message(string logLine)
    {
        string[] splitted = logLine.Split("]:");
        string msg = splitted[1].Trim();

        return msg;
    }

    public static string LogLevel(string logLine)
    {
        string[] splitted = logLine.Split(['[', ']']);
        string level = splitted[1].ToLower();
        return level;
    }

    public static string Reformat(string logLine)
    {
        string message = Message(logLine);
string level = LogLevel(logLine);
return $"{message} ({level})";
    }
}
