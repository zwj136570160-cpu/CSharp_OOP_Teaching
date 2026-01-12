namespace lesson4_交错数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("非重点知识 交错数组");

            #region 知识点一 基本概念
            //交错数组 是 数组的数组，每个维度的数量可以不同

            //注意：二维数组的每行的列数相同，交错数组每行的列数可能不同
            #endregion

            #region 知识点二 数组的申明

            //第一种
            //变量类型[][] 交错数组名;
            int[][] arr1;

            //第二种
            //变量类型[][] 交错数组名 = new 变量类型[行数][];
            int[][] arr2 = new int[3][];

            //第三种
            //变量类型[][] 交错数组名 = new 变量类型[行数][]{ 一维数组, 一维数组, ... }
            int[][] arr3 = new int[3][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5 },
                new int[] { 6, 7, 8, 9 }
            };

            //第四种
            //变量类型[][] 交错数组名 = new 变量类型[][]{ 一维数组, 一维数组, ... }
            int[][] arr4 = new int[3][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5 },
                new int[] { 6, 7, 8, 9 }
            };

            //第五种
            //变量类型[][] 交错数组名 = { 一维数组, 一维数组, ... }
            int[][] arr5 = 
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5 },
                new int[] { 6, 7, 8, 9 }
            };
            #endregion

            #region 知识点三 数组的使用

            int[][] array =
            {
                new[] { 1, 2, 3 },
                new[] { 4, 5 }
            };
            //1.数组的长度
            //行
            Console.WriteLine(array.GetLength(0));  //2
            //得到某一行的列数
            Console.WriteLine(array[0].Length); //3

            //2.获取交错数组中的元素
            //注意：不要越界
            Console.WriteLine(array[0][1]); //2

            //3.修改交错数组中的元素
            array[1][0] = 100;
            Console.WriteLine(array[1][0]); //100

            //4.遍历交错数组
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"{array[i][j]} ");   // 1 2 3
                                                        // 100 5
                }
                Console.WriteLine();    
            }
            Console.WriteLine("-----------------------------");

            //5.增加交错数组的元素
            int[][] array2 = new int[3][];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                //配置array2每一行的列数
                array2[i] = new int[array[i].Length];
                for (int j = 0; j < array[i].Length; j++)
                {
                    array2[i][j] = array[i][j];
                    Console.Write($"{array[i][j]} ");
                }
                Console.WriteLine();
            }
            array = array2;
            Console.WriteLine("-----------------------------------");
            //给交错数组增加一行
            array[2] = new int[3] { 6, 7, 8 };
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"{array[i][j]} ");   //1 2 3
                                                        //100 5
                                                        //6 7 8
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------");

            //6.删除交错数组的元素
            int[][] array3 = new int[2][];
            for (int i = 0; i < array3.GetLength(0); i++)
            {
                array3[i] = new int[array[i].Length];
                for (int j = 0; j < array[i].Length; j++)
                {
                    array3[i][j] = array[i][j];
                    Console.Write($"{array[i][j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------");
            array = array3;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"{array[i][j]} ");   //1 2 3
                                                        //100 5
                }
                Console.WriteLine();
            }

            //7.查找交错数组中的元素
            int a = 100;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] == a)
                    {
                        Console.WriteLine($"找到了，位置在：{i}行 {j}列");    //1行0列
                    }
                }
            }
            #endregion

            //总结
            //1.概念：交错数组 可以存储同一类型的行 不确定列的数据
            //2.一定要掌握的内容：申明、遍历、增删查改
            //3.所有的变量类型都可以申明为 交错数组
            //4.一般交错数组很少使用 了解即可
        }
    }
}
