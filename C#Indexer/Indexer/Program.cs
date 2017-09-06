using System;


//索引器（Indexer） 允许一个对象可以像数组一样被索引。当您为类定义一个索引器时，该类的行为就会像一个 虚拟数组（virtual array） 一样。您可以使用数组访问运算符（[ ]）来访问该类的实例。
/*
element-type this[int index] 
{
   // get 访问器
   get 
   {
      // 返回 index 指定的值
   }

   // set 访问器
   set 
   {
      // 设置 index 指定的值 
   }
}
*/
namespace Indexer
{
	class MainClass
    {

        private string[] nameList = new string[size];
        static public int size = 10;
        public MainClass() {
            for (int i = 0; i < size; i ++){
                nameList[i] = string.Format("NA {0}", i);
            }
        }


		public int this[string name]
		{
			get
			{
				int index = 0;
				while (index < size)
				{
					if (nameList[index] == name)
					{
						return index;
					}
					index++;
				}
				return index;
			}

		}

        //public string this[int index] {
        //    get {
        //        string tmp;
        //        if (index >= 0 && index < size) {
        //            tmp = nameList[index];
        //        }else {
        //            tmp = "";
        //        }
        //        return tmp;
        //    }

        //    set {
        //        if(index >= 0 && index < size) {
        //            nameList[index] = value;
        //        }
        //    }
        //}

	


        public static void Main(string[] args)
        {
            MainClass c = new MainClass();
            c.nameList[0] = "q";
			c.nameList[1] = "w";
			c.nameList[2] = "e";
			c.nameList[3] = "r";
			c.nameList[4] = "t";

            int i = 0;
            foreach (string s in c.nameList) {
                Console.WriteLine(c.nameList[i]);
                i++;
            }

            //Console.WriteLine(c.nameList["w"]);
		}
    }
}
