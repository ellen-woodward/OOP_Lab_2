string filePath = "results.txt";
string[] fileContents = File.ReadAllLines(filePath);

Console.WriteLine($"Total points: {CalculatePoints(fileContents)}");

static int CalculatePoints(string[] data)
{
    int[] gradeBoundaries = new int[8] { 90, 80, 70, 60, 50, 40, 30, 0 };
    int[] higherPoints = new int[8] { 100, 88, 77, 66, 56, 46, 37, 0 };

    int total = 0, points = 0, result = 0;

    foreach (string line in data)
    {
        result = int.Parse(line);

        for (int i = 0; i < gradeBoundaries.Length; i++)
        {
            if (result >= gradeBoundaries[i])
            {
                points = higherPoints[i];
                break;
            }
        }

        total += points;
    }

    return total;
}
