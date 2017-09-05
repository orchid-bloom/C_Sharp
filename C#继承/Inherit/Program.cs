using System;

namespace Inherit
{
    
    class Shape {
        
        protected int width, height;

		//基类的初始化
        public Shape(int w, int h) {
            width = w;
            height = h;
        }
    }

	// interface 实现多重继承
	// 基类 PaintCost
	public interface PaintCost {
		int getCost(int area);
	}
 
	//派生类继承了基类的成员变量和成员方法。因此父类对象应在子类对象创建之前被创建。您可以在成员初始化列表中进行父类的初始化
	class Rectangle : Shape ,PaintCost
	{
        //基类的初始化
        public Rectangle(int w,int h):base(w,h) {}
        public int getArea() {
            return width * height;
        }
        public int getCost(int area) {
            return area * 80;
        }
    }


    class MainClass
    {

        public static void Main(string[] args)
        {

            Rectangle rect = new Rectangle(100,300);

            Console.WriteLine("area: {0}",rect.getArea());
            Console.WriteLine("area: {0}", rect.getCost(rect.getArea()));
		}
    }
}
