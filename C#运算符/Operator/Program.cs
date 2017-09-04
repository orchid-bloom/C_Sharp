using System;

namespace Operator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			//算术运算符 
            MainClass.arithmeticOperator();

            //关系运算符
            MainClass.relationalOperator();

            //逻辑运算符
            MainClass.logicalOperators();

			//位运算符
			MainClass.bitOperator();

            //赋值运算符
            MainClass.assignmentOperator();

            //其它运算符
            MainClass.othertOperator();

			//运算符优先级
			MainClass.operatorPrecedence();
		}

		//算术运算符 
		public static void arithmeticOperator()
		{
			/*
		+   把两个操作数相加    A + B 将得到 30
		-   从第一个操作数中减去第二个操作数    A - B 将得到 -10
		*   把两个操作数相乘    A * B 将得到 200
		/   分子除以分母  B / A 将得到 2
		%   取模运算符，整除后的余数    B % A 将得到 0
		++  自增运算符，整数值增加 1   A++ 将得到 11
		--  自减运算符，整数值减少 1   A-- 将得到 9
		*/

			int a = 21;
			int b = 10;
			int c;

			c = a + b;
			Console.WriteLine("Line 1 - c 的值是 {0}", c);
			c = a - b;
			Console.WriteLine("Line 2 - c 的值是 {0}", c);
			c = a * b;
			Console.WriteLine("Line 3 - c 的值是 {0}", c);
			c = a / b;
			Console.WriteLine("Line 4 - c 的值是 {0}", c);
			c = a % b;
			Console.WriteLine("Line 5 - c 的值是 {0}", c);

			// ++a 先进行自增运算再赋值
			c = ++a;
			Console.WriteLine("Line 6 - c 的值是 {0}", c);

			// 此时 a 的值为 22
			// --a 先进行自减运算再赋值
			c = --a;
			Console.WriteLine("Line 7 - c 的值是 {0}", c);
			Console.ReadLine();

			a = 1;
			b = 0;

			// a++ 先赋值再进行自增运算
			b = a++;
			Console.WriteLine("a = {0}", a);
			Console.WriteLine("b = {0}", b);
			Console.ReadLine();

			// ++a 先进行自增运算再赋值
			a = 1; // 重新初始化 a
			b = ++a;
			Console.WriteLine("a = {0}", a);
			Console.WriteLine("b = {0}", b);
			Console.ReadLine();

			// a-- 先赋值再进行自减运算
			a = 1;  // 重新初始化 a
			b = a--;
			Console.WriteLine("a = {0}", a);
			Console.WriteLine("b = {0}", b);
			Console.ReadLine();

			// --a 先进行自减运算再赋值
			a = 1;  // 重新初始化 a
			b = --a;
			Console.WriteLine("a = {0}", a);
			Console.WriteLine("b = {0}", b);
			Console.ReadLine();
		}

		//关系运算符
		public static void relationalOperator() {
			/*
                == 检查两个操作数的值是否相等，如果相等则条件为真。    (A == B) 不为真。
                !=  检查两个操作数的值是否相等，如果不相等则条件为真。   (A != B) 为真。
                >   检查左操作数的值是否大于右操作数的值，如果是则条件为真。    (A > B) 不为真。
                <   检查左操作数的值是否小于右操作数的值，如果是则条件为真。    (A < B) 为真。
                >=  检查左操作数的值是否大于或等于右操作数的值，如果是则条件为真。 (A >= B) 不为真。
                <=  检查左操作数的值是否小于或等于右操作数的值，如果是则条件为真。
            */

			int a = 21;
			int b = 10;

			if (a == b)
			{
				Console.WriteLine("Line 1 - a 等于 b");
			}
			else
			{
				Console.WriteLine("Line 1 - a 不等于 b");
			}
			if (a < b)
			{
				Console.WriteLine("Line 2 - a 小于 b");
			}
			else
			{
				Console.WriteLine("Line 2 - a 不小于 b");
			}
			if (a > b)
			{
				Console.WriteLine("Line 3 - a 大于 b");
			}
			else
			{
				Console.WriteLine("Line 3 - a 不大于 b");
			}
			/* 改变 a 和 b 的值 */
			a = 5;
			b = 20;
			if (a <= b)
			{
				Console.WriteLine("Line 4 - a 小于或等于 b");
			}
			if (b >= a)
			{
				Console.WriteLine("Line 5 - b 大于或等于 a");
			}
		}

        //逻辑运算符
        public static void logicalOperators() {

			bool a = true;
			bool b = true;

			if (a && b)
			{
				Console.WriteLine("Line 1 - 条件为真");
			}
			if (a || b)
			{
				Console.WriteLine("Line 2 - 条件为真");
			}
			/* 改变 a 和 b 的值 */
			a = false;
			b = true;
			if (a && b)
			{
				Console.WriteLine("Line 3 - 条件为真");
			}
			else
			{
				Console.WriteLine("Line 3 - 条件不为真");
			}
			if (!(a && b))
			{
				Console.WriteLine("Line 4 - 条件为真");
			}
			Console.ReadLine();

        }

        public static void bitOperator() {
			/*
			 *  p   q   p & q   p | q   p ^ q
                0   0   0       0         0
                0   1   0       1         1
                1   1   1       1         0
                1   0   0       1         1
            */

			/*
            假设如果 A = 60，且 B = 13，现在以二进制格式表示，它们如下所示：
            A = 0011 1100
            B = 0000 1101
            -----------------
            A&B = 0000 1100
            A|B = 0011 1101
            A^B = 0011 0001
            ~A  = 1100 0011
            */


			/*
            &   如果同时存在于两个操作数中，二进制 AND 运算符复制一位到结果中。  (A & B) 将得到 12，即为 0000 1100
            |   如果存在于任一操作数中，二进制 OR 运算符复制一位到结果中。 (A | B) 将得到 61，即为 0011 1101
            ^   如果存在于其中一个操作数中但不同时存在于两个操作数中，二进制异或运算符复制一位到结果中。    (A ^ B) 将得到 49，即为 0011 0001
            ~   按位取反运算符是一元运算符，具有"翻转"位效果，即0变成1，1变成0，包括符号位。   (~A ) 将得到 -61，即为 1100 0011，一个有符号二进制数的补码形式。
            <<  二进制左移运算符。左操作数的值向左移动右操作数指定的位数。   A << 2 将得到 240，即为 1111 0000
            >>  二进制右移运算符。左操作数的值向右移动右操作数指定的位数。   A >> 2 将得到 15，即为 0000 1111
            */

			int a = 60;            /* 60 = 0011 1100 */
			int b = 13;            /* 13 = 0000 1101 */
			int c = 0;

			c = a & b;           /* 12 = 0000 1100 */
			Console.WriteLine("Line 1 - c 的值是 {0}", c);

			c = a | b;           /* 61 = 0011 1101 */
			Console.WriteLine("Line 2 - c 的值是 {0}", c);

			c = a ^ b;           /* 49 = 0011 0001 */
			Console.WriteLine("Line 3 - c 的值是 {0}", c);

			c = ~a;               /*-61 = 1100 0011 */
			Console.WriteLine("Line 4 - c 的值是 {0}", c);

			c = a << 2;     /* 240 = 1111 0000 */
			Console.WriteLine("Line 5 - c 的值是 {0}", c);

			c = a >> 2;     /* 15 = 0000 1111 */
			Console.WriteLine("Line 6 - c 的值是 {0}", c);
			Console.ReadLine();
		}


		//赋值运算符
		public static void assignmentOperator() {

        	/*
        	运算符 描述  实例
        	=   简单的赋值运算符，把右边操作数的值赋给左边操作数    C = A + B 将把 A + B 的值赋给 C
        	+=  加且赋值运算符，把右边操作数加上左边操作数的结果赋值给左边操作数    C += A 相当于 C = C + A
        	-=  减且赋值运算符，把左边操作数减去右边操作数的结果赋值给左边操作数    C -= A 相当于 C = C - A
        	*=  乘且赋值运算符，把右边操作数乘以左边操作数的结果赋值给左边操作数    C *= A 相当于 C = C * A
        	/=  除且赋值运算符，把左边操作数除以右边操作数的结果赋值给左边操作数    C /= A 相当于 C = C / A
        	%=  求模且赋值运算符，求两个操作数的模赋值给左边操作数   C %= A 相当于 C = C % A
        	<<= 左移且赋值运算符    C <<= 2 等同于 C = C << 2
        	>>= 右移且赋值运算符    C >>= 2 等同于 C = C >> 2
        	&=  按位与且赋值运算符   C &= 2 等同于 C = C & 2
        	^=  按位异或且赋值运算符  C ^= 2 等同于 C = C ^ 2
        	|=  按位或且赋值运算符   C |= 2 等同于 C = C | 2
        	*/
			int a = 21;
			int c;

			c = a;
			Console.WriteLine("Line 1 - =  c 的值 = {0}", c);

			c += a;
			Console.WriteLine("Line 2 - += c 的值 = {0}", c);

			c -= a;
			Console.WriteLine("Line 3 - -=  c 的值 = {0}", c);

			c *= a;
			Console.WriteLine("Line 4 - *=  c 的值 = {0}", c);

			c /= a;
			Console.WriteLine("Line 5 - /=  c 的值 = {0}", c);

			c = 200;
			c %= a;
			Console.WriteLine("Line 6 - %=  c 的值 = {0}", c);

			c <<= 2;
			Console.WriteLine("Line 7 - <<=  c 的值 = {0}", c);

			c >>= 2;
			Console.WriteLine("Line 8 - >>=  c 的值 = {0}", c);

			c &= 2;
			Console.WriteLine("Line 9 - &=  c 的值 = {0}", c);

			c ^= 2;
			Console.WriteLine("Line 10 - ^=  c 的值 = {0}", c);

			c |= 2;
			Console.WriteLine("Line 11 - |=  c 的值 = {0}", c);
			Console.ReadLine();
        }

        //其它运算符
        public static void othertOperator() {
			/*
					 运算符    描述  实例
			sizeof()    返回数据类型的大小。  sizeof(int)，将返回 4.
			typeof()    返回 class 的类型。   typeof(StreamReader);
			&   返回变量的地址。    &a; 将得到变量的实际地址。
			*   变量的指针。  *a; 将指向一个变量。
			? : 条件表达式   如果条件为真 ? 则为 X : 否则为 Y
			is  判断对象是否为某一类型。    If( Ford is Car) // 检查 Ford 是否是 Car 类的一个对象。
			as  强制转换，即使转换失败也不会抛出异常。 Object obj = new StringReader("Hello");
			StringReader r = obj as StringReader;
			*/

			/* sizeof 运算符的实例 */
			Console.WriteLine("int 的大小是 {0}", sizeof(int));
			Console.WriteLine("short 的大小是 {0}", sizeof(short));
			Console.WriteLine("double 的大小是 {0}", sizeof(double));

			/* 三元运算符符的实例 */
			int a, b;
			a = 10;
			b = (a == 1) ? 20 : 30;
			Console.WriteLine("b 的值是 {0}", b);

			b = (a == 10) ? 20 : 30;
			Console.WriteLine("b 的值是 {0}", b);
			Console.ReadLine();
		}


		//C# 中的运算符优先级
        public static void operatorPrecedence () {
			/*
			类别   运算符     结合性 
            后缀  () [] -> . ++ - -   从左到右 
            一元  + - ! ~ ++ - - (type)* & sizeof     从右到左 
            乘除  * / %   从左到右 
            加减  + -     从左到右 
            移位  << >>   从左到右 
            关系  < <= > >=   从左到右 
            相等  == !=   从左到右 
            位与 AND  &   从左到右 
            位异或 XOR     ^   从左到右 
            位或 OR   |   从左到右 
            逻辑与 AND     &&  从左到右 
            逻辑或 OR  ||  从左到右 
            条件  ?:  从右到左 
            赋值  = += -= *= /= %=>>= <<= &= ^= |=    从右到左 
            逗号  ,   从左到右 
            */

			int a = 20;
			int b = 10;
			int c = 15;
			int d = 5;
			int e;
			e = (a + b) * c / d;     // ( 30 * 15 ) / 5
			Console.WriteLine("(a + b) * c / d 的值是 {0}", e);

			e = ((a + b) * c) / d;   // (30 * 15 ) / 5
			Console.WriteLine("((a + b) * c) / d 的值是 {0}", e);

			e = (a + b) * (c / d);   // (30) * (15/5)
			Console.WriteLine("(a + b) * (c / d) 的值是 {0}", e);

			e = a + (b * c) / d;    //  20 + (150/5)
			Console.WriteLine("a + (b * c) / d 的值是 {0}", e);
			Console.ReadLine();
		}
	}
}
