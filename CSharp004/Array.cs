
using System;

namespace CSharp004
{
    internal class CArray
    {
        // <배열>
        // Array 클래스를 통해 구현되어 있음
        // 그렇다는건 Array클래스의 모든 메서드들을 사용가능하다는 것
        // sort : 정렬 
        // Reverse : 반전 
        // IndexOf : 탐색
        // Copy : 복사 
        // Clear : 지정된값으로 초기화 
        // Resize : 크기를 조정

        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////////////////////////////
            // int[] scores = new int[5];
            //scores.GetLength(0); 
            int[] array = { 1, 3, 6, 6, 8 };
            int length = array.Length; // 배열의 크기
            Console.WriteLine(length); // 5
            int max = array.Max();
            Console.WriteLine(max); // 8


            Array.Sort(array);
            Array.Reverse(array);
            Array.Resize(ref array, 7);
            int idx = Array.IndexOf(array, 3);
            Console.WriteLine(array.Length);

            int[] cArray1 = { 1, 2 };
            int[] cArray2 = new int[cArray1.Length];
            Array.Copy(cArray1, cArray2, cArray1.Length);

            foreach (int item in cArray2)
            {
                Console.WriteLine(item);
            }


            int[] shallow = array;  // 배열의 얕은 복사 : 동일한 인스턴스  참조
            int[] deep = new int[array.Length]; // 깊은 복사 : 새로운 인스턴스를 생성하고 복사

            //array[0] = 0;
            int[,] matrix = new int[3, 4];

            // [0,0] [0,1] , [0,2], [0,3]
            // [1,0] [1,1] , [1,2], [1,3] 
            // [2,0] [2,1] , [2,2], [2,3] 

            Console.WriteLine(matrix.GetLength(0)); // 3
            Console.WriteLine(matrix.GetLength(1)); // 4

            int[,] tile = { {1,2,3, }, { 4, 5, 6, }, };

            for (int i = 0; i < tile.GetLength(0); i++) 
            {
                for (int k = 0; k < tile.GetLength(1); k++)
                {
                    Console.Write(tile[i,k]);
                }
                Console.WriteLine();
            }

            // 문자열 뒤집기
            // abcd -> dcba

            //string str = "abcd";
            //string reverseString = new string(str.Reverse().ToArray());

            //Console.WriteLine(reverseString);

            //string str = "abcd";
            //char[] a = str.ToCharArray();

            //for (int i = 3; i >= 0; i--)
            //{
            //    Console.Write(a[i]);
            //}

            //Console.WriteLine();

            //Swap(ref a[0], ref a[3]);
            //Swap(ref a[1], ref a[2]);

            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.Write(a[i]);
            //}

            //static void Swap(ref char left,ref  char right)
            //{
            //    char temp = left;
            //    left = right;
            //    right = temp;
        }

       
    }
}

