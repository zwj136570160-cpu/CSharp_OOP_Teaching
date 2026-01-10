namespace lesson2_练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("一维数组练习题");

            #region 练习题1
            //请创建一个一维数组并赋值，让其值与下标一样，长度为100

            //int[] ints = new int[100];
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    ints[i] = i;
            //    Console.WriteLine($"下标{i},对应数值是：{ints[i]}");
            //}
            #endregion

            #region 练习题2
            //创建另一个数组B，让数组A中的每个元素的值乘以2存入到数组B中

            //int[] arrayA = { 1, 2, 3, 4, 5 };
            //int[] arrayB = new int[arrayA.Length];
            //for (int i = 0; i < arrayA.Length; i++)
            //{
            //    arrayB[i] = arrayA[i] * 2;
            //    Console.WriteLine($"数组B中的元素是：{arrayB[i]}");
            //}
            #endregion

            #region 练习题3
            //随机（0~100）生成1个长度为10的整数数组

            //int[] array = new int[10];
            //Random random = new Random();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    int Int = random.Next(100);
            //    array[i] = Int;
            //    Console.WriteLine($"数组array下标索引{i}，元素是：{array[i]}");
            //}
            #endregion

            #region 练习题4
            //从一个整数数组中找出最大值、最小值、总合、平均值（可以使用随机数1~100）

            ////设置随机数
            //Random randomNum = new Random();
            ////设置数组长度
            //int[] ints = new int[10];
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    ints[i] = randomNum.Next(1, 100);
            //}
            ////第一次进入时候，不存在最大 最小的概念，所以可以认为第一次最大 和最小值都是第一个数
            //int min = ints[0];
            //int max = ints[0];
            //int sum = 0;
            //int avg = 0;
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    //当前值如果比最小值还小，那么当前值就是最小值
            //    if (min > ints[i])
            //    {
            //        min = ints[i];
            //    }
            //    //当前值如果比最大值还大，那么当前值就是最大值
            //    if (max < ints[i])
            //    {
            //        max = ints[i];
            //    }
            //    sum += ints[i];
            //}
            //avg = sum / ints.Length;
            //Console.WriteLine($"最大值：{max}，最小值{min}，总和：{sum}，平均值：{avg}");
            #endregion

            #region 练习题5
            //交换数组中的第一个和最后一个、第二个和倒数第二个，依次类推，把数组进行反转并打印

            //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] arrayA = new int[array.Length];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    arrayA[i] = array[array.Length - 1 - i];
            //}
            //for (int i = 0; i < arrayA.Length; i++)
            //{
            //    Console.WriteLine($"{arrayA[i]}");
            //}
            #endregion

            #region 练习题6
            //将一个整数数组的每一个元素进行如下的处理：
            //如果元素是正数则将这个位置的元素值加1；
            //如果元素是负数则将这个位置的元素值减1；
            //如果元素是0，则不变

            //int[] array = new int[10];
            //Random random = new Random();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = random.Next(-10, 11);
            //    Console.WriteLine(array[i]);
            //}
            //Console.WriteLine("----------------------------------------");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] > 0)
            //    {
            //        array[i] += 1;
            //    }
            //    else if (array[i] < 0)
            //    {
            //        array[i] -= 1;
            //    }
            //    Console.WriteLine(array[i]);
            //}
            #endregion

            #region 练习题7
            //定义一个有10个元素的数组，使用for循环，输入10名同学的数学成绩，将成绩依次存入数组，然后分别求出最高分和最低分，并且求出10名同学的数学平均成绩

            //while (true)
            //{
            //    try
            //    {
            //        int min = 0;
            //        int max = 0;
            //        int sum = 0;
            //        int avg = 0;
            //        int[] array = new int[10];
            //        for (int i = 0; i < array.Length; i++)
            //        {
            //            Console.WriteLine($"请输入第{i + 1}位同学的成绩");
            //            array[i] = int.Parse(Console.ReadLine());
            //            //第一次循环的时候，最大值和最小值相等
            //            if (i == 0)
            //            {
            //                min = array[0];
            //                max = array[0];
            //            }
            //            //当i不等0的时候 才会进行比较，因为第一次没有比较意义
            //            else
            //            {
            //                if (min > array[i])
            //                {
            //                    min = array[i];
            //                }
            //                if (max < array[i])
            //                {
            //                    max = array[i];
            //                }
            //            }
            //            sum += array[i];
            //        }
            //        avg = sum / array.Length;
            //        Console.WriteLine($"最高分：{max}，最低分：{min}，平均分：{avg}");
            //        break;
            //    }
            //    catch
            //    {
            //        Console.WriteLine("请输入数字");
            //    }
            //}
            #endregion

            #region 练习题8
            //请声明一个string类型的数组(长度为25)（该数组中存储着符号），通过遍历数组的方式取出其中存储的符号打印出以下效果
            //具体效果见印象笔记C#基础 课时4 练习题8

            string[] strings = new string[25];
            for (int i = 0; i < strings.Length; i++)
            {
                //判断是否需要换行
                if (i % 5 == 0 && i != 0)
                {
                    Console.WriteLine();
                }
                //判断是否能被2整除，能输出■ 不能输出□
                if (i % 2 == 0)
                {
                    strings[i] = "■";
                }
                else
                {
                    strings[i] = "□";
                }
                Console.Write(strings[i]);
            }
            #endregion
        }
    }
}
