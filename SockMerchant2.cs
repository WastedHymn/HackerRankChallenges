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

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar) {
        int pair=0;
        Dictionary<int, int> socks = new Dictionary<int, int>();
        
        for(int i=0; i<n; i++){
            if(socks.ContainsKey(ar[i])){
                socks[ar[i]] += 1;
            }else{
                socks.Add(ar[i], 1);
            }
        }
        
         foreach(KeyValuePair<int, int> sock in socks){
            Console.WriteLine(sock.Key+" "+sock.Value);
            int a = sock.Value;   
            a = a / 2;
            pair += a;
        }

        return pair;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
