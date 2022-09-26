namespace CAOCalculator
{
    public class PointsCalculator
    {
        public static int ConvertResultsToPoints (int[] results, string[] levels, int[] points)
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
    }
}