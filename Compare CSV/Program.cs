using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string file1Path = @"C:\Users\Aksell\Downloads\Chrome Passwords.csv"; // Replace with the path to your first CSV file
        string file2Path = @"C:\Users\Aksell\Downloads\logins.csv"; // Replace with the path to your second CSV file
        string outputPath = @"C:\Users\Aksell\Downloads\converted.csv";

        try
        {
            // Read the contents of both CSV files
            List<string> file1Lines = File.ReadAllLines(file1Path).ToList();
            List<string> file2Lines = File.ReadAllLines(file2Path).ToList();

            // Concatenate the lines from both files
            List<string> allLines = file1Lines.Concat(file2Lines).ToList();

            // Remove duplicates
            List<string> uniqueLines = allLines.Distinct().ToList();

            // Write the unique lines to the output CSV file
            File.WriteAllLines(outputPath, uniqueLines);

            Console.WriteLine("Duplicates removed successfully. Output saved to 'converted.csv'");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
