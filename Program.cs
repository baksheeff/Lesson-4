using System.Diagnostics.CodeAnalysis;
using System.IO.Compression;

void Task1(){
    Console.Clear();
    Console.WriteLine("Задача 1:");
    Console.WriteLine("Введите целое число:");

    while (true){
        String? str = Console.ReadLine();
        
        if (str == "q"){
            Console.WriteLine("Вы ввели 'q'. Работа метода завершена.");
            break;
        }
        if (!int.TryParse(str, out int number)){
            Console.WriteLine("Вы ввели не число, или число, но не целое.");
            continue;
        }

        int quantity = 0, temp = number, sum = 0;

        Console.WriteLine($"ваше число  = {number }");

        while(temp > 0){
            temp/=10;
            quantity++;
        }

        int num = number;
        for (int i = 0; i < quantity; i++){
            int pow = Convert.ToInt32(Math.Pow(10, quantity - 1 - i));


            sum += num / pow;
            num %= pow;
        }

        if (sum % 2 == 0 ){
            Console.WriteLine($"Сумма цифр числа {number} = {sum} - число чётное. Завершение работы метода.");
            break;
        } else {
             Console.WriteLine($"Сумма цифр числа {number} = {sum} - число нечётное. Введите новое число.");
        }
    }
    Console.WriteLine("Нажмите ENTER для выхода.");
    Console.ReadLine();
}

int[] ArrayCreation(int min, int max){
    int size = new Random().Next(5, 10);

    int[] array = new int[size];
    

    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(min, max);
    }

    return array;
}

void Task2(){
    Console.Clear();
    Console.WriteLine("Задача 2:");

    int count = 0;
    int[] array = ArrayCreation(100, 1000); // трехзначные числа принадлежат [100, 1000)

    Console.WriteLine("Получаем случайный массив из " + array.Length + " элементов  - array = [" + string.Join(", ", array) + "]");

    foreach (int elem in array){
        if (elem % 2 == 0){
            count++;
        }
    }
    Console.WriteLine($"Количество чётных элементов в массиве = {count}.");
    Console.WriteLine("Нажмите ENTER для выхода.");
    Console.ReadLine();
}

void Task3(){
    Console.Clear();
    Console.WriteLine("Задача 3:");

    int[] array = ArrayCreation(10, 100);
    int tmp;

    Console.WriteLine("Получаем массив [" + string.Join(", ", array) + "]");

    for (int i = 0; i < array.Length/2; i++){
        tmp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tmp;
    }

    Console.WriteLine("развернутый массив [" + string.Join(", ", array) + "]");
    Console.WriteLine("Нажмите ENTER для выхода.");
    Console.ReadLine();
}


while (true){
    Console.Clear();
    Console.WriteLine("Список задач:");
    Console.WriteLine("Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ " + 
    "или при вводе числа, сумма цифр которого чётная.");
    Console.WriteLine("Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
    Console.WriteLine("Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)");
    Console.WriteLine("Введите номер задачи, которую хотите запустить или введите exit для выхода:");
    String? str = Console.ReadLine();
    int [] array = {0, 1, 2, 3};

    if (str != null && (str.Equals("exit") || str.Equals("EXIT"))){
        Console.WriteLine("Завершение работы программы");
        break;
    }

    if (!int.TryParse(str, out int num)){
        Console.WriteLine("Вы ввели не число.");
        Console.WriteLine("Нажмите ENTER для выхода.");
        Console.ReadLine();
        continue;
    } 

    if (!array.Contains(num)){
        Console.WriteLine("Введите корректный номер задачи");
        Console.WriteLine("Нажмите ENTER для выхода.");
        Console.ReadLine();
        continue;
    }
    
    switch (num){
        case 0: 
            break;
        case 1:
            Task1();
            break;
        case 2:
            Task2();
            break;
        case 3:
            Task3();
            break;
    }

}