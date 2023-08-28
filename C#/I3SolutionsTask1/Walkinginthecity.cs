namespace I3SolutionsTask1;

public static class Walkinginthecity
{
    public static bool IsValidWalk(char[] walk)
    {
        if (walk.Length != 10)
        {
            return false;
        }
        int northCount = walk.Count(c => c == 'n');
        int southCount = walk.Count(c => c == 's');
        int eastCount = walk.Count(c => c == 'e');
        int westCount = walk.Count(c => c == 'w');

        return northCount == southCount && eastCount == westCount;
    }
}