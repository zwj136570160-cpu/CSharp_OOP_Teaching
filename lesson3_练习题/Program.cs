namespace lesson3_练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("二维数组练习题");

            #region 练习题1
            //将1到10000赋值给一个二维数组（100行100列）

            //int[,] array = new int[100, 100];
            //int num = 1;
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = num++;
            //        Console.WriteLine($"行{i}，列{j}，值是：{array[i, j]}");
            //    }
            //}
            #endregion

            #region 练习题2
            //将二维数组（4行4列）的右上半部分置零（元素随机1~100）
            //int[,] appay = new int[4, 4];
            //Random random = new Random();
            //for (int i = 0; i < appay.GetLength(0); i++)
            //{
            //    for(int j = 0; j < appay.GetLength(1); j++)
            //    {
            //        appay[i,j] = random.Next(1, 100);
            //        Console.WriteLine(appay[i,j]);
            //    }
            //}
            //Console.WriteLine("-----------------------------");
            //for (int i = 0; i < appay.GetLength(0); i++)
            //{
            //    for(int j = 0; j < appay.GetLength(0); j++)
            //    {
            //        if ( i <= 1 && j >= 2 )
            //        {
            //            appay[i, j] = 0;
            //        }
            //        Console.WriteLine($"行{i}，列{j}，值是：{appay[i, j]}");
            //    }
            //}
            #endregion

            #region 练习题3
            //求二维数组（3行3列）的对角线元素的和（元素随机1~10）

            ////设置一个3行3列的二维数组
            //int[,] appay = new int[3, 3];
            ////创建随机数生成器
            //Random random = new Random();
            ////定义一个变量用来存储对角线元素的和
            //int sum = 0;
            //for (int i = 0; i < appay.GetLength(0); i++)
            //{
            //    for (int j = 0; j < appay.GetLength(1); j++)
            //    {
            //        appay[i, j] = random.Next(1, 11);
            //        Console.Write($"{appay[i, j]} ");
            //        if (i != 1 && j != 1)
            //        {
            //            sum += appay[i, j];
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine($"3行3列的数组对角线元素的和：{sum}");
            #endregion

            #region 练习题4
            //求二维数组（5行5列）中最大元素值及其行列号（元素随机1~500）

            //int[,] appay = new int[5, 5];
            //Random random = new Random();
            //int maxI = 0;
            //int maxJ = 0;
            //for (int i = 0; i < appay.GetLength(0); i++)
            //{
            //    for (int j = 0; j < appay.GetLength(0); j++)
            //    {
            //        appay[i, j] = random.Next(1, 501);
            //        Console.Write($"{appay[i, j]} ");
            //        //当i和j为0时，表示是第一次进入循环，直接将第一个元素赋值给max
            //        if (appay[maxI, maxJ] < appay[i, j])
            //        {
            //            maxI = i;
            //            maxJ = j;
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine($"最大值是：{appay[maxI, maxJ]}，行号是：{maxI}，列号是：{maxJ}");
            #endregion

            #region 练习题5
            //给一个M*N的二维数组，数组元素的值为0或者1，要求转换数组，将含有1的行和列全部置1
            //具体效果图见印象笔记C#基础，课时8练习题

            int[,] appay = new int[5, 5];
            Random random = new Random();
            bool[] hang = new bool[5];
            bool[] lie = new bool[5];
            for (int i = 0; i < appay.GetLength(0); i++)
            {
                for (int j = 0; j < appay.GetLength(1); j++)
                {
                    appay[i, j] = random.Next(0, 2);
                    if (appay[i,j] == 1)
                    {
                        //记录了当前行列是否要变1的标识
                        //要变一 就记录true
                        hang[i] = true;
                        lie[j] = true;
                    }
                    Console.Write(appay[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------");
            for (int i = 0; i < appay.GetLength(0); i++)
            {
                for (int j = 0; j < appay.GetLength(1); j++)
                {
                    if (hang[i] || lie[j])
                    {
                        appay[i, j] = 1;
                    }
                    Console.Write(appay[i, j] + " ");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
