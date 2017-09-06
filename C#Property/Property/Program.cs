using System;

namespace Property
{
    class MainClass
    {
        private string address = "NBA";
        private string name = "yaoming";
        private int age = 35;

        public string Address {
            get {
                return address;
            }
            set {
                address = value;
            }
        }

        public override string ToString()
        {
            return name + age + address;
        }

        public static void Main(string[] args)
        {
            student s = new student();
            s.age = 12;
            s.name = "haha";
            Console.WriteLine(s.name,s.age);
        }
    }






	/*
    抽象属性（Abstract Properties）
    抽象类可拥有抽象属性，这些属性应在派生类中被实现。
    */
	public abstract class Person {
        public abstract string name{
            get;
            set;
        }

        public abstract int age {
            get;
            set;
        }
    }

    public class student : Person {
        
        private string name1;
        private int age1;

        public override string name {
            get {
                return name1;
            }
            set {
                name1 = value;
            }
        }

        public override int age {
            get {
                return age1;
            }

            set {
                age1 = value;
            }
        }
    }
}
