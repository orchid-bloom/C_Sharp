using System;

namespace TypeConversion
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            double d = 476734.222;
            int i;
            //显式的类型转换
            i = (int)d;
            Console.WriteLine(i);


			/*
                1   ToBoolean
                如果可能的话，把类型转换为布尔型。
                2   ToByte
                把类型转换为字节类型。
                3   ToChar
                如果可能的话，把类型转换为单个 Unicode 字符类型。
                4   ToDateTime
                把类型（整数或字符串类型）转换为 日期-时间 结构。
                5   ToDecimal
                把浮点型或整数类型转换为十进制类型。
                6   ToDouble
                把类型转换为双精度浮点型。
                7   ToInt16
                把类型转换为 16 位整数类型。
                8   ToInt32
                把类型转换为 32 位整数类型。
                9   ToInt64
                把类型转换为 64 位整数类型。
                10  ToSbyte
                把类型转换为有符号字节类型。
                11  ToSingle
                把类型转换为小浮点数类型。
                12  ToString
                把类型转换为字符串类型。
                13  ToType
                把类型转换为指定类型。
                14  ToUInt16
                把类型转换为 16 位无符号整数类型。
                15  ToUInt32
                把类型转换为 32 位无符号整数类型。
                16  ToUInt64
                把类型转换为 64 位无符号整数类型。
            */


			//用 Convert  将一种基础数据类型转换为另一种类型
            int sd = Convert.ToInt16("1");
			// 用 Parse   解析为Int
            int ii = int.Parse("12");


			/*
            整数类型    sbyte、byte、short、ushort、int、uint、long、ulong 和 char
            浮点型 float 和 double
            十进制类型   decimal
            布尔类型    true 或 false 值，指定的值
            空类型 可为空值的数据类型
            */




            //变量声明
			int a = 75;
            float s = 54.002f;
            double r = 329845375.43;
            bool b = true;
			
			Console.WriteLine(a.ToString());
            Console.WriteLine(s.ToString());
            Console.WriteLine(r.ToString());
            Console.WriteLine(b.ToString());




            //常量声明


            //整数常量
            /*
             整数常量可以是十进制、八进制或十六进制的常量。前缀指定基数：0x 或 0X 表示十六进制，0 表示八进制，没有前缀则表示十进制。
             整数常量也可以有后缀，可以是 U 和 L 的组合，其中，U 和 L 分别表示 unsigned 和 long。后缀可以是大写或者小写，多个后缀以任意顺序进行组合。

            212
            215U
            213UU
            0XFeel
            0reUU
			 */

            /*
            85          十进制 
			0213        八进制 
            0x4b        十六进制 
            30          int 
            30u         无符号 int 
            30l         long 
            30ul        无符号 long 
            */




            //浮点常量
            /*
            \\  \ 字符
            \'  ' 字符
            \"  " 字符
            \?  ? 字符
            \a  Alert 或 bell
            \b  退格键（Backspace）
            \f  换页符（Form feed）
            \n  换行符（Newline）
            \r  回车
            \t  水平制表符 tab
            \v  垂直制表符 tab
            \ooo    一到三位的八进制数
            \xhh . . .  一个或多个数字的十六进制数
            */

            Console.WriteLine("helo\t word \n");





			//字符串常量
			string a1 = "hello, world";                  // hello, world
			string b1 = @"hello, world";               // hello, world
			string c1 = "hello \t world";               // hello     world
			string d1 = @"hello \t world";               // hello \t world
			string e1 = "Joe said \"Hello\" to me";      // Joe said "Hello" to me
			string f1 = @"Joe said ""Hello"" to me";   // Joe said "Hello" to me
			string g1 = "\\\\server\\share\\file.txt";   // \\server\share\file.txt
			string h1 = @"\\server\share\file.txt";      // \\server\share\file.txt
			string i1 = "one\r\ntwo\r\nthree";
            string j1 = @"one";





			//定义常量
			//const <data_type> <constant_name> = value;
			const double pi = 3.14159; // 常量声明
			double g;
            Console.WriteLine("enter:");
            g = Convert.ToDouble(Console.ReadLine());

            double areaCircle = pi * g * g;
            Console.WriteLine(areaCircle);
			Console.ReadKey();
		}

    }
}
