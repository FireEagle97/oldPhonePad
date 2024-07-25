using System.Text;
using System.Text.RegularExpressions;

public class OldPhonePad
{
    public static void Main(string[] args)
    {
        string input;
        while (true)
        {
            Console.WriteLine("Enter the string input ending with #:");
            input = Console.ReadLine() ?? string.Empty;
            if(isValidInput(input)){
                break;
            }else{
                Console.WriteLine("Invalid input. Please use only digits from 1-9, space, *, and #");
            }
        }
        string output = ConvertOldPhoneNumbers(input);
        Console.WriteLine(output);
    }
    public static bool isValidInput(string input){
        string pattern = @"^[1-9 *]+#$";
        return Regex.IsMatch(input , pattern);
    }
    public static string ConvertOldPhoneNumbers(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return "";
        }
        Dictionary<char, string> keypadMap = new Dictionary<char, string>
        {
            {'2',"ABC" },
            {'3',"DEF"},
            {'4',"GHI" },
            {'5',"JKL"},
            {'6',"MNO"},
            {'7' ,"PQRS"},
            {'8',"TUV"},
            {'9',"WXYZ"},
        };
        StringBuilder output = new StringBuilder();
        int count = 0;
        char currentDigit = ' ';
        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                if (currentDigit == c)
                {
                    count++;
                }
                else
                {
                    if (currentDigit != ' ' && keypadMap.ContainsKey(currentDigit))
                    {
                        string letters = keypadMap[currentDigit];
                        output.Append(letters[(count - 1) % letters.Length]);

                    }
                    currentDigit = c;
                    count = 1;
                }
            }
            else
            {

                if (currentDigit != ' ' && keypadMap.ContainsKey(currentDigit))
                {
                    string letters = keypadMap[currentDigit];
                    output.Append(letters[(count - 1) % letters.Length]);

                }
                if (c == '*')
                {
                    if (output.Length > 0)
                    {
                        output.Length--;
                    }
                }
                count = 0;
                currentDigit = c;

            }
        }
        return output.ToString();

    }
}

