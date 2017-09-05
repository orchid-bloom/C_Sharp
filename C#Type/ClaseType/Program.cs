using System;

namespace ClaseType
{
    //结构可带有方法、字段、索引、属性、运算符方法和事件。
    //结构可定义构造函数，但不能定义析构函数。但是，您不能为结构定义默认的构造函数。默认的构造函数是自动定义的，且不能被改变。
    //与类不同，结构不能继承其他的结构或类。
    //结构不能作为其他结构或类的基础结构。
    //结构可实现一个或多个接口。
    //结构成员不能指定为 abstract、virtual 或 protected。
    //当您使用 New 操作符创建一个结构对象时，会调用适当的构造函数来创建结构。与类不同，结构可以不使用 New 操作符即可被实例化。
    //如果不使用 New 操作符，只有在所有的字段都被初始化之后，字段才被赋值，对象才被使用。

    //类是引用类型，结构是值类型。
    //结构不支持继承。
    //结构不能声明默认的构造函数。

    struct Books {
        public string title;
        public string author;
        public string subject;
        public int book_id;
    }

    struct People {
        private string name;
        private int age;

        public void initValue(string n,int a) {
            name = n;
            age = a;
        }

        public void display() {
            Console.WriteLine("name: {0}",name);
            Console.WriteLine("age: {0}",age);
        }
    }

	//enum 枚举列表中的每个符号代表一个整数值，一个比它前面的符号大的整数值。默认情况下，第一个枚举符号的值是 0。
	enum Days
    {
        Sun, Mon, Tur, wed, Thu, Fri, Sat
    };


    class Box {
        private double lenght;
        private double breadth;
        private double height;

        //默认构造函数
        public Box() {
            
        }

		//参数化构造函数
		public Box(double l,double b,double h) {
            lenght = l;
            breadth = b;
            height = h;
        }

        public void initValue(double l,double b ,double h) {
            lenght  = l;
            breadth = b;
            height  = h;
        }

        public double getVolume() {
            
            return lenght * breadth * height;
        }

		//析构函数
		//析构函数的名称是在类的名称前加上一个波浪形（~）作为前缀，它不返回值，也不带任何参数。
		//析构函数用于在结束程序（比如关闭文件、释放内存等）之前释放资源。析构函数不能继承或重载。
		~Box() {
            Console.WriteLine("deInit");
        }
    }


    class MainClass
    {
        public static void Main(string[] args)
        {

            //struct
            MainClass.structTest();

            People p = new People();
            p.initValue("tema",25);
            p.display();

            Box b = new Box();
            b.initValue(123,100,23);
            Console.WriteLine("Volume :{0}",b.getVolume());
		}

        public static void structTest() {
			Books book1;
			Books book2;

			book1.title = "C++";
			book1.author = "people1";
			book1.subject = "C++ programming";
			book1.book_id = 1;

			book2.title = "C#";
			book2.author = "people2";
			book2.subject = "C# Programming";
			book2.book_id = 2;

			Console.WriteLine(book1.title);
			Console.WriteLine(book1.author);
			Console.WriteLine(book1.subject);
			Console.WriteLine(book1.book_id);
			Console.ReadLine();
			Console.WriteLine(book2.title);
			Console.WriteLine(book2.author);
			Console.WriteLine(book2.subject);
			Console.WriteLine(book2.book_id);
        }
    }
}
