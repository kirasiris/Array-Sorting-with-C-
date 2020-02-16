using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  
  public static void Main(string[] args) {
    
    // Defining An array to store strings:
    // string[] fruits = {"Orange","Mango","Apple", "",""};
    
    string[] fruits = new string[3];
    fruits[0] = "Banana";
    fruits[1] = "Cherries";
    fruits[2] = "Cherries";
    Console.WriteLine(fruits.Length);
    
    print array values
    for(int k = 0; k < fruits.Length; k++) {
      foreach (string fruit in fruits) {
        Console.WriteLine(fruits[k]);
      }  
    }
    
    //Reading Values into an array and reversing the values
    //*****************************************************************************************************************************************
    int i, n;
    int[] a = new int[100];

    Console.Write("\n\nRead n number of values in an array and display it in reverse order:\n");
    Console.Write("------------------------------------------------------------------------\n");

    Console.Write("Input the number of elements to store in the array :");
    n = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input {0} number of elements in the array :\n", n);
    for (i = 0; i < n; i++) {
      Console.Write("element - {0} : ", i+1);
      a[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.Write("\nThe values store into the array are : \n");
    for (i = 0; i < n; i++) {
      Console.Write("{0}  ", a[i]);
    }

    Console.Write("\n\nThe values store into the array in reverse are :\n");
    for (i = n - 1; i >= 0; i--) {
      Console.Write("{0} ", a[i]);
    }
    Console.Write("\n\n");

    //End Reading Values into an array and reversing the values
    //*****************************************************************************************************************************************
    Console.ReadKey();
  }
}