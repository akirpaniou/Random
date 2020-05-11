## My C# file with random.
***This file I created on the lesson***
### Also in the file there is a bubble sort
```int temp;
             Console.WriteLine("Bubble sort: ");
             for (int i = 0; i < x.Length; i++)
             {
                 for(int j = i + 1;j < x.Length; j++)
                 {
                     if(x[i] > x[j])
                     {
                         temp = x[i];
                         x[i] = x[j];
                         x[j] = temp;
                     }
                 }
             }
