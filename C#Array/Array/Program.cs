using System;
namespace Array
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Array
            //datatype[] arrayName
            double[] balance;

            // array init
            balance = new double[10];
            balance[0] = 0.01;

            /* 初始化数组 n 中的元素 */
            int[] n = new int[10];
            for (int i = 0; i < 10; i++)
            {
                n[i] = i + 200;
            }


            /* 输出每个数组元素的值 */
            foreach (int ele in n)
            {
                Console.WriteLine("ele [{0}]: {1}", ele - 200, ele);
            }



            //多维数组
            // string 变量的二维数组
            string[,] names;
            // int 变量的三维数组
            int[,,] m;
            int[,] a = new int[3, 4] {
             {0, 1, 2, 3} ,   /*  初始化索引号为 0 的行 */
             {4, 5, 6, 7} ,   /*  初始化索引号为 1 的行 */
             {8, 9, 10, 11}   /*  初始化索引号为 2 的行 */
            };



			//参数数组
			//public 返回类型 方法名称( params 类型名称[] 数组名称 )
			//提供了 params 关键字，使调用数组为形参的方法时，既可以传递数组实参，也可以只传递一组数组。
			//传递数组给函数
			MyArray mar = new MyArray();
            int[] balance1 = new int[] { 100, 200, 34, 56, 12 };
			//double avg = mar.getAverage(balance1,5);
			//double avg = mar.getAverage(5,balance1);
            double avg = mar.getAverage(5, 512, 720, 250, 567, 889);

			Console.WriteLine("avg:{0}", avg);

			//Array 类

			/*Array 类的属性
                1   IsFixedSize
                获取一个值，该值指示数组是否带有固定大小。
                2   IsReadOnly
                获取一个值，该值指示数组是否只读。
                3   Length
                获取一个 32 位整数，该值表示所有维度的数组中的元素总数。
                4   LongLength
                获取一个 64 位整数，该值表示所有维度的数组中的元素总数。
                5   Rank
                获取数组的秩（维度）。
            */

			/*Array 类的方法
                1   Clear
                根据元素的类型，设置数组中某个范围的元素为零、为 false 或者为 null。
                2   Copy(Array, Array, Int32)
                从数组的第一个元素开始复制某个范围的元素到另一个数组的第一个元素位置。长度由一个 32 位整数指定。
                3   CopyTo(Array, Int32)
                从当前的一维数组中复制所有的元素到一个指定的一维数组的指定索引位置。索引由一个 32 位整数指定。
                4   GetLength 
                获取一个 32 位整数，该值表示指定维度的数组中的元素总数。
                5   GetLongLength
                获取一个 64 位整数，该值表示指定维度的数组中的元素总数。
                6   GetLowerBound
                获取数组中指定维度的下界。
                7   GetType
                获取当前实例的类型。从对象（Object）继承。
                8   GetUpperBound
                获取数组中指定维度的上界。
                9   GetValue(Int32)
                获取一维数组中指定位置的值。索引由一个 32 位整数指定。
                10  IndexOf(Array, Object)
                搜索指定的对象，返回整个一维数组中第一次出现的索引。
                11  Reverse(Array)
                逆转整个一维数组中元素的顺序。
                12  SetValue(Object, Int32)
                给一维数组中指定位置的元素设置值。索引由一个 32 位整数指定。
                13  Sort(Array)
                使用数组的每个元素的 IComparable 实现来排序整个一维数组中的元素。
                14  ToString
                返回一个表示当前对象的字符串。从对象（Object）继承。
            */
		}
    }


    class MyArray
    {

#if false

        internal  double getAverage(int[] arr, int size) {
            int i;
            double avg;
            int sum = 0;

            for (i = 0; i < size; i ++) {
                sum += arr[i];
            }

            avg = (double)sum / size;

            return avg;
        }
#else
        internal double getAverage(int size ,params int[] arr)
        {
            int i;
            double avg;
            int sum = 0;

            for (i = 0; i < size; i++)
            {
                sum += arr[i];
            }

            avg = (double)sum / size;

            return avg;
        }
#endif
    }
}
