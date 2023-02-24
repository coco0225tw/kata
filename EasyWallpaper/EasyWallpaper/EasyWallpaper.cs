namespace EasyWallpaper;

public class EasyWallpaper
{
    public static string WallPaper (double l, double w, double h)
    {	
        if (l == 0 || w == 0 || h == 0)
            return "zero";

        var numbers = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty"};
            
        var areaToCover = 2 * l * h + 2 * w * h;
            
        var oneRollAreaCover = 0.52 * 10;

        var rollsNeeded = areaToCover / oneRollAreaCover;

        var extraLength = rollsNeeded * 1.15;

        return numbers[(int)Math.Ceiling(extraLength)];
    }
}