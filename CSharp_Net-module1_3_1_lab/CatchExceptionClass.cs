using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_3_1_lab
{
    class CatchExceptionClass
    {
        public void CatchExceptionMethod()
        {
            try
            {
                MyArray ma = new MyArray();

                // 3) replace second elevent of array by 0

                int[] arr = new int[4] { 1, 6, 8, 5 };
                ma.Assign(arr, 4);

            }
           
                // 8) catch all other exceptions here
            catch (Exception ex)
            {
                Console.WriteLine(ex.HelpLink);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.TargetSite);
                // 9) print System.Exception properties:
                // HelpLink, Message, Source, StackTrace, TargetSite

            }

            // 10) add finally block, print some message
            // explain features of block finally
            finally
            {
                Console.WriteLine("text is finally block");
            }
        }
    }
}
