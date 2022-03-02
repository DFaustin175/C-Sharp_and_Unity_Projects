using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Blocks
{
    internal class Program
    {
        static void Main()
        {
            

            try
            {
                List<int> nums = new List<int>();
                nums.Add(87);
                nums.Add(32);
                nums.Add(45);
                nums.Add(23);
                nums.Add(35436);
                int userinput = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < nums.Count; i++)
                {
                    int answer = nums[i] / userinput;
                    Console.WriteLine(nums[i] + " divided by " + userinput + " equals " + answer);
                }
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Use a whole number");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Do not divide by 0");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
