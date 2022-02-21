using System;
using CommandLine;
using RomanToNumber.Helper;

namespace RomanToNumber
{
    public class Options
    {
        [Option('c', "convert", Required = false, HelpText = "Convert Roman to number")]
        public string RomanText { get; set; }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                   .WithParsed<Options>(o =>
                   {
                       if (!String.IsNullOrEmpty(o.RomanText))
                       {
                           Console.WriteLine($"Current Argument Roman: {o.RomanText}");
                           try
                           {
                               int numberValue = ConvertRomanToNum.ConvertToNum(o.RomanText);
                               Console.WriteLine($"Number value: {numberValue}");
                           }
                           catch (Exception ex)
                           {
                               Console.WriteLine(ex.Message);
                           }
                       }
                   });
        }
    }
}