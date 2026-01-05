public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string[] sections = phoneNumber.Split('-');

        bool isNewYork = sections[0] == "212";
        bool isFake = sections[1] == "555";
        string lastDigits = sections[2];
        
        return (isNewYork, isFake, lastDigits);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
