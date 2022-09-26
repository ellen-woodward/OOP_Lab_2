using CAOCalculator;

string studentName = "Ellen";
string[] subjects = new string[7] {"Maths", "English", "Physics", "Chemistry", "Biology", "French", "Irish"};
string[] levels = new string[7] { "h", "o", "h", "o", "h", "o", "h" };
int[] results = new int[7] { 75, 87, 45, 66, 48, 91, 62 };
int[] points = new int[7];

int totalPoints = PointsCalculator.ConvertResultsToPoints(results, levels, points);

CAODisplay.DisplayResults()
