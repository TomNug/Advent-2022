using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    string[] lines = System.IO.File.ReadAllLines(@"input.txt");
    
    List<int> calories = new List<int>();

    foreach (string line in lines){
      if(line.Length > 0) {
        calories.Add(Int32.Parse(line));
      } else {
        calories.Add(-1);
      }
    }
    int[] caloriesArr = calories.ToArray();

    int highestCalories = 0;
    int runningTotal = 0;
    foreach (int calorie in caloriesArr) {
      if (calorie == -1){
        if (runningTotal > highestCalories) {
          highestCalories = runningTotal;
        }
        runningTotal = 0;
      }else {
          runningTotal += calorie;
      }
    }
    
    Console.WriteLine(highestCalories);
    
    





    
    // Keep the console window open in debug mode.
    Console.WriteLine("Press any key to exit.");
    System.Console.ReadKey();
  }
}