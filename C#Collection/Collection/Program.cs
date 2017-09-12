using System;
using System.Collections;

namespace Collection
{

	//1. ArrayList 动态数组
	//动态数组（ArrayList）代表了可被单独索引的对象的有序集合。它基本上可以替代一个数组。
	//但是，与数组不同的是，您可以使用索引在指定的位置添加和移除项目，动态数组会自动重新调整它的大小。
	//它也允许在列表中进行动态内存分配、增加、搜索、排序各项。

	/*
        Capacity    获取或设置 ArrayList 可以包含的元素个数。
        Count   获取 ArrayList 中实际包含的元素个数。
        IsFixedSize 获取一个值，表示 ArrayList 是否具有固定大小。
        IsReadOnly  获取一个值，表示 ArrayList 是否只读。
        Item    获取或设置指定索引处的元素。
    */

	/*
     *  1    public virtual int Add( object value ); 
        在 ArrayList 的末尾添加一个对象。
        2   public virtual void AddRange( ICollection c ); 
        在 ArrayList 的末尾添加 ICollection 的元素。
        3   public virtual void Clear();
        从 ArrayList 中移除所有的元素。
        4   public virtual bool Contains( object item ); 
        判断某个元素是否在 ArrayList 中。
        5   public virtual ArrayList GetRange( int index, int count ); 
        返回一个 ArrayList，表示源 ArrayList 中元素的子集。
        6   public virtual int IndexOf(object);
        返回某个值在 ArrayList 中第一次出现的索引，索引从零开始。
        7   public virtual void Insert( int index, object value ); 
        在 ArrayList 的指定索引处，插入一个元素。
        8   public virtual void InsertRange( int index, ICollection c ); 
        在 ArrayList 的指定索引处，插入某个集合的元素。
        9   public virtual void Remove( object obj ); 
        从 ArrayList 中移除第一次出现的指定对象。
        10  public virtual void RemoveAt( int index ); 
        移除 ArrayList 的指定索引处的元素。
        11  public virtual void RemoveRange( int index, int count ); 
        从 ArrayList 中移除某个范围的元素。
        12  public virtual void Reverse();
        逆转 ArrayList 中元素的顺序。
        13  public virtual void SetRange( int index, ICollection c ); 
        复制某个集合的元素到 ArrayList 中某个范围的元素上。
        14  public virtual void Sort();
        对 ArrayList 中的元素进行排序。
        15  public virtual void TrimToSize();
        设置容量为 ArrayList 中元素的实际个数。
    */



	//2.Hashtable  哈希表  字典
	/*
     * Hashtable 类代表了一系列基于键的哈希代码组织起来的键/值对。它使用键来访问集合中的元素。
       当您使用键访问元素时，则使用哈希表，而且您可以识别一个有用的键值。哈希表中的每一项都有一个键/值对。键用于访问集合中的项目。
    */
	/*
        Count   获取 Hashtable 中包含的键值对个数。
        IsFixedSize 获取一个值，表示 Hashtable 是否具有固定大小。
        IsReadOnly  获取一个值，表示 Hashtable 是否只读。
        Item    获取或设置与指定的键相关的值。
        Keys    获取一个 ICollection，包含 Hashtable 中的键。
        Values  获取一个 ICollection，包含 Hashtable 中的值。
    */
	/*
        public virtual void Add( object key, object value ); 
        向 Hashtable 添加一个带有指定的键和值的元素。
        2   public virtual void Clear(); 
        从 Hashtable 中移除所有的元素。
        3   public virtual bool ContainsKey( object key ); 
        判断 Hashtable 是否包含指定的键。
        4   public virtual bool ContainsValue( object value ); 
        判断 Hashtable 是否包含指定的值。
        5   public virtual void Remove( object key ); 
        从 Hashtable 中移除带有指定的键的元素。
    */




	//3.SortedList
	/*
        SortedList 类代表了一系列按照键来排序的键/值对，这些键值对可以通过键和索引来访问。
        排序列表是数组和哈希表的组合。它包含一个可使用键或索引访问各项的列表。
        如果您使用索引访问各项，则它是一个动态数组（ArrayList），如果您使用键访问各项，则它是一个哈希表（Hashtable）。集合中的各项总是按键值排序。
    */
	/*
        Capacity    获取或设置 SortedList 的容量。
        Count   获取 SortedList 中的元素个数。
        IsFixedSize 获取一个值，表示 SortedList 是否具有固定大小。
        IsReadOnly  获取一个值，表示 SortedList 是否只读。
        Item    获取或设置与 SortedList 中指定的键相关的值。
        Keys    获取 SortedList 中的键。
        Values  获取 SortedList 中的值。
    */
	/*
        1   public virtual void Add( object key, object value ); 
        向 SortedList 添加一个带有指定的键和值的元素。
        2   public virtual void Clear(); 
        从 SortedList 中移除所有的元素。
        3   public virtual bool ContainsKey( object key ); 
        判断 SortedList 是否包含指定的键。
        4   public virtual bool ContainsValue( object value ); 
        判断 SortedList 是否包含指定的值。
        5   public virtual object GetByIndex( int index ); 
        获取 SortedList 的指定索引处的值。
        6   public virtual object GetKey( int index ); 
        获取 SortedList 的指定索引处的键。
        7   public virtual IList GetKeyList(); 
        获取 SortedList 中的键。
        8   public virtual IList GetValueList(); 
        获取 SortedList 中的值。
        9   public virtual int IndexOfKey( object key ); 
        返回 SortedList 中的指定键的索引，索引从零开始。
        10  public virtual int IndexOfValue( object value ); 
        返回 SortedList 中的指定值第一次出现的索引，索引从零开始。
        11  public virtual void Remove( object key ); 
        从 SortedList 中移除带有指定的键的元素。
        12  public virtual void RemoveAt( int index ); 
        移除 SortedList 的指定索引处的元素。
        13  public virtual void TrimToSize(); 
        设置容量为 SortedList 中元素的实际个数。
    */



	//4.Stack堆栈
	//  Count 获取 Stack 中包含的元素个数。
	/*
        public virtual void Clear(); 
        从 Stack 中移除所有的元素。
        2   public virtual bool Contains( object obj ); 
        判断某个元素是否在 Stack 中。
        3   public virtual object Peek();
        返回在 Stack 的顶部的对象，但不移除它。
        4   public virtual object Pop();
        移除并返回在 Stack 的顶部的对象。
        5   public virtual void Push( object obj );
        向 Stack 的顶部添加一个对象。
        6   public virtual object[] ToArray();
        复制 Stack 到一个新的数组中。
    */




	//5.Queue
	/*
    队列（Queue）代表了一个先进先出的对象集合。当您需要对各项进行先进先出的访问时，则使用队列。当您在列表中添加一项，称为入队，当您从列表中移除一项时，称为出队
    */
	//Count 获取 Queue 中包含的元素个数。
	/*
    1   public virtual void Clear(); 
    从 Queue 中移除所有的元素。
    2   public virtual bool Contains( object obj ); 
    判断某个元素是否在 Queue 中。
    3   public virtual object Dequeue();
    移除并返回在 Queue 的开头的对象。
    4   public virtual void Enqueue( object obj ); 
    向 Queue 的末尾添加一个对象。
    5   public virtual object[] ToArray();
    复制 Queue 到一个新的数组中。
    6   public virtual void TrimToSize();
    设置容量为 Queue 中元素的实际个数。
    */






	//6.BitArray 点阵列
	/*
    BitArray 类管理一个紧凑型的位值数组，它使用布尔值来表示，其中 true 表示位是开启的（1），false 表示位是关闭的（0）。
    当您需要存储位，但是事先不知道位数时，则使用点阵列。您可以使用整型索引从点阵列集合中访问各项，索引从零开始。
    */
	/*
    Count   获取 BitArray 中包含的元素个数。
    IsReadOnly  获取一个值，表示 BitArray 是否只读。
    Item    获取或设置 BitArray 中指定位置的位的值。
    Length  获取或设置 BitArray 中的元素个数。
    */
	/*
    1   public BitArray And( BitArray value ); 
    对当前的 BitArray 中的元素和指定的 BitArray 中的相对应的元素执行按位与操作。
    2   public bool Get( int index ); 
    获取 BitArray 中指定位置的位的值。
    3   public BitArray Not();
    把当前的 BitArray 中的位值反转，以便设置为 true 的元素变为 false，设置为 false 的元素变为 true。
    4   public BitArray Or( BitArray value ); 
    对当前的 BitArray 中的元素和指定的 BitArray 中的相对应的元素执行按位或操作。
    5   public void Set( int index, bool value ); 
    把 BitArray 中指定位置的位设置为指定的值。
    6   public void SetAll( bool value ); 
    把 BitArray 中的所有位设置为指定的值。
    7   public BitArray Xor( BitArray value ); 
    对当前的 BitArray 中的元素和指定的 BitArray 中的相对应的元素执行按位异或操作。
    */
	class MainClass
    {
        public static void Main(string[] args)
        {
			//ArrayList
			ArrayList array = new ArrayList();
            array.Add(34);
            array.Add("str");
            array.Add(12);
			array.Add(22);
			array.Add(44);

			Console.WriteLine("Capacity: {0}",array.Capacity);
            Console.WriteLine("Count: {0}", array.Count);

            foreach (object o in array) {
                Console.WriteLine("object: {0}",o);
            }
            Console.ReadKey();




            //Hashtable
            Hashtable ht = new Hashtable();

            ht.Add("1","haha");
            ht.Add("2","jam");
            ht.Add("4","MJ");
            ht.Add("3","007");

            if (ht.ContainsValue("haha")) {
                Console.WriteLine("ContainsValue haha");
            }else {
                ht.Add("4","haha");
            }

            //获取所有keys
            ICollection keys = ht.Keys;

            foreach (object k in keys) {
                Console.WriteLine("key is {0}", k);
            }

            Console.ReadKey();




			//SortedList
			SortedList sl = new SortedList();

			sl.Add("002", "Abida Rehman");
			sl.Add("004", "Mausam Benazir Nur");
			sl.Add("006", "M. Arif");
			sl.Add("007", "Ritesh Saikia");
			sl.Add("005", "M. Amlan");
			sl.Add("003", " Holzner");
			sl.Add("001", "Zara Ali");

			if (sl.ContainsValue("Nuha Ali"))
			{
				Console.WriteLine("This student name is already in the list");
			}
			else
			{
				sl.Add("008", "Nuha Ali");
			}

			// 获取键的集合 
			ICollection key = sl.Keys;

			foreach (string k in key)
			{
				Console.WriteLine(k + ": " + sl[k]);
			}
            Console.ReadKey();



            //Stack
            Stack st = new Stack();
            st.Push('a');
            st.Push("haha");
            st.Push(123);
			st.Push(123456);

			Console.WriteLine( "Current stack:");

            foreach(object c in st) {
                Console.WriteLine( c + "  ");
            }
            Console.WriteLine( "remove value" );

            st.Pop();
            st.Pop();

            Console.WriteLine( " current stack");
			foreach (object c in st)
			{
				Console.WriteLine(c + "  ");
			}
            Console.ReadKey();






            //Queue
            Queue q = new Queue();

            q.Enqueue("djsfdds");
            q.Enqueue('f');
            q.Enqueue(1234567);
            q.Enqueue(true);

            Console.WriteLine( "current queue");

            foreach(object o in q) {
                Console.WriteLine("queue value {0}",o);
            }

            q.Enqueue('V');
            q.Equals('H');

            string s = (string)q.Dequeue();
            Console.WriteLine("The remove value:{0}", s);
            Console.ReadKey();







			//BitArray
			// 创建两个大小为 8 的点阵列
			BitArray ba1 = new BitArray(8);
            BitArray ba2 = new BitArray(8);

			byte[] a = { 60 };
            byte[] b = { 13 };

            // 把值 60 和 13 存储到点阵列中
            ba1 = new BitArray(a);
            ba2 = new BitArray(b);

			// ba1 的内容
			Console.WriteLine("Bit array ba1: 60");
			for (int i = 0; i < ba1.Count; i++)
			{
				Console.Write("{0, -6} ", ba1[i]);
			}
			Console.WriteLine();


			// ba2 的内容
			Console.WriteLine("Bit array ba2: 13");
			for (int i = 0; i < ba2.Count; i++)
			{
				Console.Write("{0, -6} ", ba2[i]);
			}
			Console.WriteLine();

			BitArray ba3 = new BitArray(8);
			ba3 = ba1.And(ba2);

			// ba3 的内容
			Console.WriteLine("Bit array ba3 after AND operation: 12");
			for (int i = 0; i < ba3.Count; i++)
			{
				Console.Write("{0, -6} ", ba3[i]);
			}
			Console.WriteLine();

			ba3 = ba1.Or(ba2);
			// ba3 的内容
			Console.WriteLine("Bit array ba3 after OR operation: 61");
			for (int i = 0; i < ba3.Count; i++)
			{
				Console.Write("{0, -6} ", ba3[i]);
			}
			Console.WriteLine();

			Console.ReadKey();
		}
    }
}
