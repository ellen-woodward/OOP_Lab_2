using System.IO;

Console.Write("Enter student name: ");
string studentname = Console.ReadLine();

Console.Write("Enter student number: ");
string studentNumber = Console.ReadLine();

string[] subjects = new string[7];
string[] levels = new string[7];
int[] results = new int[7];
int[] points = new int[7];

for (int i = 0; i < 7; i++)
{
    Console.Write($"\nEnter subject {i + 1}: ");
    subjects[i] = Console.ReadLine();

    Console.Write($"Enter level for {subjects[i]}: ");
    levels[i] = Console.ReadLine().ToLower();

    Console.Write($"Enter result for {subjects[i]}: ");
    results[i] = int.Parse(Console.ReadLine());

}

int totalPoints = CalculatePoints(results, levels, points);

DisplayResults(studentname, studentNumber, subjects, levels, results, points, totalPoints);
;
WriteDetailsToFile(studentname, studentNumber, subjects, levels, results, points, totalPoints);

static int CalculatePoints(int[] results, string[] levels, int[] points)
{
    int[] gradeBoundaries = new int[8] { 90, 80, 70, 60, 50, 40, 30, 0 };
    int[] higherPoints = new int[8] { 100, 88, 77, 66, 56, 46, 37, 0 };
    int[] ordinaryPoints = new int[8] { 56, 46, 37, 28, 20, 12, 0, 0 };

    int total = 0, subjectPoints = 0;

    for (int i = 0; i < results.Length; i++)
    {
        int result = results[i];

        for (int j = 0; j < gradeBoundaries.Length; j++)
        {
            if (result >= gradeBoundaries[j])
            {
                subjectPoints = levels[j].Equals("h") ? higherPoints[j] : ordinaryPoints[j];
                break;
            }
        }

        points[i] = subjectPoints;
    }

    Array.Sort(points);
    Array.Reverse(points);

    for (int i = 0; i < 6; i++)
    {
        total += points[i];
    }

    return total;
}

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