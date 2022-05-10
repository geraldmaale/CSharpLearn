namespace InterviewTest;

public class Decode
{
    public void Run()
    {
        // The string is:
        // 483-174-298-261-174-217-384-372-31-92-46-108-419-534-12

        // The original number, a positive number was split into digits 23-> [2, 3]
        // Each digit was converted to two number < 256 such that dividing the first number by the second number
        // results in the value of the original digit. E.g. [2,3]->[10,5,6,2]

        //int originalNumber = 23;

        // convert each digit to two numbers
        for (int rnd = 1; rnd < 256; rnd++)
        {
            // split the number into digits
            int[] digits = rnd.ToString().ToCharArray().Select(c => int.Parse(c.ToString())).ToArray();

            //int[] convertedDigits = new int[digits.Length];

            LinkedList<string> list = new();

            if (digits.Length > 1)
            {
                // Divide the first number by the second number
                for (var item = 0; item < digits.Length; item++)
                {
                    int firstNumber = digits[item];
                    int secondNumber = digits[item + 1];

                    if (secondNumber > 0)
                    {
                        int result = firstNumber / secondNumber;
                    }
                }
            }
        }

    }
}