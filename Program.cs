public partial class Program
{
    static void Main(int b = 10, int a = 1, int x = 1)
    {
        int[][] mass = new int[b - a][];

        for (int k = 0; a < b; k++)
        {
            int[] arr = new int[9];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = a * x;
                mass[i] = arr;
                Console.Write(arr[i] + " ");
                x++;
            }
            Console.WriteLine();
            a++;
            x = 1;
        }
        Console.Write(mass[3][4]);
    }

}
