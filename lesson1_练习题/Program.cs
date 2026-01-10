namespace lesson1_练习题
{
    #region 练习题1 枚举
    /// <summary>
    /// QQ状态枚举
    /// </summary>
    enum E_QQType
    {
        /// <summary>
        /// 在线
        /// </summary>
        Online, //在线
        Leave,  //离开
        Busy,   //忙碌
        Invisible,  //隐身
    }
    #endregion

    #region 练习题2 枚举
    /// <summary>
    /// 咖啡枚举
    /// </summary>
    enum E_Coffee
    {
        Medium,
        Large,
        Extra_Large,
    }
    #endregion

    #region 练习题3 枚举
    /// <summary>
    /// 性别
    /// </summary>
    enum E_Gender
    {
        /// <summary>
        /// 男性
        /// </summary>
        Man,
        /// <summary>
        /// 女性
        /// </summary>
        Woman,
    }

    /// <summary>
    /// 职业
    /// </summary>
    enum E_Occ
    {
        /// <summary>
        /// 战士
        /// </summary>
        War,
        /// <summary>
        /// 猎人
        /// </summary>
        Hunter,
        /// <summary>
        /// 法师
        /// </summary>
        Mage,
    }
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("枚举练习题");

            #region 练习题1
            //定义QQ状态的枚举，并提示用户选择一个在线状态，我们接受输入的数字，并将其转换成枚举类型

            //try
            //{
            //    Console.WriteLine("请选择一个QQ状态：0-在线，1-离开，2-忙碌，3-隐身");
            //    int input = int.Parse(Console.ReadLine());
            //    E_QQType qqType = (E_QQType)input;
            //    Console.WriteLine($"您选择的QQ状态是：{qqType}");
            //}
            //catch
            //{
            //    Console.WriteLine("请输入数字");
            //}
            #endregion

            #region 练习题2
            //用户去星巴克买咖啡，分为中杯（35元），大杯（40元），超大杯（43元）
            //请用户选择要购买的类型，用户选择后打印：您购买了xxx咖啡，花费了xx元
            //例如：你购买了中杯咖啡，花费了35元

            //try
            //{
            //    Console.WriteLine("请输入咖啡的种类：0-中杯，1-大杯，2-超大杯");
            //    int input = int.Parse(Console.ReadLine());
            //    E_Coffee coffee = (E_Coffee)input;
            //    switch (coffee)
            //    {
            //        case E_Coffee.Medium:
            //            Console.WriteLine("你购买了中杯咖啡，花费了35元");
            //            break;
            //        case E_Coffee.Large:
            //            Console.WriteLine("你购买了大杯咖啡，花费了40元");
            //            break;
            //        case E_Coffee.Extra_Large:
            //            Console.WriteLine("你购买了超大杯咖啡，花费了43元");
            //            break;
            //        default:
            //            Console.WriteLine("请输入正确类型");
            //            break;
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("请输入正确数字");
            //}
            #endregion

            #region 练习题3
            //请用户选择英雄性别与英雄职业，最后打印英雄的基本属性（攻击力，防御力，技能）
            //性别：
            //男（攻击力 + 50，防御力 + 100）
            //女（攻击力 + 150，防御力 + 20）
            //职业：
            //战士（攻击力 + 20，防御力 + 100，技能：冲锋）
            //猎人（攻击力 + 120，防御力 + 30，技能：假死）
            //法师（攻击力 + 200，防御力 + 10，技能：奥术冲击）
            //举例打印：你选择了“女性法师”，攻击力：350，防御力：30，职业技能：奥术冲击

            try
            {
                string ganderStr = "";
                int Atk = 0;
                int Def = 0;
                Console.WriteLine("请选择您的英雄性别：0-男， 1-女");
                int genderIndex = int.Parse(Console.ReadLine());
                E_Gender gender = (E_Gender)genderIndex;
                switch (gender)
                {
                    case E_Gender.Man:
                        ganderStr = "男性";
                        break;
                    case E_Gender.Woman:
                        ganderStr = "女性";
                        break;
                    default:
                        Console.WriteLine("请输入正确编号");
                        break;
                }
                string Cls = "";
                string Sk = "";
                Console.WriteLine("请选择您的英雄职业：0-战士，1-猎人，2-法师");
                E_Occ occIndex = (E_Occ)int.Parse(Console.ReadLine());
                switch (occIndex)
                {
                    case E_Occ.War:
                        Cls = "战士";
                        Atk = 20;
                        Def = 100;
                        Sk = "冲锋";
                        break;
                    case E_Occ.Hunter:
                        Cls = "猎人";
                        Atk = 120;
                        Def = 30;
                        Sk = "假死";
                        break;
                    case E_Occ.Mage:
                        Cls = "法师";
                        Atk = 200;
                        Def = 10;
                        Sk = "奥数冲击";
                        break;
                    default:
                        Console.WriteLine("请输入正确编号");
                        break;
                }
                Console.WriteLine($"你选择了“{ganderStr}{Cls}”，攻击力：{Atk}，防御力：{Def}，职业技能：{Sk}");
            }
            catch
            {
                Console.WriteLine("请输入数字");
            }
            #endregion
        }
    }
}
