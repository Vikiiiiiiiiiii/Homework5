//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0 

// заполняем массив 
int[] InitArray(int length) 
{     
    int[] array = new int[length];     
    Random rnd = new Random();    
    for (int i = 0; i < length; i++)    
    {         
        array[i] = rnd.Next(-10,20);     
    }      
    return array; 
}  
// сумма элементов массива
int GetSumm(int [] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)                   //нечётная позиция
        summ = summ + arr[i];
    }
    return summ;
}
          
//печатает массив на экран 
void PrintArray(int[] array) 
{     
    for (int i = 0; i < array.Length; i++)     
        {        
          Console.Write($"{array[i]}, ");     
        }     
    Console.WriteLine(); 
} 

int [] arr = InitArray(7);
PrintArray(arr);
int summ = GetSumm(arr);
Console.WriteLine(); 
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {summ}");


