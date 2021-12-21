using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    class Program
    {

        //static void Main(string[] args)
        //{
        //    var dateString = "2013-9-26";
        //    var dateString2 = "213-9-26";

        //    var date = Convert.ToDateTime(dateString);
        //    Console.WriteLine(date);

        //    DateTime date3;
        //    if (DateTime.TryParse(dateString2, out date3))
        //    {
        //        Console.WriteLine(date3);
        //    }

        //    Console.WriteLine(date3);

        //    //var date2 = Convert.ToDateTime(dateString2);
        //    //Console.WriteLine(date2);

        //    Console.ReadKey();
        //}



        static void Main(string[] args)
		{
			StringReverse();

			//Test1.Main2(args);
			//Test2.Main2(args);
			//Test3.Main2(args);

			////ArrayList vs array
			//string[] employee_1 = { "Employee1" };
			//string[] employee_2 = { "Employee2" };
			//ArrayList main_array = new ArrayList();
			//main_array.Add(employee_1);
			//main_array.Add(employee_2);
			//for (int i = 0; i < 2; i++)
			//{
			//    Console.WriteLine(string.Join(", ", main_array[i] as string[]));
			//}

			//var input = "abcdefghijklmnopqrstuvwxyz";
			////Console.WriteLine("abcdefghijklmnopqrstuvwxyz".All(input.ToLower().Contains));
			//Console.WriteLine("abcdefghijklmnopqrstuvwxyz".All(input.Contains));
			//Console.WriteLine("abcdefghijklmnopqrstuvwxyz".Contains(input));
			//Console.WriteLine("abcdefghijklmnopqrstuvwxyz".IndexOfAny(new char[] { 's' }));

			//TestObject testObject = new TestObject();
			//var request = new Models.Payment123GMORequest();
			//request.bank_code = "100";
			//request.bank_mobile_number = "890829034";
			//request.bank_email_address = "rousonur@2c2p.com";
			//request.bank_payer_name = "rony";
			//testObject.TestMethod(request);
			Console.ReadKey();
		}

		private static void StringReverse()
		{
			// List of string  
			List<string> authors = new List<string>(5);
			authors.Add("Mahesh Chand");
			authors.Add("Chris Love");
			authors.Add("Allen O'neill");
			authors.Add("Naveen Sharma");
			authors.Add("Mahesh Chand");
			authors.Add("Monica Rathbun");
			authors.Add("David McCarter");

			Console.WriteLine("Original List items");
			Console.WriteLine("===============");
			// Print original order  
			foreach (string a in authors)
				Console.WriteLine(a);

			List<List<string>> list = new List<List<string>>();
			list.Add(authors);
			list[0].Reverse();
			Console.WriteLine("===============");
			foreach (string a in list[0])
				Console.WriteLine(a);

			//// Reverse list items  
			//authors.Reverse();

			//Console.WriteLine();
			//Console.WriteLine("Sorted List items");
			//Console.WriteLine("===============");
			//// Print reversed items  
			//foreach (string a in authors)
			//    Console.WriteLine(a);
		}
	}

    public class TestObject
    {
        public int TestMethod(Models.Payment123GMORequest request)
        {
            var temp = request;
            return 0;
        }
    }
}
