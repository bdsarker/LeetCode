public class LTC56MergeIntervals
{
   
    
    public static void Main(String[] args)
    {
        int[][]  arr = {
            new int[] { 1, 3 },
            new int[] { 2, 6 },
            new int[] { 8, 10 },
            new int[] { 15, 18 },
        };

        //Console.WriteLine(arr[^1][0]);

        Array.Sort(arr, (i, j) => i[0].CompareTo(j[0]));
        foreach( int[] i in MyMarge(arr)) { Console.WriteLine (i[0]+","+i[1]); }
    }

    public static int[][] MyMarge(int[][] intervals)
    {

        var item = new List<int[]>();
        Array.Sort(intervals, (i, j) => i[0].CompareTo(j[0]));

        item.Add(intervals[0]);

        for (int i = 1; i < intervals.Length; i++)
        {
            if (item[^1][1] >= intervals[i][0])
                item[^1][1] = Math.Max(item[^1][1], intervals[i][1]);
            else
                item.Add(intervals[i]);
        }
        return item.ToArray();
    }

}
