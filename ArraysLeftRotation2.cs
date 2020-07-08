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

    // Complete the rotLeft function below.
    static int[] rotLeft(int[] a, int d) {
        int size = a.Length;
        int[] b = new int[size];
        int num = 0;

        for(int i=0; i<size; i++){
    
            if(d > i){
                num = i - d + size;
                b[num] = a[i];
            }else{
                num = i - d;
                b[num] = a[i];
            }
    
            Console.WriteLine("Num: " + num);
            Console.WriteLine("i: " + i);
            Console.WriteLine("a["+i+"]: " + a[i]);
            Console.WriteLine("b["+num+"]:" + b[num]);
        }

        return b;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nd = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;
        int[] result = rotLeft(a, d);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
