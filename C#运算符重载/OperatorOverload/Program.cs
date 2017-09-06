using System;

namespace OperatorOverload
{
    class MainClass
    {
		/*
            运算符 描述
            +, -, !, ~, ++, --  这些一元运算符只有一个操作数，且可以被重载。
            +, -, *, /, %   这些二元运算符带有两个操作数，且可以被重载。
            ==, !=, <, >, <=, >=    这些比较运算符可以被重载。
            &&, ||  这些条件逻辑运算符不能被直接重载。
            +=, -=, *=, /=, %=  这些赋值运算符不能被重载。
            =, ., ?:, ->, new, is, sizeof, typeof   这些运算符不能被重载。
        */
		// 是通过关键字 operator 后跟运算符的符号来定义的。与其他函数一样，重载运算符有返回类型和参数列表。
		public static void Main(string[] args)
        {
            Box box1 = new Box(23, 45.0, 34.6);
            Box box2 = new Box(23.4, 45.6, 23.5);

            Box box = box1 + box2;

            Console.WriteLine("Volume : {0}", box.length);
            Console.WriteLine("Volume : {0}", box.breadth);
            Console.WriteLine("Volume : {0}", box.height);
            Console.WriteLine("!=: {0}",box1 != box2);
			Console.WriteLine("Volume : {0}", box.getVolume());
        }
    }

    class Box {
        public double length;
        public double breadth;
        public double height;

        public double getVolume(){
            return length * breadth * height;
        }

        public Box(double l, double b , double h) {
            length = l;
            breadth = b;
            height = h;
        }

		public Box() {
			
		}
		// 重载 + 运算符来把两个 Box 对象相加
		public static Box operator+ (Box b, Box c) {
            Box box = new Box();
            box.length = b.length + c.length;
            box.breadth = b.breadth + c.breadth;
            box.height = b.height + c.height;
            return box;
        }
		public static bool operator ==(Box lhs, Box rhs)
		{
			bool status = false;
			if (lhs.length == rhs.length && lhs.height == rhs.height
			   && lhs.breadth == rhs.breadth)
			{
				status = true;
			}
			return status;
		}
        public  static bool operator !=(Box lhs, Box rhs)
		{
			bool status = false;
			if (lhs.length != rhs.length || lhs.height != rhs.height
				|| lhs.breadth != rhs.breadth)
			{
				status = true;
			}
			return status;
		}
		public static bool operator <(Box lhs, Box rhs)
		{
			bool status = false;
			if (lhs.length < rhs.length && lhs.height
				< rhs.height && lhs.breadth < rhs.breadth)
			{
				status = true;
			}
			return status;
		}

		public static bool operator >(Box lhs, Box rhs)
		{
			bool status = false;
			if (lhs.length > rhs.length && lhs.height
				> rhs.height && lhs.breadth > rhs.breadth)
			{
				status = true;
			}
			return status;
		}

		public static bool operator <=(Box lhs, Box rhs)
		{
			bool status = false;
			if (lhs.length <= rhs.length && lhs.height
				<= rhs.height && lhs.breadth <= rhs.breadth)
			{
				status = true;
			}
			return status;
		}

		public static bool operator >=(Box lhs, Box rhs)
		{
			bool status = false;
			if (lhs.length >= rhs.length && lhs.height
			   >= rhs.height && lhs.breadth >= rhs.breadth)
			{
				status = true;
			}
			return status;
		}
		public override string ToString()
		{
			return String.Format("({0}, {1}, {2})", length, breadth, height);
		}
    }
}
