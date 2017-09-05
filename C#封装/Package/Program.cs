using System;

namespace Package
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			//访问修饰符
			/*
                Public：所有对象都可以访问；
                Private：对象本身在对象内部可以访问；
                Protected：只有该类对象及其子类对象可以访问
                Internal：同一个程序集的对象可以访问；
                Protected internal：该程序集内的派生类访问，是protected和internal的交集；
            */


			//Public 访问修饰符允许一个类将其成员变量和成员函数暴露给其他的函数和对象。任何公有成员可以被外部的类访问。
			//Private 访问修饰符允许一个类将其成员变量和成员函数对其他的函数和对象进行隐藏。只有同一个类中的函数可以访问它的私有成员。即使是类的实例也不能访问它的私有成员。
			//Protected 访问修饰符允许子类访问它的基类的成员变量和成员函数。这样有助于实现继承。我们将在继承的章节详细讨论这个。更详细地讨论这个。
			//Internal 访问说明符允许一个类将其成员变量和成员函数暴露给当前程序中的其他函数和对象。换句话说，带有 internal 访问修饰符的任何成员可以被定义在该成员所定义的应用程序内的任何类或方法访问。
			//Protected Internal 访问修饰符允许在本类,派生类或者包含该类的程序集中访问。这也被用于实现继承。
		}
    }
}
