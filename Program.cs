// Sort Analyzer Start Code
using System;
using System.IO;
using System.Diagnostics;

class MainClass {
    static int insertionSort(int[] anArray){
        for (int i=1; i<anArray.Length; i++){
            int insert_value = anArray[i];
            int position = i-1;
            while(position >= 0 && anArray[position] > insert_value){
                anArray[position+1] = anArray[position];
                position = position - 1;
            }
            anArray[position+1] = insert_value;
        }
    return 0;
}
    public static void Main (string[] args) {
        // LOAD DATA FILES INTO ARRAYS
        int[] randomData = loadDataArray("data-files/random-values.txt");
        int[] reversedData = loadDataArray("data-files/reversed-values.txt");
        int[] nearlySortedData = loadDataArray("data-files/nearly-sorted-values.txt");
        int[] fewUniqueData = loadDataArray("data-files/few-unique-values.txt");

        // EXAMPLE OF TIMING DURATION OF A SORT ALGORITHM
        var timer = new Stopwatch();
        timer.Start();
        insertionSort(fewUniqueData);
        timer.Stop();
        Console.WriteLine($"Bubble Sort Random Data: {timer.Elapsed}");
    }


    // Function to create an array of integers from provided data file
    public static int[] loadDataArray(string fileName) {
        // Read Text File by Line 
        string[] lines = File.ReadAllLines(fileName);

        // Create Array of Integers
        int[] tempData = new int[lines.Length];
        for (int i = 0; i < lines.Length; i++) {
            tempData[i] = Convert.ToInt32(lines[i]);
        }

        // Return Array of Integers
        return tempData;
    }
    
    public static void printIntArray(int[] array, int start, int stop) {
        // Print out array elements at index values from start to stop 
        for (int i = start; i < stop; i++) {
            Console.WriteLine(array[i]);
        }
    }

}
