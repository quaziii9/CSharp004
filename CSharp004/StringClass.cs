

using System.Diagnostics;
using System.Text;


namespace CSharp004
{
    internal class StringClass
    {
        // [string]
        // string은 문자들의 집합으로 표현됨
        // 내부적으로 문자 배열을 통해서 구현됨
        // [불변성(Immutable)]
        // string은 특징상 다른 기본자료형과 다르게 크기가 정해져 있지 않음
        // char집합이기 때문에 char의 갯수에 따라 크기가 유동적
        // 런타임시 크기가 결정이되고 그 크기는 일정하지 않음
        // string은 다른 기본 자료형과는 다르게 구조체가 아닌 클래스로 구현이 되어 있음
        // 단, 기본 자료형과 같이 값 형식을 구현하기 위해 string 클래스 처리를 값 형식처럼 동작하도록 구현
        // 이를 구현하기 위해 string간의 대입이 있을경우 참조에 의한 주소값 복사가 아닌 깊은복사를 진행
        // 결과적으로 데이터 자체를 복사하는 값형식으로 사용하지만
        // 힙영역을 사용하기 때문에 string이 설정되면 변경할 수 없도록 하는 불변성을 가지게 됨



        // string과 관련된 메서드들
        // indexOf: 현재 문자열 내에서 찾고자 하는 지정된 문자 또는 문자열의 위치를 찾는다
        // LastIndexOf : indexOf랑 동일하지만 뒤부터 찾는다.
        // StartsWith : 현재 문자열이 지정된 문자열로 시작함
        // EndsWith : 현재 문자열이 지정된 문자열로 끝남
        // Contains : 현재 문자열이 지정된 문자열을 포함함 
        // Replace : 현재 문자열에서 지정된 문자열이 다른 지정된 문자열로 모두 바뀐 새로운 문자열을 반환함
        // Equals : 같냐 
        // Trim : 공백제거 (앞뒤만)
        // SubString : 지정된 인덱스 부터 지정된 ? 만큼 문자를 뽑아냄 
        // Split : 분할


        static void Main(string[] args)
        {

            //string str = "abcdef";
            //Console.WriteLine(str);
            //Console.WriteLine(str[1]);  // b
            //Console.WriteLine(str[3]);  // d

            //// string은 불변성 : 크기가 정해져 있지 않은 자료형
            //// string은 런타임 당시에 크기가 정해짐
            //// str[1] = "q"; -> 문자열의 배열 접근은 읽기전용 -> 수정이 불가능

            //string str1 = "abcde"; // 힙 영역에 abcde을 저장하고 이를 str1이 참조
            //str1 = "abc"; // 새로운 힙 영역에 abc문자열에 저장하고 이를 str1이 참조
            //str1 = str1 + "123"; // 새로운 힙 영역에 abc123문자열을 저장하고 이를 str1이 참조

            //string str2 = str1;
            //// 클래스긴 하지만 string은 값형식처럼 사용되어야 하기 때문에 힙영역에 abc123 문자열을 복사하여 str2가 참조되도록함

            //// abc, def , abc123, abc123def : 가비지 컬렉터 대상
            //string str3 = "abc" + 123 + "def" + 456;

            //string str4 = string.Format("abc{0}def{1}", 123, 456);

            /////////////////////////////////////////////////////////////////////////////////////////////////
            
            string str = "kyungil Game Academy";
            Console.WriteLine("Game이 시작되는 위치는 어디인고? : {0}", str.IndexOf("Game"));
            // 대소문자 구분 : game 은 -1뜸 실패하면 -1을 return  

            Console.WriteLine("kyungil로 시작하냐 : {0}", str.StartsWith("kyungil"));
            Console.WriteLine("Academy로 시작하냐 : {0}", str.StartsWith("Academy"));

            Console.WriteLine("kyungil을 test로 체인지 : {0}", str.Replace("kyungil", "test"));  // 단일문자도 가능

            string str1 = "공백으로 문자열을 잘게 잘 게 조져볼 까";
            string[] words = str1.Split(' ');

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }

            string str2 = "Hello, world";
            bool isCheck = str2.Contains("hello");
            // bool isCheck2 = str2.Contains("hello", StringComparison.OrdinalIgnoreCase);
            // StringComparison.OrdinalIgnoreCase : 대소문자 구분없이
            Console.WriteLine(isCheck);

            string str3 = "Hello, World";
            string sub = str3.Substring(7, 5);// 7번째 인덱스부터 5개문자 뽑으세요

            Console.WriteLine(sub);

            // StringBuilder : 자주 변경될 문자열은 StringBuilder 사용 (문자열과 관련된 연산이 많을때)



            Stopwatch strWatch = Stopwatch.StartNew();

            string strRes = "";

            const int Test = 200000;
            for (int i = 0; i < Test; i++)
            {
                strRes += "a";
            }
            strWatch.Stop();
            Console.WriteLine($"스트링{strWatch.ElapsedMilliseconds}마이크로 초");

            Stopwatch strBuilderWatch = Stopwatch.StartNew();
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < Test; i++)
            {
                stringBuilder.Append("a");
            }
            strBuilderWatch.Stop();
            Console.WriteLine($"스트링{strBuilderWatch.ElapsedMilliseconds}마이크로 초");
        }
    }
}
