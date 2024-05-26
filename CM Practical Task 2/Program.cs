using System;

class Program
{
    static void Main()
    {
        // RandInt(a, b) , RandFloat(a, b)

        Console.WriteLine($"Random integer between (a) 10 and (b) 20: Random Integer {RandInt(10, 20 )}");
        Console.WriteLine($"Random float between (a) 0 and (b) 1: Random float {RandFloat(0, 1)}");

        double[] array = { 1.5, 2.5, 3.5, 4.5, 5.5 };

        Console.WriteLine($"Random element from the array: Random element {RandElement(array)}");

        Console.WriteLine($"Random string of length 10: Random string { RandString(10)} ");
    }

    static double Rand()
    {
        // variables:

        //max value 
        long m1 = 4294967087;       long m2 = 4294944443;

        // used to scale and mix to generate neww random values
        long a12 = 1403580;         long a13 = 810728;
        long a21 = 527612;          long a23 = 1370589;

        //additional parameters
        long q12 = 53668;           long q13 = 52774;
        long q21 = 12211;           long q23 = 3791;

        //current state of algorithm
        long r12 = 410184288;       long r13 = 3725392621;
        long r21 = 2;               long r23 = 12345;

        long h, p12, p13, p21, p23;
        
        //used in calculations
        long h12, h13;

        //used to  compute next state variables
        long k;

        //calculations
        h = r12 / q13;
        p13 = -a13 * (r13 - h * q13) + h * m1;
        h = r13 / q13;
        p12 = a12 * (r12 % q12) - a12 * (r12 / q12) * q12 - p13 + h * m1;
       
        if (p12 < 0) p12 += m1;

        r12 = r13;   r13 = r21;

        h = r12 / q12;

        p21 = -a21 * (r21 - h * q21) + h * m2;

        h = r21 / q12;

        p23 = a23 * (r23 % q23) - a23 * (r23 / q23) * q23 - p21 + h * m2;

        if (p23 < 0) p23 += m2;

        r21 = r23;
        r23 = r13;
        if (p12 < p23) k = p12 - p23 + m1;

        else k = p12 - p23;

        if (k == 0) k = m1;

        r12 = r12 % m1;     r13 = r13 % m2;
        r21 = r21 % m1;     r23 = r23 % m2;

        if (r12 < 0) r12 += m1;
        if (r13 < 0) r13 += m2;
        if (r21 < 0) r21 += m1;
        if (r23 < 0) r23 += m2;
        if (r12 > 0) r12 -= 1;

        else r12 += (m1 - 1);

        if (r13 > 0) r13 -= 1;

        else r13 += (m2 - 1);

        if (r21 > 0) r21 -= 1;

        else r21 += (m1 - 1);

        if (r23 > 0) r23 -= 1;

        else r23 += (m2 - 1);

        h12 = r12;
        h13 = r13;

        if (h12 < h13) k = h12 - h13 + m1;
        else k = h12 - h13;

        return (double)k / m1;
    }

    static int RandInt(int a, int b) { return (int) (a + (b - a + 1) * Rand()); }


    static double RandFloat(double a, double b) { return a + (b - a) * Rand(); }


    static double RandElement(double[] A)
    {
        int index = RandInt(0, A.Length - 1);

            return A[index];
    }

    static string RandString(int a)
    {
     string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+";

        Random random = new Random();

        char[] stringChars = new char[a];

        for (int i = 0; i < stringChars.Length; i++) { stringChars[i] = chars[random.Next(chars.Length)]; }


        return new string(stringChars);
    }
}
