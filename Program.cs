/*
Console.Write("Введите числа через запятую: ");
int[] numbers = StringToNum(Console.ReadLine());
PrintArray(numbers);
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"количество значений больше 0 = {sum}");


int[] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ',')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}


void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}
*/

Console.WriteLine("Введите через запятую целые числа и нажмите Enter");
    string[] nums = Console.ReadLine().Split(new char[] { ',' });
        int[] intArray = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                intArray[i] = int.Parse(nums[i]);
            }
            Console.WriteLine("Неотсортированный массив:");
            foreach (int value in intArray)
            {
                Console.Write($"{value} ");
            }
            int indx; 
            for (int i = 0; i < intArray.Length; i++) 
            {
                indx = i;  
                for (int j = i; j < intArray.Length; j++)
                {
                    if (intArray[j] < intArray[indx])
                    {
                        indx = j; 
                    }
                }
                if (intArray[indx] == intArray[i]) 
                    continue;
                
                int temp = intArray[i]; 
                intArray[i] = intArray[indx];
                intArray[indx] = temp;
            }
            Console.WriteLine("\r\nОтсортированный массив:");
            foreach (int value in intArray)
            {
                Console.Write($"{value} ");
            }
        
    
