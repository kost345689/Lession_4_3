//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Элементы массива вводятся пользователем.


int[] myArray = new int[8];

for (int i = 0; i< 8; i++)
{

Console.WriteLine($"\nВвведите 8 элементов {i}:\t");
myArray[i] = int.Parse(Console.ReadLine());


}

Console.WriteLine("\nВывод массива");

for (int i = 0; i< 8; i++)

{

Console.WriteLine(myArray[i]);

}

Console.ReadLine();