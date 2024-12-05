namespace Assignments_5._3._1
{
    internal class Program
    {
        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int count = 0; 
            int length = flowerbed.Length;

            for (int i = 0; i < length; i++)
            {
                if (flowerbed[i] == 0) 
                {
                    bool leftEmpty = (i == 0) || (flowerbed[i - 1] == 0);
                    bool rightEmpty = (i == length - 1) || (flowerbed[i + 1] == 0);

                    if (leftEmpty && rightEmpty)
                    {
                        flowerbed[i] = 1;
                        count++;

                        if (count >= n)
                        {
                            return true;
                        }
                    }
                }
            }

            return count >= n;
        }

        static void Main(string[] args)
        {
            int[] flowerbed1 = { 1, 0, 0, 0, 1 };
            int n1 = 1;
            Console.WriteLine(CanPlaceFlowers(flowerbed1, n1)); 

            int[] flowerbed2 = { 1, 0, 0, 0, 1 };
            int n2 = 2;
            Console.WriteLine(CanPlaceFlowers(flowerbed2, n2));
        }
    }
}
