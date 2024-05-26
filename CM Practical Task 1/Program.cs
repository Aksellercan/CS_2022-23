using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine(Convert("-59", 10, 2));
        Console.WriteLine(Convert("101", 2, 10));
        Console.WriteLine(Convert("101001011101", 2, 16)); 
        Console.WriteLine(Convert("72312", 8, 8));

        try
        {
            Console.WriteLine(Convert("92312", 8, 8)); 
        }
        catch (Exception ex) {
            Console.WriteLine(ex.Message);
        } 
        
        try{
        Console.WriteLine(Convert("0xA", 10, 8)); 
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static string Convert(string number, int sourceBase, int destBase)
    {
        if (!IsValidBase(sourceBase) || !IsValidBase(destBase))
        throw new ArgumentException("Error (invalid base)");

        bool isNegative = false;
        if (number.StartsWith("-"))
        {
            isNegative = true;
            number = number.Substring(1);
        }
        else if (number.StartsWith("0x"))
        {
            if (sourceBase != 16)
                throw new ArgumentException("Error (source base ambiguous)");
            number = number.Substring(2);
        }

        long decimalValue = ConvertToDecimal(number, sourceBase);

        return ConvertFromDecimal(decimalValue, destBase, isNegative);
    }

    static long ConvertToDecimal(string number, int sourceBase)
    {
        long result = 0;
        long power = 1;

        for (int i = number.Length - 1; i >= 0; i--)
        {

            int digitValue = GetDigitValue(number[i]);

            if (digitValue >= sourceBase)
                throw new ArgumentException("Error (unrecognised  digit)");

            result += digitValue * power;
            power *= sourceBase;
        }

        return result;
    }

    static string ConvertFromDecimal(long decimalValue, int destBase, bool isNegative)
    {
        if (decimalValue == 0)
            return "0";

        string result = "";

        while (decimalValue > 0)
        {
            long remainder = decimalValue % destBase;

            result = GetDigit(remainder) + result;

            decimalValue /= destBase;
        }

        if (isNegative)
            result = "-" + result;

    return result;
    }

    static int GetDigitValue(char digit)
    {
        if (char.IsDigit(digit))

            return digit - '0';

        else if (char.ToUpper(digit) >= 'A' && char.ToUpper(digit) <= 'F')

        return char.ToUpper(digit) - 'A' + 10;

            else

                throw new ArgumentException("Unrecognized digit");
    }

    static string GetDigit(long value)
    {
        if (value >= 0 && value <= 9)

            return value.ToString();


        else if (value >= 10 && value <= 15)

            return ((char)(value - 10 + 'A')).ToString();

        else
            throw new ArgumentException("Invalid digit value");
    }

    static bool IsValidBase(int numBase) { return numBase >= 2 && numBase <= 16; }

}




