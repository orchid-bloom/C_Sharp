using System;

namespace Polymorphism
{
    class MainClass
    {

		/*
            C# 多态性
            多态：一个接口多个功能。
            静态多态性：编译时发生函数响应（调用）；
            动态多态性：运行时发生函数响应。
            静态绑定（早期绑定）：编译时函数和对象的连接机制。
            两种技术实现静态多态性：函数重载/运算符重载。
            函数重载：在同一范围内对相同函数名有多个定义，可以是参数类型或参数个数的不同，但不许只有返回值类型不同。
            运算符重载：
            关键字 abstract 声明抽象类：用于接口部分类的实现（派生类继承抽象类时，实现完成）。抽象类包含抽象方法，抽象方法可被派生类实现。
            抽象类规则：
            1.不能创建抽象类的实例
            2.不能在抽象类外定义抽象方法
            3.不能把抽象类声明为sealed（类前带关键字sealed代表该类是密封类，不能被继承）
            关键字virtual声明虚方法:用于方法在继承类中的实现（在不同的继承类中有不同的实现）。
            抽象类和虚方法共同实现动态多态性。
            注：继承类中的重写虚函数需要声明关键字 override，在方法参数传入中写（类名 形参名）例如 public void CallArea(Shape sh)，意思是传入一个 shape 类型的类。
            virtual和abstract都是用来修饰父类的，通过覆盖父类的定义，让子类重新定义。
             1.virtual修饰的方法必须有实现（哪怕是仅仅添加一对大括号),而abstract修饰的方法一定不能实现。
             2.virtual可以被子类重写，而abstract必须被子类重写。
             3.如果类成员被abstract修饰，则该类前必须添加abstract，因为只有抽象类才可以有抽象方法。
             4.无法创建abstract类的实例，只能被继承无法实例化。
        */
		public static void Main(string[] args)
        {
            MainClass m = new MainClass();
            m.print(5);
            m.print(5.0);
            m.print("haha");
            Console.ReadKey();

            Rectangle r = new Rectangle(100, 300);
            Console.WriteLine("Rectangle area : {0}", r.area());

            Triangle t = new Triangle(100, 300);
            Console.WriteLine("Triangle area : {0}", t.area());
        }

		//静态多态性
		void print(int i)
        {

            Console.WriteLine("Print int : {0}", i);
        }

        void print(double d)
        {
            Console.WriteLine("Print double : {0}", d);
        }

        void print(string s)
        {
            Console.WriteLine("Print string : {0}", s);
        }
    }
#if false
    //允许您使用关键字 abstract 创建抽象类，用于提供接口的部分类的实现。当一个派生类继承自该抽象类时，实现即完成。抽象类包含抽象方法，抽象方法可被派生类实现。派生类具有更专业的功能。
    //您不能创建一个抽象类的实例。
    //您不能在一个抽象类外部声明一个抽象方法。
    //通过在类定义前面放置关键字 sealed，可以将类声明为密封类。当一个类被声明为 sealed 时，它不能被继承。抽象类不能被声明为 sealed。
    abstract class Sharp{
        
        public abstract int area();
    }

    class Rectangle : Sharp {
        private int length;
        private int width;

        public Rectangle(int w = 0, int h = 0) {

            length = w;
            width = h;
        }

        public override int area()
        {
			return width * length;
			throw new NotImplementedException();
        }
    }
#else
	//动态多态性
	//当有一个定义在类中的函数需要在继承类中实现时，可以使用虚方法。虚方法是使用关键字 virtual 声明的。虚方法可以在不同的继承类中有不同的实现。对虚方法的调用是在运行时发生的。
	//动态多态性是通过 抽象类 和 虚方法 实现的。
	class Sharp
	{
        public virtual int area() {
            return 0;
        }
	}

	class Rectangle : Sharp
	{
		private int length;
		private int width;

		public Rectangle(int w = 0, int h = 0)
		{

			length = w;
			width = h;
		}

        public override int area()
        {

            return width * length;
        }
	}

	class Triangle : Sharp
	{
		private int length;
		private int width;

		public Triangle(int w = 0, int h = 0)
		{

			length = w;
			width = h;
		}

		public override int area()
		{

			return width * length / 2;
		}
	}
#endif
}
