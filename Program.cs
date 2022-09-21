namespace WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            int i = 0;
            while(i < nums.Length)
            {
                nums[i] = i;
                Console.Write(" | " + nums[i]);
                i++;
            }
            Console.Write("\n\n");
            do
            {   
                i--;
                if (i == 8) { Console.Write(" | Skippped");continue;}
                if(i == 3) { Console.Write(" | Done"); break;}
                Console.Write(" | " + nums[i]);
            }
            while(i > 0);
            Console.ReadKey();

        }
    }
}