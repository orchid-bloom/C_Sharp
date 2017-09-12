﻿using System;
using System.Threading;

namespace Multithreading
{
    class MainClass
    {
		/*
            属性  描述
            CurrentContext  获取线程正在其中执行的当前上下文。
            CurrentCulture  获取或设置当前线程的区域性。
            CurrentPrinciple    获取或设置线程的当前负责人（对基于角色的安全性而言）。
            CurrentThread   获取当前正在运行的线程。
            CurrentUICulture    获取或设置资源管理器使用的当前区域性以便在运行时查找区域性特定的资源。
            ExecutionContext    获取一个 ExecutionContext 对象，该对象包含有关当前线程的各种上下文的信息。
            IsAlive 获取一个值，该值指示当前线程的执行状态。
            IsBackground    获取或设置一个值，该值指示某个线程是否为后台线程。
            IsThreadPoolThread  获取一个值，该值指示线程是否属于托管线程池。
            ManagedThreadId 获取当前托管线程的唯一标识符。
            Name    获取或设置线程的名称。
            Priority    获取或设置一个值，该值指示线程的调度优先级。
            ThreadState 获取一个值，该值包含当前线程的状态。
        */



		/*
            1   public void Abort()
            在调用此方法的线程上引发 ThreadAbortException，以开始终止此线程的过程。调用此方法通常会终止线程。
            2   public static LocalDataStoreSlot AllocateDataSlot()
            在所有的线程上分配未命名的数据槽。为了获得更好的性能，请改用以 ThreadStaticAttribute 属性标记的字段。
            3   public static LocalDataStoreSlot AllocateNamedDataSlot( string name) 
            在所有线程上分配已命名的数据槽。为了获得更好的性能，请改用以 ThreadStaticAttribute 属性标记的字段。
            4   public static void BeginCriticalRegion()
            通知主机执行将要进入一个代码区域，在该代码区域内线程中止或未经处理的异常的影响可能会危害应用程序域中的其他任务。
            5   public static void BeginThreadAffinity()
            通知主机托管代码将要执行依赖于当前物理操作系统线程的标识的指令。
            6   public static void EndCriticalRegion()
            通知主机执行将要进入一个代码区域，在该代码区域内线程中止或未经处理的异常仅影响当前任务。
            7   public static void EndThreadAffinity()
            通知主机托管代码已执行完依赖于当前物理操作系统线程的标识的指令。
            8   public static void FreeNamedDataSlot(string name)
            为进程中的所有线程消除名称与槽之间的关联。为了获得更好的性能，请改用以 ThreadStaticAttribute 属性标记的字段。
            9   public static Object GetData( LocalDataStoreSlot slot ) 
            在当前线程的当前域中从当前线程上指定的槽中检索值。为了获得更好的性能，请改用以 ThreadStaticAttribute 属性标记的字段。
            10  public static AppDomain GetDomain()
            返回当前线程正在其中运行的当前域。
            11  public static AppDomain GetDomainID()
            返回唯一的应用程序域标识符。
            12  public static LocalDataStoreSlot GetNamedDataSlot( string name ) 
            查找已命名的数据槽。为了获得更好的性能，请改用以 ThreadStaticAttribute 属性标记的字段。
            13  public void Interrupt()
            中断处于 WaitSleepJoin 线程状态的线程。
            14  public void Join()
            在继续执行标准的 COM 和 SendMessage 消息泵处理期间，阻塞调用线程，直到某个线程终止为止。此方法有不同的重载形式。
            15  public static void MemoryBarrier()
            按如下方式同步内存存取：执行当前线程的处理器在对指令重新排序时，不能采用先执行 MemoryBarrier 调用之后的内存存取，再执行 MemoryBarrier 调用之前的内存存取的方式。
            16  public static void ResetAbort()
            取消为当前线程请求的 Abort。
            17  public static void SetData( LocalDataStoreSlot slot, Object data ) 
            在当前正在运行的线程上为此线程的当前域在指定槽中设置数据。为了获得更好的性能，请改用以 ThreadStaticAttribute 属性标记的字段。
            18  public void Start()
            开始一个线程。
            19  public static void Sleep( int millisecondsTimeout ) 
            让线程暂停一段时间。
            20  public static void SpinWait( int iterations ) 
            导致线程等待由 iterations 参数定义的时间量。
            21  public static byte VolatileRead( ref byte address )
            public static double VolatileRead( ref double address )
            public static int VolatileRead( ref int address )
            public static Object VolatileRead( ref Object address ) 
            读取字段值。无论处理器的数目或处理器缓存的状态如何，该值都是由计算机的任何处理器写入的最新值。此方法有不同的重载形式。这里只给出了一些形式。
            22  public static void VolatileWrite( ref byte address, byte value )
            public static void VolatileWrite( ref double address, double value )
            public static void VolatileWrite( ref int address, int value )
            public static void VolatileWrite( ref Object address, Object value ) 
            立即向字段写入一个值，以使该值对计算机中的所有处理器都可见。此方法有不同的重载形式。这里只给出了一些形式。
            23  public static bool Yield()
            导致调用线程执行准备好在当前处理器上运行的另一个线程。由操作系统选择要执行的线程。
        */
		public static void Main(string[] args)
        {

            Thread th = Thread.CurrentThread;
            th.Name = "main thread";

            Console.WriteLine("This is {0}", th.Name);
            Console.ReadKey();


            Thread work = new Thread(worker);
            work.Name = "work";
			Console.WriteLine("This is {0}", work.Name);

            work.Start();
        }

        public static void worker() {
            Thread.Sleep(5000);
            Console.WriteLine("线程退出");
        }
    }
}
