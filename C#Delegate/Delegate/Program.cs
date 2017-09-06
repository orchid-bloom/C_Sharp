using System;
/*
 * C# 中的委托（Delegate）类似于 C 或 C++ 中函数的指针。委托（Delegate） 是存有对某个方法的引用的一种引用类型变量。引用可在运行时被改变。
委托（Delegate）特别用于实现事件和回调方法。所有的委托（Delegate）都派生自 System.Delegate 类。
*/

//delegate <return type> <delegate-name> <parameter list>

delegate int NumberChanger(int n ,string s);
delegate string StringChanger(string s);

delegate void DelegateTest(string s);

namespace DelegateAppl
{
	class TestDelegate
	{
		static int num = 10;
        public static int AddNum(int p , string str)
		{
			num += p;
			return num;
		}

        public static int MultNum(int q ,string str)
		{
			num *= q;
			return num;
		}
		public static int getNum()
		{
			return num;
		}

        public static string addString(string s) {
            return s + "asdfdghjk";
        }


        public static void writeDown( string s) {
            Console.WriteLine("dayinyixia " + s);
        }


		static void Main(string[] args)
		{
			// 创建委托实例
			NumberChanger nc1 = new NumberChanger(AddNum);
			NumberChanger nc2 = new NumberChanger(MultNum);
			// 使用委托对象调用方法
			nc1(25 ,"");
			Console.WriteLine("Value of Num: {0}", getNum());
			nc2(5 ,"");
			Console.WriteLine("Value of Num: {0}", getNum());

            StringChanger c = new StringChanger(addString);
            c("tema");
            Console.WriteLine(c("tema"));
			Console.ReadKey();

            //委托链
			//委托的多播（Multicasting of a Delegate）
			/*s
			 * 委托对象可使用 "+" 运算符进行合并。一个合并委托调用它所合并的两个委托。只有相同类型的委托可被合并。"-" 运算符可用于从合并的委托中移除组件委托。
            使用委托的这个有用的特点，您可以创建一个委托被调用时要调用的方法的调用列表。这被称为委托的 多播（multicasting），也叫组播。下面的程序演示了委托的多播：
            - 方法移除一个委托
            */
			DelegateTest test = null;
            DelegateTest test1 = new DelegateTest(writeDown);
            DelegateTest test2 = new DelegateTest(writeDown);
			DelegateTest test3 = new DelegateTest(writeDown);
			DelegateTest test4 = new DelegateTest(writeDown);

	
			test += test1;
            test += test2;
            test += test3;
            test += test4;

            test -= test1;
            test("qwerty");


            Console.Read();
		}
	}
}