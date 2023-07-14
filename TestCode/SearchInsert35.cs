using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TestCode
{
    public delegate void Prit(object? ob);

    class SearchInsert35
    {

        public event Prit? PritEvent;

        public string this[int index]
        {
            get {
                return "OK";
            }
            set { }
        }

        public string myValue
        {
            get { return "OK"; }
            set { }
        }

        /**static void Main()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if(drive.IsReady)
                {
                    Console.WriteLine($"DriveName：{drive.Name}");
                    Console.WriteLine($"DriveFormat：{drive.DriveFormat}");
                    Console.WriteLine($"DriveType：{drive.DriveType}");
                    Console.WriteLine($"RootDirectory：{drive.RootDirectory}");
                    Console.WriteLine($"VolumeLabel：{drive.VolumeLabel}");
                    Console.WriteLine();
                }
            }
        }**/

        void console0(object? ob)
        {
            int i = 0;
            Console.WriteLine($"测试");

            Console.WriteLine($"{ob}{i}");
        }
        void console1(object? ob)
        {
            int i = 1;
            Console.WriteLine($"测试");

            Console.WriteLine($"{ob}{i}");
        }
        void console2(object? ob)
        {
            int i = 2;
            Console.WriteLine($"测试");

            Console.WriteLine($"{ob}{i}");
        }

        public string addBinary(String a, String b)
        {
            while (a.Length!=b.Length)
            {
                if (a.Length < b.Length)
                {
                    a += '0';
                }else if(b.Length < a.Length) 
                { 
                    b += "0";
                };
            }


            
            for(int i = a.Length-1; i >= 0; i++)
            {
                     
            }
            return "ok";
        }
        public static int SearchInsert(int[] nums, int target)
        {
            int befor = 0;
            int last  =nums.Length - 1;
            int mid;
            do {
                mid = (befor + last) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }else if (last < befor)
                {
                    if (nums[mid] > target)
                    {
                        mid += 1;
                    }
                    break;
                }
                else if (nums[mid] < target)
                {
                    befor = mid + 1;
                }
                else if (nums[mid] > target)
                {
                    last = mid - 1;
                }
            } while (nums[mid] != target);


            return mid;
        }

        public static int[] PlusOne(int[] digits)
        {
            int index = digits.Length-1;

            if (digits[digits.Length-1] < 9)
            {
                digits[digits.Length - 1] += 1;
            }
            else
            {
                while (index >= 0 &&digits[index] == 9)
                {
                    digits[index] = 0;
                    index--;
                }

                if (index == -1)
                {
                    int[] arr = new int[digits.Length+1];
                    arr[0] = 1;
                    return arr;
                }
                else
                {
                    digits[index] += 1;
                }
            }

            return digits;
            
        }


        public static int LengthOfLastWord(string s)
        {
            int max = 0;
            int le = 0;
            for (int m = 0; m < s.Length; m++)
            {
                if (s[m] != ' ')
                {
                    le += 1;
                    if (m == s.Length)
                    {
                        max = le;
                    }
                }
                else if (s[m] == ' ')
                {
                    if (le != 0)
                    {
                        max = le;
                    }
                    le = 0;
                }
            }

            return max;

            if (s == ""){
                return 0;
            }
            else
            {
                Regex rgx = new Regex(@"\s+");
                string result = rgx.Replace(s, " ");
                int i = result.LastIndexOf(" ");
                int j = result.LastIndexOf(" ", i - 1);
                return i - j - 1;
            }  
        }
    }
}

