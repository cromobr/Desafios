﻿using System.CodeDom.Compiler;
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

namespace Desafios
{
    class ArrayDesafio
    {/*
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            Console.Write(inverseArray(arr));
        }
        */
        private static string inverseArray(int[] arr)
        {
            String inverseOrder = "";

            for (int i = arr.Length-1; i >= 0; i--)
            {
                inverseOrder = inverseOrder  + arr[i] + " ";
            }

            return inverseOrder;
        }
    }
}
