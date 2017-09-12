using System;

namespace Unsafe
{
    class MainClass
    {
		//type *var-name;
		//int* ip;       /* 指向一个整数 */
		//double* dp;    /* 指向一个双精度数 */
		//float* fp;     /* 指向一个浮点数 */
		//char* ch;       /* 指向一个字符 */

		static unsafe void Main(string[] args)
		{
			int var = 20;
			int* p = &var;
			Console.WriteLine("Data is: {0} ", var);
			Console.WriteLine("Address is: {0}", (int)p);
			Console.ReadKey();
		}
    }
}
