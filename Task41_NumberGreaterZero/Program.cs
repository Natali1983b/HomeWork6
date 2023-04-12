// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

int [] array = {1, -7, 568, 89, 223, -10, 120, 5, -35, -91, 1023};

int Solution(int [] array)
{
    int result = 0; 
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            result += 1;          
        }        
    }    
    Console.WriteLine(result);
    return result;    
}

Solution(array);