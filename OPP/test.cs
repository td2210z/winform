using System;

public class DanceParty {
    public static void Main() {
        string[] nm = Console.ReadLine().Split();
        int n = int.Parse(nm[0]);
        int m = int.Parse(nm[1]);

        int[] boys = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] girls = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        Array.Sort(boys);
        Array.Sort(girls);

        int i = 0, j = 0, count = 0;
        while (i < n && j < m) {
            if (Math.Abs(boys[i] - girls[j]) <= 1) {
                count++;
                i++;
                j++;
            } else if (boys[i] < girls[j]) {
                i++;
            } else {
                j++;
            }
        }

        Console.WriteLine(count);
    }
}
