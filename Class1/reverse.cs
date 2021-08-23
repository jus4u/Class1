using System;
using System.Collections.Generic;
using System.Text;

namespace Class1
{
    class reverse
    {
        static void Main(string[] args)
        {


            //string enteredstring = "aaaaabbcddd";
            //string[] chararray = new string[enteredstring.Length];
            //int n = 1;
            //string output = "";
            //for (int i = 0; i < chararray.Length; i++)

            //{
                
            //    chararray[i] = enteredstring.Substring(i,1);

            //}

            //for (int j = 0; j < chararray.Length; j++)
            //{
            //    if (j + 1 <= chararray.Length - 1)
            //    {


            //        if (chararray[j] == chararray[j + 1])
            //        {
            //            n = n + 1;
                       
            //        }
            //        else
            //        {
            //            if (n == 1)
            //            {
            //                output = output + chararray[j];
            //            }
            //            else
            //            {
            //                output = output + n.ToString() + chararray[j];
            //                n = 1;
            //            }
            //        }
                    


            //    }
            //    else {

            //        if (j + 1 == chararray.Length)
            //        {
            //            output = output + n.ToString() + chararray[j];

            //        }

            //    }
                //else
                //{
                  

                //}
        //    }
        //    Console.WriteLine(output);
        //    Console.ReadKey();
        //}
        //Console.WriteLine(output);

        Console.WriteLine("Enter String");
            string S1 = "Kiran";
            string S1 = Console.ReadLine();
        string S2 = S1.Substring(S1.Length - 3,2);
            Console.WriteLine(S2);
      //  Console.WriteLine(S2.Substring(2,1)+ S2.Substring(1, 1)+ S2.Substring(0, 1));
                Console.ReadKey();
            }
}
    }

