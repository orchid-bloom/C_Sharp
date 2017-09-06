/*
事件在类中声明且生成，且通过使用同一个类或其他类中的委托与事件处理程序关联。包含事件的类用于发布事件。这被称为 发布器（publisher） 类。其他接受该事件的类被称为 订阅器（subscriber） 类。事件使用 发布-订阅（publisher-subscriber） 模型。
发布器（publisher） 是一个包含事件和委托定义的对象。事件和委托之间的联系也定义在这个对象中。发布器（publisher）类的对象调用这个事件，并通知其他的对象。
订阅器（subscriber） 是一个接受事件并提供事件处理程序的对象。在发布器（publisher）类中的委托调用订阅器（subscriber）类中的方法（事件处理程序）。
*/
using System;
namespace SimpleEvent
{
	using System;
	/***********发布器类***********/
	public class EventTest
	{
		private int value;

		public delegate void NumManipulationHandler();

        //访问修饰符  event 委托类型 事件名称
		public event NumManipulationHandler ChangeNum;
		protected virtual void OnNumChanged()
		{
			if (ChangeNum != null)
			{
				ChangeNum(); /* 事件被触发 */
			}
			else
			{
				Console.WriteLine("event not fire");
				Console.ReadKey(); /* 回车继续 */
			}
		}


		public EventTest()
		{
			int n = 5;
			SetValue(n);
		}


		public void SetValue(int n)
		{
			if (value != n)
			{
				value = n;
				OnNumChanged();
			}
		}
	}


	/***********订阅器类***********/

	public class subscribEvent
	{
		public void printf()
		{
			Console.WriteLine("event fire");
			Console.ReadKey(); /* 回车继续 */
		}
	}

	/***********触发***********/
    // += 订阅时间
    // -= 取消时间
	public class MainClass
	{
		public static void Main()
		{
			EventTest e = new EventTest(); /* 实例化对象,第一次没有触发事件 */
			subscribEvent v = new subscribEvent(); /* 实例化对象 */
			e.ChangeNum += new EventTest.NumManipulationHandler(v.printf); /* 注册 */
			e.SetValue(7);
			e.SetValue(11);


            Bridegroom bridgeroom = new Bridegroom();

            Friend friend1 = new Friend("xiaoming");
            Friend friend2 = new Friend("xiaohong");
            Friend friend3 = new Friend("lisi");

            bridgeroom.MarrayEvent += new Bridegroom.MarrayHandler(friend1.SendMessage);
            bridgeroom.MarrayEvent += new Bridegroom.MarrayHandler(friend2.SendMessage);
            bridgeroom.MarrayEvent += new Bridegroom.MarrayHandler(friend3.SendMessage);

            bridgeroom.MarrayEvent -= new Bridegroom.MarrayHandler(friend1.SendMessage);

            bridgeroom.OnMarriageComing("我要结婚了大家一定要来啊");
            Console.ReadKey();
		}
	}

    //新郎类，消息发送者
    public class Bridegroom {
        
        //自定义委托
        public delegate void MarrayHandler(string msg);

        //使用自定义委托事件
        public event MarrayHandler MarrayEvent;

        //.NET 类库中预定义的委托类型定义的时间
        //public event EventHandler MarrayEvent;

		//发出时间
		public void OnMarriageComing (string msg) {
            
            if (MarrayEvent != null) {
                
                MarrayEvent(msg);
            }
        }
    }
    public class Friend {
        
        //属性
        public string Name;

        //构造函数
        public Friend(string name) {
            Name = name;
        }

		//时间出来函数，该函数需要符合MarrayHandler的委托定义
		public void SendMessage(string msg) {

            //输出信息
            Console.WriteLine(msg);
            //对事件做出处理
            Console.WriteLine(this.Name + "收到通知了");
        }
    }
}