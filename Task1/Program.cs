using System;
using System.IO;
using System.Text;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection, range;
            Console.WriteLine("Type the number of selection");
            Console.WriteLine("1. Constant");
            Console.WriteLine("2. Sum");
            Console.WriteLine("3. Product");
            Console.WriteLine("4. Polynomial");
            Console.WriteLine("5. Bubble Sort");
            Console.WriteLine("6. Quick Sort");
            Console.WriteLine("7. Timsort");
            Console.WriteLine("8. ProductMatrix");
            selection = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert the range of values for the vector");
            range = int.Parse(Console.ReadLine());
            int limit = 2000;
            int[] v = new int[limit];
            int[] list = new int[limit];
            int[] list2 = new int[limit];

            Random rnd = new();
            for (int i = 0; i < limit; i++)
            {
                int temp = rnd.Next(1, range);
                v[i] = temp;
            }
            for (int i = 1; i <= limit; i++)
            {
                list[i-1] = i;
                list2[i - 1] = i;

            }
           
            int[] list3 = randomlist(list2, limit);
            int[] list4 = randomlist(list2, limit);
            int[] list5 = randomlist(list2, limit);
            int[] list6 = randomlist(list2, limit);

            for (int i = 0; i < limit; i++)
            {
                
                int temp = rnd.Next(0, limit-i);
                list3[i] = list2[temp];
                for (int j = 0; j < limit - i; j++)
                {
                    if (j < limit-1)
                    {
                        if (j >= temp)
                            list2[j] = list2[j + 1];
                        else
                            list2[j] = list2[j];
                    }
                    
                }

            }


            var csv2 = new StringBuilder();
            for (int i = 0; i < limit; i++)
            {
                var newLine = string.Format("{0},{1},{2}", list[i], list3[i], list2[i]);
                csv2.AppendLine(newLine);

            }
            File.WriteAllText(@"D:\U\ITMO\Algorithms\Task1\Logs\" + DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH'-'mm'-'ss") + @".csv", csv2.ToString());


            var csv = new StringBuilder();
            double account = 0;


            switch (selection)
            {
                case 1:
                    csv.AppendLine(string.Format("{0}|{1}", "Start ", DateTime.Now.ToString("yyyy'-'MM'-'dd'-'HH':'mm':'ss.fffffffK")));
                    for (int i = 0; i < limit; i++)
                    {
                        csv.AppendLine(string.Format("{0},{1}", "1", DateTime.Now.ToString("yyyy'-'MM'-'dd'-'HH':'mm':'ss.fffffffK")));
                        

                    }
                    csv.AppendLine(string.Format("{0}|{1}", "End ", DateTime.Now.ToString("yyyy'-'MM'-'dd'-'HH':'mm':'ss.fffffffK")));
                    File.WriteAllText(@"D:\U\ITMO\Algorithms\Task1\Logs\1\" + DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH'-'mm'-'ss") + @".csv", csv.ToString());
                    break;
                case 2:
                    csv.AppendLine(string.Format("{0}|{1}", "Start ", DateTime.Now.ToString("yyyy'-'MM'-'dd'-'HH':'mm':'ss.fffffffK")));
                    for (int i = 0; i < limit; i++)
                    {
                        account += v[i];
                        var newLine = string.Format("{0},{1},{2}", v[i], account, DateTime.Now.ToString("yyyy'-'MM'-'dd'-'HH':'mm':'ss.fffffffK"));
                        csv.AppendLine(newLine);

                    }
                    csv.AppendLine(string.Format("{0}|{1}", "End ", DateTime.Now.ToString("yyyy'-'MM'-'dd'-'HH':'mm':'ss.fffffffK")));
                    File.WriteAllText(@"D:\U\ITMO\Algorithms\Task1\Logs\2\" + DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH'-'mm'-'ss") + @".csv", csv.ToString());
                    break;
                case 3:
                    csv.AppendLine(string.Format("{0}|{1}", "Start ", DateTime.Now.ToString("yyyy'-'MM'-'dd'-'HH':'mm':'ss.fffffffK")));
                    account = 1;
                    for (int i = 0; i < limit; i++)
                    {
                        account *= v[i];
                        var newLine = string.Format("{0},{1},{2}", v[i], account, DateTime.Now.ToString("yyyy'-'MM'-'dd'-'HH':'mm':'ss.fffffffK"));
                        csv.AppendLine(newLine);

                    }
                    csv.AppendLine(string.Format("{0}|{1}", "End ", DateTime.Now.ToString("yyyy'-'MM'-'dd'-'HH':'mm':'ss.fffffffK")));
                    File.WriteAllText(@"D:\U\ITMO\Algorithms\Task1\Logs\3\" + DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH'-'mm'-'ss") + @".csv", csv.ToString());
                    break;
                case 4:
                    csv.AppendLine(string.Format("{0}|{1}", "Start ", DateTime.Now.ToString("yyyy'-'MM'-'dd'-'HH':'mm':'ss.fffffffK")));
                    for (int i = 0; i < limit; i++)
                    {
                        account = v[i] * (Math.Pow(1.5, i - 1));
                        var newLine = string.Format("{0}|{1}|{2}", v[i], account, DateTime.Now.ToString("yyyy'-'MM'-'dd'-'HH':'mm':'ss.fffffffK"));
                        csv.AppendLine(newLine);

                    }
                    csv.AppendLine(string.Format("{0}|{1}", "End ", DateTime.Now.ToString("yyyy'-'MM'-'dd'-'HH':'mm':'ss.fffffffK")));
                    File.WriteAllText(@"D:\U\ITMO\Algorithms\Task1\Logs\4\" + DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH'-'mm'-'ss") + @".csv", csv.ToString());
                    break;
                case 5:
                    bubble sort = new();
                    int tmp;
                    int[] sorted = vforsort(list3,limit);
                    csv.AppendLine(string.Format("{0}|{1}", "Start ", DateTime.Now.ToString("yyyy'-'MM'-'dd'-'HH':'mm':'ss.fffffffK")));
                    for (int i = 0; i < limit - 1; i++)
                    {
                        for (int j = 0; j < limit - i - 1; j++)
                            if (sorted[j] > sorted[j + 1])
                            {
                                tmp = sorted[j + 1];
                                // swap tmp and arr[i] int tmp = arr[j];
                                sorted[j + 1] = sorted[j];
                                sorted[j] = tmp;
                            }
                        csv.AppendLine(string.Format("{0}|{1}|{2}", list3[i], sorted[i], DateTime.Now.ToString("yyyy'-'MM'-'dd'-'HH':'mm':'ss.fffffffK")));
                        
                    }
                    csv.AppendLine(string.Format("{0}|{1}", "End ", DateTime.Now.ToString("yyyy'-'MM'-'dd'-'HH':'mm':'ss.fffffffK")));
                    csv.AppendLine(string.Format("{0}|{1}", "Original ", "Sorted"));
                    csv = appendLines(list3, sorted, limit, csv);                    
                    File.WriteAllText(@"D:\U\ITMO\Algorithms\Task1\Logs\5\" + DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH'-'mm'-'ss") + @"_Bubble.csv", csv.ToString());
                    break;

                case 6:
                    quicksort qsort = new quicksort();
                    int[] qsorted = vforsort(list3,limit);
                    var qnewLine = string.Format("{0}|{1}", "Start ", DateTime.Now.ToString("yyyy'-'MM'-'dd'-'HH':'mm':'ss.fffffffK"));
                    csv.AppendLine(qnewLine);
                    int[] qsortedresult = qsort.Sort(qsorted, 0, limit - 1);
                    qnewLine = string.Format("{0}|{1}", "End ", DateTime.Now.ToString("yyyy'-'MM'-'dd'-'HH':'mm':'ss.fffffffK"));
                    csv.AppendLine(qnewLine);
                    qnewLine = string.Format("{0}|{1}", "Original ", "Sorted");
                    csv.AppendLine(qnewLine);
                    csv= appendLines(list3, qsortedresult,limit, csv);                    
                    File.WriteAllText(@"D:\U\ITMO\Algorithms\Task1\Logs\6\" + DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH'-'mm'-'ss") + @"_Quicksort.csv", csv.ToString());
                    break;
                case 7:
                    Timsort tsort = new Timsort();
                    int[] tsorted = vforsort(list3, limit);
                    var tnewLine = string.Format("{0}|{1}", "Start ",DateTime.Now.ToString("yyyy'-'MM'-'dd'-'HH':'mm':'ss.fffffffK"));
                    csv.AppendLine(tnewLine);                    
                    int[] tsortedresult = tsort.sort(tsorted,limit);
                    tnewLine = string.Format("{0}|{1}", "End ", DateTime.Now.ToString("yyyy'-'MM'-'dd'-'HH':'mm':'ss.fffffffK"));
                    csv.AppendLine(tnewLine);
                    tnewLine = string.Format("{0}|{1}", "Original ", "Sorted");
                    csv.AppendLine(tnewLine);
                    csv = appendLines(list3, tsortedresult, limit, csv);
                    File.WriteAllText(@"D:\U\ITMO\Algorithms\Task1\Logs\7\" + DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH'-'mm'-'ss") + @"Timsort.csv", csv.ToString());
                    break;
                case 8:
                    csv.AppendLine(string.Format("{0}|{1}", "Start ", DateTime.Now.ToString("yyyy'-'MM'-'dd'-'HH':'mm':'ss.fffffffK")));
                    int[,] prodmat = productmatrix(creatematrix(limit), creatematrix(limit), limit);
                    csv.AppendLine(string.Format("{0}|{1}", "End ", DateTime.Now.ToString("yyyy'-'MM'-'dd'-'HH':'mm':'ss.fffffffK")));
                    File.WriteAllText(@"D:\U\ITMO\Algorithms\Task1\Logs\8\" + DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH'-'mm'-'ss") + @"ProductMatrix.csv", csv.ToString());
                    break;
            }





        }

        static string vtostring(int[]v, int limit)
        {
            string result = v[0].ToString();

            for (int i = 1; i < limit - 1; i++)
            {
                result += "," + v[i].ToString() ;

            }
            return result;
        }

        static StringBuilder appendLines(int[] v, int[] s, int limit, StringBuilder sb)
        {
           

            for (int i = 0; i < limit; i++)
            {
                var newLine =  string.Format("{0}|{1}", v[i], s[i]);
                sb.AppendLine(newLine);

            }
            return sb;
        }

        static int[] vforsort(int[] v, int limit)
        {
            int[] vfor = new int[2000];
            for (int i = 0; i < limit; i++)
            {
                vfor[i] = v[i];
            }
            return vfor;
        }

        static int[] randomlist( int[] list2, int limit) 
        {
            Random rnd = new();
            int[] list3 = new int[limit];
            for (int i = 0; i < limit; i++)
            {

                int temp = rnd.Next(0, limit - i);
                list3[i] = list2[temp];
                for (int j = 0; j < limit - i; j++)
                {
                    if (j < limit - 1)
                    {
                        if (j >= temp)
                            list2[j] = list2[j + 1];
                        else
                            list2[j] = list2[j];
                    }

                }

            }
            return list3;
        }
        static int[,] creatematrix( int limit)
        {
            Random rnd = new();
            int[,] mat = new int[limit, limit];
            for (int i = 0; i < limit; i++)
            {
                for (int j = 0; j < limit; j++)
                {
                    mat[i, j] = rnd.Next(1, limit);

                }

            }
            return mat;
        }

        static int[,] productmatrix(int[,] a, int[,] b, int limit)
        {

            int[,] temp = new int[limit,limit];
            for (int i = 0; i < limit; i++)
            {
                for (int j = 0; j < limit; j++)
                {
                    temp[i, j] = a[i, j] * b[i, j];

                }

            }
            return temp;

        }
    }
}
