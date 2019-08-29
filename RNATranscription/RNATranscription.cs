using System;
using System.Collections.Generic;
namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {       

        public static string ToRna(string nucleotide)
        { 
            
            Dictionary <char,char> dict = new Dictionary <char,char>();
	        dict.Add('G', 'C');
	        dict.Add('C', 'G');
	        dict.Add('T', 'A');
	        dict.Add('A', 'U'); 
            
            string str="";
            foreach (char c in nucleotide)
            {
               // Console.WriteLine(dict[c]);
               str= str+ dict[c];
            } 
            return str;
        }
        static void Main(){
            ToRna("ACGTGGTCTTAA");
        }
    }
}
