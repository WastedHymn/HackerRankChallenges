using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the jumpingOnClouds function below.
    static int jumpingOnClouds(int[] c) {
        int jumps=0;
        int i=0;
        bool toogle=false;
        while(true){
            
            if(i+2 < c.Length){    
                if(c[i+2] != 1){
                 i += 2;
                 jumps++;
                 toogle=true;
                }
            }

            if(!toogle){
                if(i+1 < c.Length){
                    if(c[i+1] != 1){
                        i += 1;
                        jumps++;
                    }
                }
            }

            toogle = false;

            if(i==c.Length-1){
                break;
            }
         
        }

        return jumps;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
        ;
        int result = jumpingOnClouds(c);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
