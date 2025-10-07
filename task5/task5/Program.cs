using System.Collections;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine()); ;
            try
            {
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide by zero: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Overflow error: " + e.Message);
            }
            catch (Exception e) {
                Console.WriteLine("Other error: " + e.Message);
            }

            try
            {
               int[] arr = [7, -1, 6];
               Console.WriteLine(arr[6]);
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine("Null reference error: " + e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Index " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Other error: " + e.Message);
            }

            MyResource r1 = new MyResource();
            r1.Dispose();




            ArrayList list = new ArrayList();
            list.Add("Menna");
            list.Add("Mona");
            list.Add("Sara");
            list.Add("farida");
            using (TextWriter writer = new StreamWriter("output.txt"))
            {
                foreach (var item in list)
                {
                    writer.WriteLine(item); 
                }
            }

        }
    }
}











