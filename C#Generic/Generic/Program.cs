using System;
using System.Collections.Generic;

/*
使用泛型是一种增强程序功能的技术，具体表现在以下几个方面：
它有助于您最大限度地重用代码、保护类型的安全以及提高性能。
您可以创建泛型集合类。.NET 框架类库在 System.Collections.Generic 命名空间中包含了一些新的泛型集合类。您可以使用这些泛型集合类来替代 System.Collections 中的集合类。
您可以创建自己的泛型接口、泛型类、泛型方法、泛型事件和泛型委托。
您可以对泛型类进行约束以访问特定数据类型的方法。
关于泛型数据类型中使用的类型的信息可在运行时通过使用反射获取。
*/

//泛型（Generic）委托
delegate T NumberChanger<T>(T n);

namespace Generic
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //声明一个整形数组
            MyGenericArray<int> intArray = new MyGenericArray<int>(5);

            //设置值
            for (int c = 0; c < 5; c++)
            {
                intArray.setItem(c, c * 5);
            }
            //获取值
            for (int c = 0; c < 5; c++)
            {
                Console.WriteLine(intArray.getItem(c) + " ");
            }
            Console.WriteLine();


            //声明一个字符数组
            MyGenericArray<char> charArray = new MyGenericArray<char>(10);
            //设置值
            for (int i = 0; i < 10; i++)
            {
                charArray.setItem(i, (char)(i + 97));
            }
            //获取值
            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine(charArray.getItem(k) + " ");
            }

            Console.WriteLine();
            Console.ReadKey();




            int  a, b;
            char e, f;
            a = 10;
            b = 5;
            e = 'f';
            f = 'g';


			// 在交换之前显示值
			Console.WriteLine("Int values before calling swap:");
			Console.WriteLine("a = {0}, b = {1}", a, b);
			Console.WriteLine("Char values before calling swap:");
            Console.WriteLine("c = {0}, d = {1}", e, f);
            // 调用 swap
            Program.Swap <int> (ref a, ref b);
            Program.Swap <char> (ref e, ref f);

			// 在交换之后显示值
			Console.WriteLine("Int values after calling swap:");
			Console.WriteLine("a = {0}, b = {1}", a, b);
			Console.WriteLine("Char values after calling swap:");
            Console.WriteLine("c = {0}, d = {1}", e, f);
			Console.ReadKey();


            NumberChanger<int> cn1 = new NumberChanger<int>(AddNum);
            NumberChanger<int> cn2 = new NumberChanger<int>(MultNum);

            cn1(25);
            cn2(5);
			Console.WriteLine("Value of Num: {0}", getNum());
			Console.ReadKey();
		}


		static int num = 10;
		public static int AddNum(int p)
		{
			num += p;
			return num;
		}

		public static int MultNum(int q)
		{
			num *= q;
			return num;
		}
		public static int getNum()
		{
			return num;
		}

	}



	//泛型数组
	public class MyGenericArray<T>
	{
		private T[] array;

		public MyGenericArray(int size)
		{
			array = new T[size + 1];
		}

		public T getItem(int index)
		{
			return array[index];
		}

		public void setItem(int index, T value)
		{
			array[index] = value;
		}
	}


	//泛型方法
	//Program
	public class Program {
        
        public	static void Swap <T> (ref T lhs, ref T rhs) {

			T temp     ;
			temp = lhs ;
			lhs  = rhs ;
			rhs  = temp;
		}
	}
}
