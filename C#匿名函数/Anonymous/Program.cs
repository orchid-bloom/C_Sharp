using System;

/* 匿名方法
我们已经提到过，委托是用于引用与其具有相同标签的方法。换句话说，您可以使用委托对象调用可由委托引用的方法。
匿名方法（Anonymous methods） 提供了一种传递代码块作为委托参数的技术。匿名方法是没有名称只有主体的方法。
在匿名方法中您不需要指定返回类型，它是从方法主体内的 return 语句推断的。
*/
namespace Anonymous
{
    delegate void NumberChanger(int n);
    class MainClass
    {
        static int num = 10;

        public static void AddNum(int p) {
            num += p;
            Console.WriteLine("Name Method: {0}",num);
        }

        public static void MultNum(int q) {
            num *= q;
            Console.WriteLine("Name method: {0}",num);
        }

        public static int getNum() {
            return num;
        }

        public static void Main(string[] args)
        {
            //使用匿名方法创建对象
            NumberChanger nc = delegate(int x) {
				Console.WriteLine("Anonymous Method: {0}", x);
			};

            //使用匿名方法调用对象；
            nc(10);

			// 使用命名方法实例化委托
			nc = new NumberChanger(AddNum);
			// 使用命名方法调用委托
			nc(5);

			// 使用命名方法调用委托
			nc = new NumberChanger(MultNum);
			nc(2);
		}
    }
}
