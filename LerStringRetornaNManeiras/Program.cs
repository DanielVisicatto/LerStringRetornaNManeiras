using System.Text;

Console.WriteLine("Put you text to start the tests...");
string userInput = Console.ReadLine();

int charCount = userInput.Length;
int vowelsCount = VowelsCounter(userInput);
int consoantsCount = ConsoantsCounter(charCount, vowelsCount);
string alteredSring = AlternateCase(userInput);
string reversedString = StringReverse(userInput);

Console.WriteLine("Your input have {0} characters\n" +
    "{1} of them are vowels\n" +
    "{2} of them are consoants...\n" +
    "This is your alternated input: {3}\n" +
    "and here is your mirrored input: {4}.\n\n" +
    "Thank you for using our services!\n\n", charCount, vowelsCount, consoantsCount,
    alteredSring, reversedString);
Console.WriteLine("Press any key to exit program.");
Console.ReadLine();


string StringReverse(string userINput)
{
    char[] charArray = userInput.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}
string AlternateCase(string userInput)
{
    string alteredString = userInput;
    StringBuilder sb = new StringBuilder();
    bool uppercase = false;
    foreach (char c in alteredString)
    {
        if (uppercase)
            sb.Append(char.ToUpper(c));
        else
            sb.Append(char.ToLower(c));
        uppercase = !uppercase;
    }
    alteredString = sb.ToString();
    return alteredString;
}
int ConsoantsCounter(int charCount, int vowelsCount)
{
    string withoutSpaces = userInput.Replace(" ", "");
    int consoants = ((withoutSpaces.Length - vowelsCount) - NumbersCount(userInput)) 
        - SpecialcharactersCount(userInput);
    return consoants;
}
int NumbersCount(string userInput)
{
    return userInput.Count(x => (x == '0') || (x == '1') || (x == '2') || (x == '3') ||
    (x == '4') || (x == '5') || (x == '6') || (x == '7') || (x == '8') || (x == '9'));
}
int SpecialcharactersCount(string userInput)
{
    return userInput.Count(x => (x == '!') || (x == '@') || (x == '$') || (x == '&') ||
    (x == '*') || (x == '\"') || (x == '\'') || (x == '\\') || (x == '?') ||
    (x == '{') || (x == '}') || (x == '[') || (x == ']') || (x == '.') || (x == ';')
    || (x == '~') || (x == '^') || (x == '|') || (x == '+') || (x == '-') ||
    (x == '/') || (x == '(') || (x == ')') || (x == '#') || (x == '%') || (x == '¬')
    || (x == '=') || (x == '¨') || (x == ','));
}
int VowelsCounter(string userInput)
{
    return userInput.Count(x => (x == 'a') || (x == 'e') || (x == 'i') || (x == 'o') ||
    (x == 'u'));    
}