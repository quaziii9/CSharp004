
namespace CSharp004
{
    internal class Reverse
    {
        public static int[] Reverse1(int[] num_list)
        {
            Array.Reverse(num_list);
            int[] answer = num_list;

            return answer;
        }

        public static int[] Reverse2(int[] num_list)
        {
            int[] arr = new int[num_list.Length];

            int k = 0;
            for(int i = num_list.Length-1; i>=0; i-- )
            {
                arr[k] = num_list[i];
                k++;
            }
            return arr;
        }

        static void Main(string[] args)
        {
            int[] num = new int[] { 1, 2, 3, 4, 5 };
            int[] array = new int[5];
            array = Reverse1(num);
            //array = Reverse2(num);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
