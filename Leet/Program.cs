// Two Sums

/*
int[] nums = { 1, 5, 2, 6, 25, 0, 8 };

int target = 25;

for (int i = 0; i < nums.Length; i++)
{
    for (int j = 1; j < nums.Length; j++)
    {

        if (nums[i] + nums[j] == target) {
            Console.WriteLine($"{i} and {j} Because nums[{i}] + nums[{j}] == {target}");
        }
    }

}
*/

// Is Palindrome

/*
int x = 1000021;

string str = x.ToString();

for (int i = 1; i-1 < str.Length; i++) {
    
        if (str[i-1] == str[str.Length - i])
        {
            Console.WriteLine("true");
            
        }
        else
        {
            Console.WriteLine("false");
            
        }
    }
*/


// Roman to Integer

/*
using System.Collections;

    string s = Console.ReadLine();

    Hashtable roman = new Hashtable();
    roman.Add('I', 1);
    roman.Add('V', 5);
    roman.Add('X', 10);
    roman.Add('L', 50);
    roman.Add('C', 100);
    roman.Add('D', 500);
    roman.Add('M', 1000);

int total = 0;
int prev = 0;

for (int i = s.Length-1; i>=0 ;i--) {
    int currentValue = (int)roman[s[i]];

    if (prev > currentValue) {
    total -= currentValue;
    } else {
        total += currentValue;
    
    }
    prev = currentValue;
}
Console.WriteLine(total);
*/

// Longest Common Prefix

/*
string[] strs = { "dog", "racecar", "car" };
Console.WriteLine(LongestCommonPrefix(strs));
string LongestCommonPrefix(string[] strs)
{
    string prefix = strs[0];

    for (int i = 1; i < strs.Length; i++) 
    {

        while (strs[i].IndexOf(prefix)!=0) {

            return prefix.Substring(0, strs.Length-1);
        
        }    
    
    }
    return "";
}
*/

// Determine if String Halves Are Alike

/*
string s ="book";
//char[] c = s.ToCharArray();


foreach (char c in s)
{
    Console.Write(c + " , ");
}
*/
/* 
//Wrong, but splits a char array into 2 other char arrays

Console.WriteLine($" c      == {c.Length}");
Console.WriteLine($" c half == {c.Length/2}\n");

Console.WriteLine($" a      == {a.Length}");
Console.WriteLine($" b      == {b.Length}");

for (int i = 0; i < c.Length / 2; i++) {
    a[i] = c[i];
    Console.Write(a[i] + " |a| ");
}

for (int j = c.Length/2; j < c.Length; j++) {
        b[j-c.Length/2] = c[j];
        Console.Write(" ||  " + b[j - c.Length / 2] + " |b| ");
}
*/

//Contains duplicate number

/*
int[] nums = {1,2,3,4,1};
Console.WriteLine( Containsduplicate(nums));
 bool Containsduplicate(int[] nums) {
    for (int i = 0; i < nums.Length-1; i++)
    {
      
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] == nums[j])
            {

                return true;
                    }
        }
    }
    return false;
}
*/

//ver 2 with hashset

/*
int[] nums = { 1, 2, 3, 4 };

Console.WriteLine(Containsduplicate(nums));
bool Containsduplicate(int[] nums)
{

    HashSet<int> seen = new HashSet<int>();
for (int i = 0; i < nums.Length; i++)
{
    if (!seen.Add(nums[i])) { return true; }
}
return false;
}
  */



/*

class Test
{
    public delegate void f(int arg = 1);
    static f Add, Sub;
    static int Result;
    static Test()
    {
        Result = 8;
        Console.WriteLine(Result);

        Add = a;
        Sub = s;

    }
    static void a(int arg = 1) { Result += arg; }
    static void s(int arg = 1) { Result -= arg; }
    static public int GetValue(int arg)
    {
        if (arg++ == 0) Add(2);
        if (arg == 1) Add(); 
        if (arg % 2 == 1) Add(5);
        else if (arg / 2 == 2) Add(4);
        Add();
        return Result++;
    }
    static void Main()
    {
        Console.WriteLine(Test.GetValue(0));
        Console.WriteLine(Test.GetValue(1));
        Console.WriteLine(Test.GetValue(2));
        Console.WriteLine(Test.GetValue(3));
        Console.WriteLine(Test.GetValue(4));
    }
}

*/

/*
using static System.Net.Mime.MediaTypeNames;

class Element
{
    public double v;
    public Element(int a) { v = a; }
    public Element(double a) { v = a; }
    public Element(int a, int b) { v = a + b; }
    public Element(float a, int b = 1) { v = a + b + 1; }
    public Element(double a, int b = 1) { v = a + b + 2; }
    public Element(Element e) { this.v = e.v; }
    public Element(Element a, Element b) { v = a.v + b.v; }
    static void Main()
    {
        //Element e = new Element(new Element(0, 0), new Element(3, 0));


        // Element e = new Element(new Element(0), new Element(0));


        //  Element e = new Element(new Element(new Element(5.0f, 1)));


        Element e = new Element(new Element(new Element(1, 5)));

        Console.WriteLine(e.v);

    }
}
*/

/*
class Element
{
    public double v;
    public Element() { v = 0; }
    public Element(int a, int b) { v = a + b; }
    public Element(float a, int b) { v = a + b + 1; }
    public Element(Element e) { this.v = e.v; }
    public Element(Element a, Element b) { v = a.v + b.v; }

    static void Main()
    {
        //Element e = new Element(new Element(0, 0), new Element(3, 0));


       Element e = new Element(new Element(), new Element());


       // Element e = new Element(new Element(new Element(5.0f, 1)));


       // Element e = new Element(new Element(new Element(1, 5)));
       Console.WriteLine(e);
    }
}
*/


// Tests
/*
int a = 2;
String b = "2";
Console.WriteLine(a + b);
*/