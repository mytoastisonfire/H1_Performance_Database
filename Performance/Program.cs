using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Performance

{
    internal class Program
    {
        #region Main
        static void Main(string[] args)
        {
            Controller();
        }
        #endregion
        #region Controller
        static void Controller()
        {
            string path = @"C:\Users\zbc23matlc\Desktop\Test\RandomTal.txt";
            Random rng = new Random();
            using (StreamWriter sw = File.AppendText(path))
            {
                for (int i = 0; i < 1000000; i++)
                {
                    int tilfældigtTal = rng.Next(1, 10000);
                    sw.WriteLine(i.ToString() + "," + tilfældigtTal);
                }
            }
            
        
        } 
        #endregion
        #region GUI
        static void GUI()
        {

        }
        #endregion
        #region Model
        static void Model()
        {

        }
        #endregion
    }
}