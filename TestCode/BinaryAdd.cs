using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    class BinaryADD
    {
        public static void Main(string[] args)
        {
            
            System.Console.WriteLine(AddBinary("100", "111010"));
        }

        public static string AddBinary(String a, String b)
        {
            int flag = 0;
            string c = "";

            string str = a.Length > b.Length ? a : b;
            int index = (a.Length < b.Length ? a.Length : b.Length);


            for (int i = index-1; i>=0 ;i--)
            {
                if (a[i].Equals('1') && b[i].Equals('1')){
                    if(flag == 1)
                    {
                        c = "1" + c;
                        flag = 1;
                    }
                    else
                    {
                        c = "0" + c;
                        flag = 1;
                    }
                    
                }else if (a[i].Equals('1') || b[i].Equals('1'))
                {
                    if (flag == 1) {
                        c = "0" + c;
                        flag = 1;
                    }
                    else
                    {
                        c = "1" + c;
                        flag = 0;
                    }

                }else {
                    if (flag == 1)
                    {
                        c = "1" + c;
                    }else{
                        c="0" + c;
                    }
                    flag = 0;
                }
            }

            if(flag == 0 && a.Length != b.Length) {
                c = str.Substring(0, str.Length-index)+c;
            }
            else if(a.Length!=b.Length)
            {
                    for (int i = str.Length - index-1; i >= 0; i--)
                    {
                        if (str[i].Equals('1') && flag == 1)
                        {
                            flag = 1;
                            c = "0" + c;
                        }
                        else if(i>1)
                        {
                            flag = 0;
                            c = str.Substring(0, i) + "1" + c;
                        }
                    }         
            }

            if (flag == 1)
            {
                c = "1" + c;
            }

            return c;
        }
    }
}
