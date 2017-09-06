/*
using的用法：
1. using指令：引入命名空间
这是最常见的用法，例如：
using System;
using Namespace1.SubNameSpace;
2. using static 指令：指定无需指定类型名称即可访问其静态成员的类型
using static System.Math;var = PI; // 直接使用System.Math.PI
3. 起别名
using Project = PC.MyCompany.Project;
4. using语句：将实例与代码绑定
using (Font font3 = new Font("Arial", 10.0f),
            font4 = new Font("Arial", 10.0f))
{
    // Use font3 and font4.
}
*/

//using 关键字表明程序使用的是给定命名空间中的名称。
//使用 using 命名空间指令，这样在使用的时候就不用在前面加上命名空间名称。该指令告诉编译器随后的代码使用了指定命名空间中的名称
using System;
using His;
using His.She;



//命名空间的设计目的是提供一种让一组名称与其他名称分隔开的方式。在一个命名空间中声明的类的名称与另一个命名空间中声明的相同的类的名称不冲突
namespace Namespace
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            My_space.me me = new My_space.me();
            me.func();
            Poeple p = new Poeple();
            p.func();
        }
    }
}

namespace My_space {

    class me {

        public void func() {
            Console.WriteLine("My_space");
        }
    }
}

namespace His
{

	namespace She
	{

        class Poeple {
			public void func()
			{
				Console.WriteLine("His.she");
			}
        }
		
	}
}
