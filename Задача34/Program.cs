/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

// заполняем массив 
int[] InitArray(int length) 
{     
    int[] array = new int[length];     
    Random rnd = new Random();    
    for (int i = 0; i < length; i++)    
    {         
        array[i] = rnd.Next(100,1000);     
    }      
    return array; 
}  
// кол-во четных чисел в массиве
int Count(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] % 2 == 0)                   
        count++;
    }
    return count;
}
//печатает массив на экран     
void PrintArray(int[] array) 
{     
    Console.Write("["); 
    for (int i = 0; i < array.Length; i++)     
        {        
          Console.Write($"{array[i]}, ");     
        }     
        Console.Write("]"); 
    Console.WriteLine(); 
} 

int [] array = InitArray(5);
PrintArray(array);
int count = Count(array);
Console.WriteLine();
Console.WriteLine($"Данная цифра {Count(array)} -> это кол-во чётных чисел в нашем массиве");  

