using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam01
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            for(int x = 1; x !=0; x++)
            { 
                string[] ranarr = new string[4];
                string[] userarr = new string[4];
                Random rnd = new Random();//產生亂數初始值
                
                for (int i = 0; i < 4; i++)
                {
                    ranarr[i] = Convert.ToString(rnd.Next(1, 10));//亂數產生1~9

                    if (ranarr[0] == "0")
                    {
                        ranarr[0] = Convert.ToString(rnd.Next(1, 10));
                    }

                    for (int j = 0; j < i; j++)
                    {
                        while (ranarr[j] == ranarr[i])//檢查是否與前面產生數重複
                        {
                            j = 0;//如有重複，j回歸於0再次檢查
                            ranarr[i] = Convert.ToString(rnd.Next(1, 10));//重新產生，存回陣列
                        }
                    }
                    Console.WriteLine(ranarr[i]);
                }

                Console.WriteLine("歡迎來到 1A2B 猜數字的遊戲～");

                for (int k = 1; k < 4; k++)
                {
                    int a = 0;
                    int b = 0;
                    Console.WriteLine("請輸入4個數字：");
                    string user = Console.ReadLine();

                    for (int i = 0; i < 4; i++)
                    {
                        userarr[i] = Convert.ToString(user[i]);
                    }

                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            if (userarr[j] == ranarr[i])
                            {
                                if (i == j)
                                {
                                    a++;
                                }
                                else
                                {
                                    b++;
                                }
                            }
                        }
                    }
                    Console.WriteLine($"判定結果是：{a}A{b}B");

                    if (a == 4)
                    {
                        Console.WriteLine("恭喜你！猜對了！！");
                        break;
                    }

                }
                Console.WriteLine("你要繼續玩嗎？(y)");
                string y = Console.ReadLine();
                if (y != "y")
                {
                    break;
                }
            }


            /*第二版(錯)
            int[] ranarr = new int[4];
            Random rnd = new Random();//產生亂數初始值
            for (int i = 0; i < 4; i++)
            {
                ranarr[i] = rnd.Next(1, 10);//亂數產生1~9
                for(int j = 0; j < i; j++)
                {
                    while (ranarr[j] == ranarr[i])//檢查是否與前面產生數重複
                    {
                        j = 0;//如有重複，j回歸於0再次檢查
                        ranarr[i] = rnd.Next(1, 10);//重新產生，存回陣列
                    }
                }Console.WriteLine(ranarr[i]);
            }
            
            Console.WriteLine("歡迎來到 1A2B 猜數字的遊戲～");

            int a = 0;
            int b = 0;

            for(int k = 0; k < 4; k++)
            {
                Console.WriteLine("請輸入4個數字：");
                int guessnum = Convert.ToInt32(Console.ReadLine());
                int[] num = new int[4];

                num[0] = guessnum / 1000;
                num[1] = (guessnum % 1000) / 100;
                num[2] = (guessnum % 100) / 10;
                num[3] = guessnum % 10;

               

                for (int x = 0; x < 4; x++)
                {

                    if (num[x] == ranarr[x])
                    {
                        a++;
                    }
                    else
                    {
                        for (int y = 0; y < 4; y++)
                        {    
                            if((x != y ) && (num[x] == ranarr[y]))
                            { 
                                b++; 
                            }
                         
                        }
                    }
                    

                }
                Console.WriteLine($"判定結果是：{a}A{b}B");

                if(a == 4)
                {
                    Console.WriteLine("恭喜你！猜對了！！");
                    Console.WriteLine("遊戲結束，下次再來玩喔～");
                }



            }





            */

            /*第一版(錯)
             
            Random rand = new Random(Guid.NewGuid().GetHashCode());

             List<int> listLinq = new List<int>(Enumerable.Range(0, 10));//先設定0至9的數值範圍
             listLinq = listLinq.OrderBy(num => rand.Next()).ToList<int>();

             string[] arr = new string[4];//定義亂數容器
             string[] arr2 = new string[4];//定義玩家猜數容器

             for (int i = 0; i < 4; i++)//隨機亂數產生4個不重複數值
             {

                 arr[i] = Convert.ToString(listLinq[i]);// == (listLinq[i].ToString());
                 Console.WriteLine(arr[i]);

             }
            
            bool Iswin = false;
            int a = 0;

            do
            {
                if(a == 4)
                {
                    Console.WriteLine("請輸入4個數字：");
                    
                    int b = 0;
                   
                    
                    for (int s = 0; s < 4; s++)//判斷A
                    {
                        arr2[s] = Convert.ToString(guessnum[s]);
                    }

                    for (int j = 0; j < 4;j++)
                    {
                        for (int k = 0; k < 4;k++)
                        {
                            if (arr2[k] == arr[k])
                            {
                                if(j == k)
                                {
                                    a++;
                                }    
                                else 
                                { 
                                    b++;
                                }
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
                    break;
                }

            }while(true);//結束
            Console.WriteLine("你要繼續玩嗎？");
            string y = Console.ReadLine();
            if(y!="y")
            {
                Console.WriteLine("遊戲結束，下次再來玩喔～");
                
            } 
            */


        }
    }
}
