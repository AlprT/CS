namespace dnm
{
    internal class Program
    {
        static void Main()
        {
            int res = 20;

            while(!Control(res))
            {
                res++;

            }

            Console.WriteLine(res);
        }
        public static bool Control(int num)
        {
            int i = 1;

            while (i <= 20)
            {
                if (num % i == 0)
                    i++;
                else
                    return false;
            }
            return true;
        }
    }
}