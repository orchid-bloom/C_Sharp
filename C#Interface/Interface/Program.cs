﻿using System;

namespace Interface
{
	/*
    接口定义了所有类继承接口时应遵循的语法合同。接口定义了语法合同 "是什么" 部分，派生类定义了语法合同 "怎么做" 部分。
    接口定义了属性、方法和事件，这些都是接口的成员。接口只包含了成员的声明。成员的定义是派生类的责任。接口提供了派生类应遵循的标准结构。
    接口使得实现接口的类或结构在形式上保持一致。
    抽象类在某种程度上与接口类似，但是，它们大多只是用在当只有少数方法由基类声明由派生类实现时。
    */

	//接口使用 interface 关键字声明，它与类的声明类似。接口声明默认是 public

	interface IParentInterface {
		// 接口成员
        void ParentInterfaceMethod();
	}

    interface IMyInterface : IParentInterface {
		// 接口成员
        void MethodToImplement();
	}

	//接口的实现与类的继承语法格式类似
	class MainClass : IMyInterface
    {
        public static void Main(string[] args)
        {
            MainClass my = new MainClass();
             my.MethodToImplement();
            my.ParentInterfaceMethod();
        }

        public void MethodToImplement() {
			Console.WriteLine("MethodToImplement() called.");
		}

        public void ParentInterfaceMethod() {
			Console.WriteLine("ParentInterfaceMethod() called.");
		}
    }
}
