namespace OldPhonePad
{
    class Program
    {
        public static void Main(string[] args)
        {
            string input;
            OldPhoneConverter phoneObj = new OldPhoneConverter();
            while (true)
            {
                Console.WriteLine("Enter the string input ending with #:");
                input = Console.ReadLine() ?? string.Empty;
                if (phoneObj.isValidInput(input))
                {
                    string output = phoneObj.ConvertOldPhoneNumbers(input);
                    Console.WriteLine(output);
                    break;
                }
                else if (input == "cancel"){
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please use only digits from 1-9, space, *, and #");
                }
            }
        }

    }
}


