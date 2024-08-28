using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhập số phần tử của mảng và giá trị cần tìm kiếm
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());

            // Khai báo mảng A
            int[] A = new int[n];

            // Nhập giá trị cho mảng A
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                A[i] = int.Parse(input[i]);
            }

            // Tìm kiếm vị trí đầu tiên của X trong mảng A
            int index = Array.IndexOf(A, x);

            // Nếu X xuất hiện trong mảng A
            if (index != -1)
            {
                // Xóa vị trí đầu tiên của X trong mảng A
                for (int i = index; i < n - 1; i++)
                {
                    A[i] = A[i + 1];
                }
                Array.Resize(ref A, n - 1);

                // In ra mảng A sau khi xóa
                for (int i = 0; i < A.Length; i++)
                {
                    Console.Write(A[i] + " ");
                }
            }
            // Nếu X không xuất hiện trong mảng A
            else
            {
                Console.WriteLine("NOT FOUND");
            }

            Console.ReadKey();
        }
    }
}
