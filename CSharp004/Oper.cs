
namespace CSharp004
{
    internal class Oper
    {
        // 연산자 오버로딩
        // 사용자 정의 자료형이나 클래스 같은 경우 
        // 해당 타입에 맞게 재정의 함
        // 기본 연산자의 연산을 재정의하여 구현

        public struct Ex
        {
            public int value;
            public Ex(int value)
            {
                this.value = value;
            }
            public static Ex operator +(Ex left, int right)
            {
                return new Ex(left.value +right + right);
            }
        }

        public struct Point
        { 
            public int x; 
            public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            // 연산자 재정의를 해서 기본적인 연산자를 사용합시다

            public static Point operator + (Point left, Point right) 
            { 
                return new Point(left.x + right.x, left.y + right.y);
            }
            public static Point operator -(Point left, Point right)
            {
                return new Point(left.x * right.x, left.y * right.y);
            }

            public override string ToString()
            {
                return $"({x}, {y})";
            }
        }


        static void Main(string[] args)
        {
            Point point = new Point(3,3) + new Point(2,5);

           // Console.WriteLine(point.ToString());

            Point point1 = new Point(2, 3);
            Point point2 = new Point(1, 5);
           // Console.WriteLine(point1-point2);

            Ex num = new Ex(5) + 3;
            
            Console.WriteLine(num.value);
        }
    }
}
