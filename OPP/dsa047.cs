string[] mns = Console.ReadLine().Split(' ');
            int m = int.Parse(mns[0]);
            int n = int.Parse(mns[1]);
            int s = int.Parse(mns[2]);

            int[,] a = new int[m, n];
            int[,] b = new int[n, s];
            int[,] c = new int[1000, 10000];
            for (int i = 0;i < m; ++i)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(input[j]);
                }
            }
            for (int i = 0;i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int j =0;j < s; j++)
                {
                    b[i , j] = int.Parse(input[j]);
                }
            }
            int ans = 0;
            for (int i =0;i < m; i++)
            {
                for (int j = 0; j  < s; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        c[i , j] += a[i,k] * b[k,j];
                    }
                }
            }
            for (int i = 0; i < m ; i++){
                for (int j = 0; j < s; j++)
                {
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();
            }
            //Console.WriteLine(cnt1 + " " + cnt2 + " " + cnt3 + cnt4+ "\n");
            Console.ReadKey();