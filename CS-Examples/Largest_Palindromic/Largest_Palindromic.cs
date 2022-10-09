namespace Largest_Palindromic
{
    internal class Program
    {
        static void Main()
        {
            int num;

            for (int x = 999; x >= 100; x--)        //
            {                                       // teker teker 999 dan 100 e kadar birbiriyle carpip kontrol etmesi icin dongu
                for (int y = 999; y >= 100; y--)    //
                {
                    num = x * y;
                    if (palincont(num))
                    {
                        Console.WriteLine("3 basamakli 2 sayinin carpimindan olusan en buyuk palindromik sayi = {0} = {1} x {2}", num, x , y);
                        return;
                    }
                }
            }
        }
        public static int bsmk(int num) //bu metod parametre olarak girilen sayinin basamak sayisini donduruyor
        {
            int dig = 0;
            while (num != 0)
            {
                num /= 10;
                dig++;
            }
            return dig;
        }
        public static bool palincont(int num) //bu metod parametre olarak verilen sayinin palindromik olup olmadigini kontrol ediyor
        {
            int size = bsmk(num), i = 0;
            string nb = num.ToString();

            while (i < size)
            {
                if (nb[i] == nb[size - 1])
                {
                    i++;
                    size--;
                }
                else
                    return false;
            }
            return true;
        }
    }
}
