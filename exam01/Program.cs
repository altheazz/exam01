using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("歡迎來到 1A2B 猜數字的遊戲～");

            
            Random rand = new Random(Guid.NewGuid().GetHashCode());

            List<int> listLinq = new List<int>(Enumerable.Range(0, 9));//先設定0至9的數值範圍
            listLinq = listLinq.OrderBy(num => rand.Next()).ToList<int>();

            string[] arr = new string[4];//定義亂數容器
            string[] arr2 = new string[4];//定義玩家猜數容器

            for (int i = 0; i < 4; i++)//隨機亂數產生4個不重複數值
            {

                arr[i] = Convert.ToString(listLinq[i]);
                    // == (listLinq[i].ToString());
            }

            bool Iswin = false;
            int a = 0;

            do
            {
                if(a == 4)
                {
                    Console.WriteLine("請輸入4個數字：");
                    
                    int b = 0;
                   
                    string guessnum = Console.ReadLine();
                    for (int i = 0; i < 4; i++)//判斷A
                    {
                        arr2[i] = Convert.ToString(guessnum[i]);
                    }

                    for (int j = 0; j < 4;j++)
                    {
                        for (int k = 0; k < 4;k++)
                        {
                            if (arr2[k] == arr[k])
                            {
                                if(j == k)
                                a+= 1;
                            }
                            else 
                            { 
                                b+= 1;
                            }
                            
                        }
                        
                    }
                        
                    
                        
                    Console.WriteLine($"判定結果是：{a}A{b}B");
                    if(a == 4)
                    {
                        Console.WriteLine("恭喜你！猜對了！！");
                        break;
                    }
                }
                else
                { 
                    Console.WriteLine("輸入格式錯誤！"); 
                }

            }while(true);//結束
            Console.WriteLine("你要繼續玩嗎？");
            string y = Console.ReadLine();
            if(y!="y")
            {
                Console.WriteLine("遊戲結束，下次再來玩喔～");
                
            } 
            
            
            /*
            string[] datas = { "About", "Name", "One", "All" };
            int aryLength = datas.Length;

            int num = 0;
            while (num < aryLength)
            {
                Console.WriteLine(datas[num]);
                num++;
                //可以試試看，將num++改成num+=2
            }
            */

        }
    }
}
