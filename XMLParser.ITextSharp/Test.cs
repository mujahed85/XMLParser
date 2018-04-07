using System;
using iTextSharp.tutorial.Chapter1;
using iTextSharp.text.pdf;
using System.Data;

namespace iTextSharp.tutorial
{
	/// <summary>
	/// Main Class: Testing is going here...
	/// </summary>
	public class Test
	{
		static void Main() 		
		{
            //new Example1();
            //Console.WriteLine("Chapter1_Example1.pdf Created Successfully");
            //new Example2();
            //Console.WriteLine("Chapter1_Example2.pdf Created Successfully");
            //new Example3();
            //Console.WriteLine("Chapter1_Example3.pdf Created Successfully");
            //new Example4();
            //Console.WriteLine("Chapter1_Example4.pdf Created Successfully");
            //new Example5();
            //Console.WriteLine("Chapter1_Example5.pdf Created Successfully");
            //new Example6();
            //Console.WriteLine("Chapter1_Example6.pdf Created Successfully");
            //new Example7();
            //Console.WriteLine("Chapter1_Example7.pdf Created Successfully");
            new Example8();
            Console.WriteLine("Chapter1_Example8.pdf Created Successfully");


            new PdfTableCreate();
            DataTable table = GetTable();

            new PdfWithDt(table);

            Console.WriteLine("Press any key to exit...");
			Console.Read();
		}
        /// <summary>
        /// This example method generates a DataTable.
        /// </summary>
        static DataTable GetTable()
        {
            // Here we create a DataTable with four columns.
            DataTable table = new DataTable();
            table.Columns.Add("Dosage", typeof(int));
            table.Columns.Add("Drug", typeof(string));
            table.Columns.Add("Patient", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));

            // Here we add five DataRows.
            table.Rows.Add(25, "Indocin", "David", DateTime.Now);
            table.Rows.Add(50, "Enebrel", "Sam", DateTime.Now);
            table.Rows.Add(10, "Hydralazine", "Christoff", DateTime.Now);
            table.Rows.Add(21, "Combivent", "Janet", DateTime.Now);
            table.Rows.Add(100, "Dilantin", "Melanie", DateTime.Now);
            return table;
        }
    }
}
