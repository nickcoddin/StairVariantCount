namespace StairVariantCount
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = 12; 
            int variants = CountVariants(n);
            Console.WriteLine(variants);
        }

        static int CountVariants(int stairCount)
        {
            if (stairCount <= 0)
            {
                return 0;
            }
            else if (stairCount == 1)
            {
                return 1;
            }
            else if (stairCount == 2)
            {
                return 2;
            }
            else
            {
                int[] variants = new int[stairCount + 1];
                variants[0] = 0;
                variants[1] = 1;
                variants[2] = 2;

                for (int i = 3; i <= stairCount; i++)
                {
                    variants[i] = variants[i - 1] + variants[i - 2];
                }

                return variants[stairCount];
            }
        }
    }
}