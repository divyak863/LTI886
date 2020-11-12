using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingProject
{
    class Program
    {
       

        int TakeArrayData()
        {
            try
            {
                Console.WriteLine("PLease enter a number");
                int inum1 = Convert.ToInt32(Console.ReadLine());
                int[] nums = new int[inum1];
                try
                {
                    for (int i = 0; i < 4; i++)
                    {
                        nums[i] = i * 10 + i + 1;
                    }
                }
                catch (IndexOutOfRangeException ie)
                {
                    Console.WriteLine("You are trying to access an index that is not available");
                }
                Console.WriteLine("The array is ");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(nums[i]);
                }
                int sum = 0;
                for (int i = 0; i < 3; i++)
                {
                    sum += nums[i];
                }
               
                Console.WriteLine("The sum of all the numbers "+sum);
                int result = nums[1] / nums[0];
               return sum;
            }
            catch(FormatException fe)
            {
                Console.WriteLine("Invalid format for number");
            }
            catch(DivideByZeroException dbz)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            catch (Exception)
            {
                Console.WriteLine("Some error");
            }
            finally
            {
                Console.WriteLine("Always!!!!!");
            }
            Console.WriteLine("outside the try-catch-finally");
            return 0;
        }


        void TakeTwoNumber()
        {
            try
            {
                Console.WriteLine("PLease enter a number");
                int inum1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("PLease enter a number");
                int inum2 = Convert.ToInt32(Console.ReadLine());
                int result = inum1 / inum2;
                Console.WriteLine(result);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Invalid input. Getout");
                Console.WriteLine(fe.Message);
                Console.WriteLine(fe.Data);
                Console.WriteLine(fe.Source);
                Console.WriteLine(fe.StackTrace);
            }
            catch (DivideByZeroException dbz)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            catch (Exception e)
            {
                Console.WriteLine("Some error");
            }
            Console.WriteLine("After the catch");
        }
        int TakeAge()
        {
            Console.WriteLine("PLease enter a number");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 13)
                throw new AgeException();
            return age;
        }
        static void Main(string[] args)
        {
            try
            {
                int age = new Program().TakeAge();
                Console.WriteLine("The age is "+age);
            }
            catch (AgeException ae)
            {

                Console.WriteLine(ae.Message);
            }
            Console.ReadKey();
        }
    }
}
