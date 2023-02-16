 // Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
        Console.WriteLine("Введите первое число: ");
        int numberA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        int numberB = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Наибольшее число равно:");
        if (numberA > numberB)
        {
            Console.WriteLine(numberA);
        }
        else
        {
            Console.WriteLine(numberB);
        } 