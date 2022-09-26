int[] results = new int[7] {75, 87, 45, 66, 48, 91, 62};

Console.WriteLine($"Total points: {CalculatePoints(results)}");

static int CalculatePoints(int[] results)
{
    int[] gradeBoundaries = new int[8] { 90, 80, 70, 60, 50, 40, 30, 0 };
    int[] higherPoints = new int[8] { 100, 88, 77, 66, 56, 46, 37, 0 };

    int total = 0, points = 0;

    foreach (int result in results)
    {
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
