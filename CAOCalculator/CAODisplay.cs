namespace CAOCalculator
{
    public class CAODisplay
    {
        static void DisplayResults(string studentName, string studentNumber, string[] subjects,
    string[] levels, int[] results, int[] points, int total)
        {
            Console.WriteLine($"\nStudent Name: {studentName}");
            Console.WriteLine($"Student No.: {studentNumber}");

            for (int i = 0; i < results.Length; i++)
            {
                Console.WriteLine($"{subjects[i],10} {levels[i],10} {results[i],10} {points[i],10}");
            }

            Console.WriteLine($"Total Points: {total}");
        }

        static void WriteDetailsToFile(string studentName, string studentNumber, string[] subjects,
            string[] levels, int[] results, int[] points, int total)
        {
            StreamWriter sw = new StreamWriter("Results.txt");

            sw.WriteLine($"Student Name: {studentName}");
            sw.WriteLine($"Student No.: {studentNumber}");

            for (int i = 0; i < results.Length; i++)
            {
                sw.WriteLine($"{subjects[i],10} {levels[i],10} {results[i],10} {points[i],10}");
            }

            sw.WriteLine($"Total Points: {total}");

            sw.Flush();
            sw.Close();

            Console.WriteLine("Successfully written to file");
        }
    }
}
