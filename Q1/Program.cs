string filePath = "results.txt";

string[] fileContents = File.ReadAllLines(filePath);

int total = 0, points = 0, result = 0;

foreach (string line in fileContents)
{
    result = int.Parse(line);

    if (result >= 90)
        points = 100;
    else if (result >= 80)
        points = 88;
    else if (result >= 70)
        points = 77;
    else if (result >= 60)
        points = 66;
    else if (result >= 50)
        points = 56;
    else if (result >= 40)
        points = 46;
    else if (result >= 30)
        points = 37;
    else
        points = 0;

    total += points;
}

File.AppendAllText(filePath, Environment.NewLine + "Total points: " + total.ToString());