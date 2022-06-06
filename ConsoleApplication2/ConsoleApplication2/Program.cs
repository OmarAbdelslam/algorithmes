using System;
using System.Linq;

namespace ConsoleApplication2
{
    public delegate void Dele(object N);
   class test
    {
        public event Dele _Event;
        public void Name (object N)
        {
            object _N = N;
            if (_N == "omar") _Event("Noooooooo");
            else
                Console.WriteLine(N);
        }
        public void Adg(object A)
        {
            Console.WriteLine(A);
        }
        public void _EveHand(object D)
        {
            Console.WriteLine("Noooooooooo");
        }
        public void _Eve(object D)
        {
            Console.WriteLine("Noooooooooo");
        }
    }
    class Program
    {

        //public static int[] CountPosSumNeg(double[] arr)
        //{
        //    arr = new double[25];
        //    int s;
        //    for (int a=0;a<arr.Length;a++)
        //    {
        //        if (arr [a] > 0 )
        //        {
        //            s = arr.Count();
        //        }
        //        else if(arr[a] < 0)
        //        {
        //            s = arr[a]
        //        }
        //    }
        //    return s[]

        //}

    
        class smoothis
        {
            
            //public smoothis(string [] arr)
            //{
            //   string a= itedratied[Convert.ToInt16( arr)];
            //}
            public string [] itedratied
            {
               
                get;set;
            }

            public double GetCost()
            {
               
                double C=0;
                for (int a = 0; a < 1; a++)
                {
                    if (itedratied[a] == "panana")
                        C += 0.50 ;
                    if (itedratied[a] == "Pinapple")
                        C += 3.50;
                    if (itedratied[a] == "Mango")
                        C += 2.50;
                    if (itedratied[a] == "Apple")
                        C += 1.75;
                    if (itedratied[a] == "Raspberries")
                        C += 1.00;
                    if (itedratied[a] == "Blueberries")
                        C += 1.00;
                    if (itedratied[a] == "Strawberries")
                        C += 1.50;
                }
                return C;
            }
            public double GetPrice()
            {
                double P = GetCost() * 1.5;
                return P;
            }
            public void Name()
            {
                string N;
                int e = 0;
                
                for (int a = 0; a < itedratied.Length; a++)
                {
                    //N = String.Concat(itedratied[a]);
                   
                        Array.Sort(itedratied);
                }
                Console.WriteLine(itedratied[e++]);
                Console.Write(String.Join("",itedratied));
                if (itedratied.Length > 0)
                {
                    Console.Write("First");
                }
                else
                    Console.Write("Smoothis");

                //double a = itedratied.Length;
                //char[] _Name = itedratied[itedratied.Length - 1].ToCharArray();
                //Array.Sort(_Name);

                //return String.Join("", _Name);
            }
        }

        //a = String.Concat(str.First()).ToLower();
        //a = String.Concat(str).ToLower();

        //public static string Name(string str)
        //{
        //    char a = char.Parse(str);
        //    String.Concat(a.)
        //    return
        //}

        public static int[] Arr(int P1,int P2)
        {
            int[] arr = new int[P2];
            for(int a=0;a<P2;a++)
            {
                arr[a] = P1 * a + 1;
            }
            return arr ;
        }

        //public static string Interview(int[] arr, int tot)
        //{
        //    arr = new int[tot];
        //    if (arr[0] > 5)
        //        Console.WriteLine("disqualified");
        //    for (int a=0;a<arr.Length;a++)
        //    {

        //        for(int d=0;d <4;d++)
        //        {
        //            if (arr[a] > d)
        //                Console.WriteLine("disqualified");
        //        }
        //    }

        //    return;
        //}

        //private static int [] array(int num , int lenght)
        //  {

        //      int[] aa = new int[lenght];
        //      for(int a=1;a <= lenght;a++)
        //      {
        //       int[]d =  aa [num * a];
        //      }
        //      for (int a = 0; a < aa.Length; a++)
        //      {
        //          return aa;
        //      }
        //  }


        public static int GetAbsSum(int[] arr)
        {
            int result=0;
            for (int f=0;f<arr.Length;f++)
            {
                result += arr[f];
            }
            return result;
        }


      static private void StatementBomb(string txt)
        {
            char[] Arr2 = new char[] { 'b', 'o', 'm', 'b' };
            char[] statement = txt.ToCharArray();
            int timer = 1;
            int a = 0;
            while(a<txt.Length)
            {
                for(int x = 0; x < Arr2.Length; x++)
                {
                    if (statement[a] == Arr2[x])
                    {
                        timer += 1;
                    }
                }
                a++;
            }
            if (timer == 4)
            {
                Console.WriteLine("Relacs Dont Wory");
            }
            else if(timer != 4)
            {
                Console.WriteLine("Take air this bomb");
            }
        }

        public static int[] ArrayOfMultiples(int num, int length)
        {
            int s = 1;
            int[] arr = new int[length];
            for (int a = 0; a < arr.Length; a++)
            {
                arr[a] = num * s++;
                
            }
            return arr;
        }
        static void Main(string[] args)
        {
            //int[] w= ArrayOfMultiples(7, 5);
            // for (int a = 0; a < w.Length; a++)
            //     Console.WriteLine(w[a]);
            // Console.ReadKey();

            //  داخل الدالة لتمكننا من استخدام فئات او وظائف اخري ليست موجودة بداخل هذا الكائن الذي انشأنه useing نستخدم الكلمة 
            //using (System.Data.SqlClient.SqlConnection Conn = new System.Data.SqlClient.SqlConnection(@"Data Source=/*(LocalDB)\MSSQLLocalDB;AttachDbFilename=*/F:\Wedding_Hall\Wedding_Hall\Wedding_Hall\Hall.mdf;Integrated Security=True"))
            using(System.Data.SqlClient.SqlConnection Conn=new System.Data.SqlClient.SqlConnection())
            {
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                //Conn.ConnectionString = @"Data Source=C:\Program Files\Microsoft SQL Server\MSSQL15.SQL2019\MSSQL\DATA\Libarary.mdf;Integrated Security=True";
                //Conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|C:\Program Files\Microsoft SQL Server\MSSQL15.SQL2019\MSSQL\DATA\Libarary.mdf;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True";
                //Conn.ConnectionString = @"Data Source = DESKTOP - RTMN4HO\SQL2019; Initial Catalog = Libarary; User ID = sa; Password = ***********";

                //Conn.ConnectionString = @"Server=DESKTOP_RTMN4HO\SQL2019;Database=Libarary;Trusted_Connection=True; providerName = System.Data.SqlClint";

                //Conn.ConnectionString = @"metadata=res://*/Ado_Net.csdl|res://*/Ado_Net.ssdl|res://*/Ado_Net.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=DESKTOP-RTMN4HO\SQL2019;initial catalog=Libarary;user id=sa;password=01126920859;MultipleActiveResultSets=True;App=EntityFramework&quot; providerName = System.Data.EntityClient";

                //Conn.ConnectionString = @"data source=DESKTOP-RTMN4HO\SQL2019;initial catalog=Libarary;user id=sa;MultipleActiveResultSets=True;App=EntityFramework ;providerName = System.Data.SqlClient";
                Console.WriteLine(Conn.Database);
                Conn.Open();
                Console.WriteLine("Connect Successfully.");
                Console.ReadKey(true);

            };
        }
    }
}
// عكس النص Reverse
//Console.WriteLine("Enter Text  : ");
//string text = Console.ReadLine();
// string text2 = "";
//for(int a=0;a<=text.Length -1 ;a++)
// {
//     text2 += text[text.Length - 1 - a];
// }
// Console.WriteLine(text2);



// تحديد الاحرف المتحركة في الجملة

////int total = 0;

////Console.WriteLine("Enter a Sentence");
////string sentence = Console.ReadLine().ToLower();

////for (int i = 0; i < sentence.Length; i++)
////{
////    if (sentence.Contains("a") || sentence.Contains("e") || sentence.Contains("i") || sentence.Contains("o") || sentence.Contains("u"))
////    {
////        total++;
////    }
////}
////Console.WriteLine("Your total number of vowels is: {0}", total);

////Console.ReadLine();
////Console.WriteLine("Enter Text  : ");
////string text = Console.ReadLine();
//string[] arr = new string[] { "A", "E", "I", "O", "U" };
////text = String.Concat(arr[0]);
////for(int s=0;s<text.Length;s++)
////{
////    if(text.Contains(arr[0]) || text.Contains(arr[1]))
////}
//string text2 = "A";
//    if (text2 == String.Concat(arr[0]))
//    {
//        for (int a = 0; a < 5; a++)
//            Console.WriteLine(a);
//    }
//Console.ReadKey();
//string Vowels = "A E I O U";


//عكس الارقام
//int[] arr = new int[5];
//Console.WriteLine("Enter");
//for (int a = 0; a < arr.Length; a++)
//{
//    arr[a] = int.Parse(Console.ReadLine());
//}
//for (int a = arr.Length-1; a >=0; a--)
//{
//    Console.WriteLine(arr[a]);
//}
