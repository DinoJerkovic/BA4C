using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace BA4C
{
    class Program
    {
        public static Dictionary<string,int> mass()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict["G"] = 57;
            dict["A"] = 71;
            dict["S"] = 87;
            dict["P"] = 97;
            dict["V"] = 99;
            dict["T"] = 101;
            dict["C"] = 103;
            dict["I"] = 113;
            dict["L"] = 113;
            dict["N"] = 114;
            dict["D"] = 115;
            dict["K"] = 128;
            dict["Q"] = 128;
            dict["E"] = 129;
            dict["M"] = 131;
            dict["H"] = 137;
            dict["F"] = 147;
            dict["R"] = 156;
            dict["Y"] = 163;
            dict["W"] = 186;
            return dict;
            
        }
        public static int total_mass(string peptide)
        {
            int br = 0;
            Dictionary<string, int> dict = mass();
            for(int i = 0; i < peptide.Length; i++)
            {
                br = br + dict[peptide.Substring(i, 1)];
            }
            return br;
        }
        public static List<int> cyclospectrum(string peptide)
        {
            List<int> spectrum = new List<int>();
            spectrum.Add(total_mass(peptide));
            spectrum.Add(0);
            string peptide2 = peptide + peptide;//da gledam ciklicki
            for(int i = 1; i < peptide.Length; i++)
            {
                for(int j = 0; j < peptide.Length; j++)
                {
                    string subpep = peptide2.Substring(j, i);
                    spectrum.Add(total_mass(subpep));
                }
            }
           spectrum.Sort();
            return spectrum;


        }
        static void Main(string[] args)
        {
           
            
            List<int> c = cyclospectrum("LEQN");
            foreach (int p in c)
                Console.Write(p + " ");
            Console.ReadLine();
        }
        
    }
}
