using System;

namespace C值类型
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//值类型
			int i = 0;
			bool a = true;
			System.Int32 k = 0;
			System.Boolean b = false;
			System.Int32 j = new int();

			Console.WriteLine (i.ToString ());
			Console.WriteLine (b.ToString ());
			Console.WriteLine (j.ToString ());

			//引用类型
			/*
			System.Object
			System.String
			System.Dynamic
			*/
			object o = new object ();
			object o2 = new object ();
			Console.WriteLine (o.GetType ());
			Console.WriteLine (o.ToString ());
			string s = "tianxin";
			string s2 = " temaxin ";
			s += s2;
			Console.WriteLine (s);
			Console.WriteLine (s == s2);
			char c = s [4];
			Console.WriteLine (c);
			Console.WriteLine (s2.Contains ("xin"));
			Console.WriteLine (s.Length);
			Console.WriteLine (s2.IndexOf ("xi"));
			Console.ReadLine ();
			//指针类型
			//type* identifier;
			//不安全类型
			//			char* cptr;
			//			int* iptr;
			//动态（Dynamic）类型 ,存储任何类型的值在动态数据类型变量中。这些变量的类型检查是在运行时发生
			//dynamic <variable_name> = value;
			dynamic d = 20;
		}
	}
}
