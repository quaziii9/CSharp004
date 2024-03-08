namespace CSharp004
{
    internal class Program
    {
        // 디폴트 매개변수 
        //static void Addstudent(string name, string home, int age = 10)
        //{
        //    // 초기값이 있는 매개변수는 맨끝부터 할당 (디폴트 매개변수는 맨뒤부터) 
        //}

        // params
        // 매개변수의 갯수를 유동적으로 사용할수 있다
        // 동적으로 크기가 변하는 매개변수를 전달할 때
        // 배열 형태로 전달할때

        static int Sum(params int[] values)
        {
            int sum = 0;
            for (int i = 0; i < values.Length; i++) 
            {
                sum += values[i];
            }

            return sum;
        }

        // [in] 
        // 매개 변수를 입력 전용으로 설정
        // in으로 설정된 매개변수는 해당 값을 읽을수만 있고 수정이 불가능하다.
        static int Plus(in int left, in int right)
        {
            // left = 10; in으로 설정되어 있기 때문에 수정이 불가능
            return left + right;
        }

        
        ///////////////////////////////////////////////////////////////////////////////
    
        static void Divide(int left, int right, out int quoient, out int remainder)
        {
            quoient = left / right;
            remainder = left % right;
        }
        static int Num(int a , int b) 
        { 
            return a + b;
        }

        static void Num1(int a, int b, out int sum)
        {
            sum = a + b;
        }

        ///////////////////////////////////////////////////////////////////////////////
        ///[ref]
        // 매개변수를 참조의 형태로,
        // 매개변수가 ValueType인 경우에도 함수를 통해서 원본값을 변경하고 싶을떄

        static void Swap(ref int left, ref int right)
        {
            int temp = left;
            left = right;
            right = temp;
        }



        ///////////////////////////////////////////////////////////////////////////////
        // 함수의 매개변수의 파라미터가 초기값을 갖고 있으면 호출할때 생략하는것을 허용한다.
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////////////////////
            int a = Sum(1, 3, 4, 5, 6, 7 );
            int b = Sum(1, 3);
            Console.WriteLine(a);
            Console.WriteLine(b);
            ///////////////////////////////////////////////////////////////////////////////
            ///
            int c;
            Divide(5, 3, out c, out int d);
            Console.WriteLine($"{c} , {d},");

            ///////////////////////////////////////////////////////////////////////////////
            int left = 1;
            int right = 2;
            Swap(ref left, ref right);
            Console.WriteLine($"{left} , {right},");
        }
    }
}
