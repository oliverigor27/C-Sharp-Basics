using System;

public class HelloWorld
{
    static int search(int[] arr, int data)
    {
        int average;
        int min = 0;
        int max = arr.Length - 1;
        
        do        
        {
            average = (int)(min+max) / 2;
            
            if(arr[average] == data) 
            {
                return average;
            } else if(data > arr[average]) 
            {
                min = average + 1;
            } else {
                max = average - 1;
            }
        }
        
        while(min <= max);
        
        // it will return if the code cannot found out the data. 
        return -1;
    }
    
    public static void Main(string[] args)
    {
        int[] vet = {1,2,3,4,5,6,10,16,19,25,27,30};
        
        Console.WriteLine(search(vet, 4));
    }
}