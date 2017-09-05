using System;

namespace Cycle
{
    class MainClass
    {
        public static void Main(string[] args)
        {

			//if
			/* 局部变量定义 */
			int a = 100;

			/* 检查布尔条件 */
			if (a < 20)
			{
				/* 如果条件为真，则输出下面的语句 */
				Console.WriteLine("a 小于 20");
			}
			else
			{
				/* 如果条件为假，则输出下面的语句 */
				Console.WriteLine("a 大于 20");
			}
			Console.WriteLine("a 的值是 {0}", a);
			Console.ReadLine();

			//switch 
			/*
            switch 语句中的 expression 必须是一个整型或枚举类型，或者是一个 class 类型，其中 class 有一个单一的转换函数将其转换为整型或枚举类型。
            在一个 switch 中可以有任意数量的 case 语句。每个 case 后跟一个要比较的值和一个冒号。
            case 的 constant-expression 必须与 switch 中的变量具有相同的数据类型，且必须是一个常量。
            当被测试的变量等于 case 中的常量时，case 后跟的语句将被执行，直到遇到 break 语句为止。
            当遇到 break 语句时，switch 终止，控制流将跳转到 switch 语句后的下一行。
            不是每一个 case 都需要包含 break。如果 case 语句为空，则可以不包含 break，控制流将会 继续 后续的 case，直到遇到 break 为止。
            C# 不允许从一个开关部分继续执行到下一个开关部分。如果 case 语句中有处理语句，则必须包含 break 或其他跳转语句。
            一个 switch 语句可以有一个可选的 default case，出现在 switch 的结尾。default case 可用于在上面所有 case 都不为真时执行一个任务。default case 中的 break 语句不是必需的。
            C# 不支持从一个 case 标签显式贯穿到另一个 case 标签。如果要使 C# 支持从一个 case 标签显式贯穿到另一个 case 标签，可以使用 goto 一个 switch-case 或 goto default。
            */
			/* 局部变量定义 */
			char grade = 'B';

			switch (grade)
			{
				case 'A':
					Console.WriteLine("很棒！");
					break;
				case 'B':
				case 'C':
					Console.WriteLine("做得好");
					break;
				case 'D':
					Console.WriteLine("您通过了");
					break;
				case 'F':
					Console.WriteLine("最好再试一下");
					break;
				default:
					Console.WriteLine("无效的成绩");
					break;
			}
			Console.WriteLine("您的成绩是 {0}", grade);
			Console.ReadLine();




			//while 循环的语法
			int i = 0;
			while (i < 5)
			{
                Console.WriteLine(i);
                i++;
			}
            Console.ReadKey();


            // for 循环的语法
            for (int j = 0; j < 20; j += 1) {
                Console.WriteLine("for:"+j.ToString());
            }
            Console.ReadKey();



			//foreach 可以迭代数组或者一个集合对象
			int[] forArray = new int[5] {0,1,2,3,4};

            foreach (int e in forArray) {

                Console.WriteLine("forearch:" + e);
            }
            Console.ReadKey();


            //do...while 循环的语法
            int l = 0;
            do
            {
                Console.WriteLine("do ... while :" + l.ToString());
                l++;
            } while (l < 5);

			//break
			//当 break 语句出现在一个循环内时，循环会立即终止，且程序流将继续执行紧接着循环的下一条语句
			//它可用于终止 switch 语句中的一个 case

			//中的 continue 语句有点像 break 语句。但它不是强迫终止，continue 会跳过当前循环中的代码，强迫开始下一次循环。
			//对于 for 循环，continue 语句会导致执行条件测试和循环增量部分。对于 while 和 do...while 循环，continue 语句会导致程序控制回到条件测试上
		}
    }
}
