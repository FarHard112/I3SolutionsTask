namespace I3SolutionsTask2;

public static class FindOutliner
{
    public static int FindOutlinerMethod(int[] arr)
    {
        int[] oddNumbers = arr.Where(n => n % 2 != 0).ToArray();
        int[] evenNumbers = arr.Where(n => n % 2 == 0).ToArray();
        return oddNumbers.Length == 1 ? oddNumbers[0] : evenNumbers[0];
    }
}