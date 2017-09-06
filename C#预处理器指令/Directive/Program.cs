

/*
    预处理器指令  描述
    #define 它用于定义一系列成为符号的字符。
    #undef  它用于取消定义符号。
    #if 它用于测试符号是否为真。
    #else   它用于创建复合条件指令，与 #if 一起使用。
    #elif   它用于创建复合条件指令。
    #endif  指定一个条件指令的结束。
    #line   它可以让您修改编译器的行数以及（可选地）输出错误和警告的文件名。
    #error  它允许从代码的指定位置生成一个错误。
    #warning    它允许从代码的指定位置生成一级警告。
    #region 它可以让您在使用 Visual Studio Code Editor 的大纲特性时，指定一个可展开或折叠的代码块。
    #endregion  它标识着 #region 块的结束。
*/
#if DEBUG
using System;
using System.IO;

public class TestClass
{
    public static void Main()
    {
#if (DEBUG && !VC_V10)
        Console.WriteLine("DEBUG is defined");
#elif (!DEBUG && VC_V10)
         Console.WriteLine("VC_V10 is defined");
#elif (DEBUG && VC_V10)
		Console.WriteLine("DEBUG and VC_V10 are defined");
#else
         Console.WriteLine("DEBUG and VC_V10 are not defined");
#endif
        Console.ReadKey();
    }
}
#endif
