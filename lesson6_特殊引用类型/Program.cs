namespace lesson6_特殊引用类型
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("特殊的引用类型string");

            #region 知识点一 复习值和引用类型
            //值类型：存储在栈空间中，他变我不变
            //无符号 有符号 整数 浮点数 char bool 结构体（未学习）

            //引用类型：存储在堆空间中，他变我也变
            //数组（一维、二维、交错） string 类（未学习）
            #endregion

            #region 知识点二 string的它变我不变
            string str1 = "123";
            string str2 = str1;
            //因为string是引用类型，按理说，应该是他变我也变
            //string非常的特殊，他具备值类型的特征，他变我不变
            str2 = "321";
            Console.WriteLine(str1);    //123
            Console.WriteLine(str2);    //321

            //string虽然方便，但是有一个小缺点，就是频繁的改变string的值，重新赋值，会产生大量的垃圾对象，影响性能
            //优化替代方案，我们会在C#核心当中进行讲解
            #endregion


        }
    }
}
