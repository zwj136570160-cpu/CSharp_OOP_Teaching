namespace lesson5_值类型和引用类型
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("值类型和引用类型");

            #region 知识点一 变量类型复习
            //无符号整形
            //byte b = 1; //8位
            //ushort us = 1;  //16位
            //uint ui = 1;    //32位
            //ulong ul = 1;   //64位

            ////有符号整形
            //sbyte sb = 1; //8位
            //short s = 1;  //16位
            //int i = 1;    //32位
            //long l = 1;   //64位

            ////浮点数
            //float f = 1.0f;    //32位
            //double d = 1.0;    //64位
            //decimal de = 1.0m; //128位

            ////特殊类型
            //bool bo = true;   //1位
            //char c = 'A';    //16位
            //string str = "Hello";

            //复杂数据类型
            //枚举 enum
            //数组（一维、二维、交错）

            //把以上学过的变量类型，分为值类型和引用类型
            //引用类型：string、数组、类（未学习）
            //值类型：其他、结构体（未学习）
            #endregion

            #region 知识点二 值和引用的区别

            //1.使用上的区别
            //值类型
            int a = 10;
            //引用类型
            int[] arr = new int[] { 1, 2, 3, 4 };
            //申明了一个b让其等于之前的a
            int b = a;
            //申明了一个arr2让其等于之前的arr
            int[] arr2 = arr;
            Console.WriteLine($"a={a},b={b}");  //a=10,b=10
            Console.WriteLine($"arr[0]={arr[0]},arr2[0]={arr2[0]}");    //arr[0]=1,arr2[0]=1

            //修改b的值为20
            b = 20;
            //修改arr2的第0个元素为5
            arr2[0] = 5;
            Console.WriteLine("修改之后b和arr2[0]后");
            //a仍然是10，b变成了20
            Console.WriteLine($"a={a},b={b}");  //a=10,b=20
            //arr2[0]变成了5，arr[0]也变成了5
            Console.WriteLine($"arr[0]={arr[0]},arr2[0]={arr2[0]}");    //arr[0]=5,arr2[0]=5

            //值类型在相互赋值时，把内容拷贝给了对方，它变我不变
            //引用类型在相互赋值时，是让两者指向了同一个值，它变我也变

            //2.为什么有以上区别
            //值类型和引用类型存储在的内存区域是不同的，存储方式是不同的，所以就造成了他们在使用上的区别

            //值类型存储在栈空间：系统分配，自动回收，小而快
            //引用类型存储在堆空间：手动申请和释放，大而慢

            //new了就是开了新房间，和之前的房间没什么关系了，所以arr不会有任何变化
            arr2 = new int[] { 99, 3, 2, 1 };
            Console.WriteLine($"arr[0]={arr[0]},arr2[0]={arr2[0]}");    //arr[0]=5,arr2[0]=99
            #endregion
        }
    }
}
