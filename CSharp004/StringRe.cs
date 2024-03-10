using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharp004
{
    internal class StringRe
    {

        public static void Main(string[] args)
        {
            //string str = "Hello World Welcome";
            //Console.WriteLine("World가 시작되는 위치? : {0}", str.IndexOf("World"));
            //Console.WriteLine("World가 시작되는 위치? : {0}", str.LastIndexOf("World"));
            //// 대소문자 구분 world로 하면 return -1

            //Console.WriteLine("Hello 시작 T F : {0}", str.StartsWith("Hello"));
            //Console.WriteLine("World 시작 T F : {0}", str.StartsWith("World"));

            //Console.WriteLine("Welcome 끝 T F : {0}", str.EndsWith("Welcome"));
            //Console.WriteLine("World 끝 T F : {0}", str.EndsWith("World"));

            //bool isCheck = str.Contains("hello");
            //bool isCheck2 = str.Contains("hello", StringComparison.OrdinalIgnoreCase);
            //// StringComparison.OrdinalIgnoreCase : 대소문자 구분없이

            //Console.WriteLine("Hello를 Bye로 체인지 : {0}", str.Replace("Hello", "Bye"));  // 단일문자도 가능

            //string str1 = "공 백으로 문자열 분할하 기";
            //string[] words = str1.Split(' ');

            //foreach (var item in words)
            //{
            //    Console.WriteLine(item);
            //}


            //// ==의 경우 참조를 비교, Equals()의 경우 값을 비교
            //StringBuilder eq1 = new StringBuilder("이퀄");
            //StringBuilder eq2 = new StringBuilder("이퀄");
            //string eq3 = "이퀄";
            //object eq4 = new string("이퀄");

            //if (eq1 == eq2) Console.WriteLine("eq1 eq2 : == true");
            //if (eq1 != eq2) Console.WriteLine("eq1 eq2 : == false");

            //if (eq1.Equals(eq2)) Console.WriteLine("eq1 eq2 : equal true");
            //else Console.WriteLine("eq1 eq2 : equal false");
            //Console.WriteLine("------------------------------");

            //if (eq3 == eq4) Console.WriteLine("eq3 eq4 : == true");
            //if (eq3 != eq4) Console.WriteLine("eq3 eq4 : == false");

            //if (eq3.Equals(eq3)) Console.WriteLine("eq3 eq4 : equal true");
            //else Console.WriteLine("eq3 eq4 : equal false");
            //Console.WriteLine("------------------------------");


            string str2 = " trim ";
            string str21 = str2.Trim();
            Console.WriteLine($".{str21}.");
            string str22 = str2.TrimStart();
            Console.WriteLine($".{str22}.");
            string str23 = str2.TrimEnd();
            Console.WriteLine($".{str23}.");



            string str3 = "Hello, World";
            string sub = str3.Substring(7, 5);// 7번째 인덱스부터 5개문자 뽑으세요

            Console.WriteLine(sub);
        }
    }
}
