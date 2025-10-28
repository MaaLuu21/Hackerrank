// See https://akusing System.CodeDom.Compiler;
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

class Result
{

    /*
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void staircase(int n)
    {
        /*char[] escada = new char[n]; 

        for(int i = 0; i < n; i++)
        {
            escada[i] = ' ';
        }

        for(int i = n - 1; i >= 0; i--)
        {
            escada[i] = '#';
            Console.WriteLine(new string (escada));
        }
        */
        for (int i = 1; i <= n; i++) {
            for (int j = 0; j < n - i; j++) {
                Console.Write(" ");
            }
            for (int k = 0; k < i; k++) {
                Console.Write("#");
            }
            
        Console.WriteLine("");
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        Console.Write("Insira o valor: ");
        int n = int.Parse(Console.ReadLine());

        Result.staircase(n);
    }
}