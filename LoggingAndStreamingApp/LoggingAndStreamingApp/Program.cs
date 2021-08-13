//#define TEST
using System;
using System.IO;
using System.Diagnostics;


namespace LoggingAndStreamingApp
{
    class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //var text = Console.ReadLine();
            //Console.WriteLine($"Hello {text}, its now {DateTime.Now} ");
            //File.WriteAllText("Hello.txt", text);
            //string readText = File.ReadAllText("Hello.txt");
            //Console.WriteLine(readText);
            //File.AppendAllText("Hello.txt", text);

            //string[] lines = { "Mary had a littlte lamb", "Its fleece was white as now", "Everywhere that Mary went", "The lamb was sure to go" };
            //File.WriteAllLines("Mary.txt", lines);
            //string[] readlines = File.ReadAllLines("Mary.txt");
            //foreach (var line in readlines)
            //{
            //    Console.WriteLine(line);
            //}

            //Debug.WriteLine($"Debug - this s a debug item");
            //Trace.WriteLine("Trace - This is a trace item");

            //Console.WriteLine($"This is being logged at a time {DateTime.Now}");
            //TextWriterTraceListener twtl = new TextWriterTraceListener(File.Create("TraceOutput.txt"));
            //Trace.Listeners.Add(twtl);
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(i);
            //    Debug.WriteLine($"Debug - the value of i is {i}");
            //    Trace.WriteLine($"Treace - the value of i is {i}");
            //    Debug.WriteLine(i == 2, $"\nReached maximum value of i: {i} at {DateTime.Now}");
            //    Trace.Assert(i > 0, $"i is not greater than zero: {i}");
            //}
            //Trace.Flush();

            //            Console.WriteLine("Starting up");
            //#if DEBUG
            //            Console.WriteLine("This debug code");
            //#endif
            //#if TEST
            //            Console.WriteLine("This is a test");
            //#endif
            //            Console.WriteLine("Finishing app");
            string path = @"LiveForever.txt";
            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("Live - Forever");
            }
            using (StreamReader sr = File.OpenText(path))
            {
                string s = " ";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
