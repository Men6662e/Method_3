//Console.WriteLine("Условная конструкция if ; else_if ; else");
//Console.WriteLine("Введите значение:");
//int num1 = Convert.ToInt32(Console.ReadLine());
//if (num1 > 0)
//{
//    Console.WriteLine($"{num1} больше 0-я");
//}
//else if (num1 > 100)
//{
//    Console.WriteLine($"{num1} больше 100-а");
//}
//else if (num1 == 0)
//{
//    Console.WriteLine($"{num1} равно 0-ю");
//}
//else
//{
//    Console.WriteLine($"{num1} меньше 0-я");
//}
//Console.ReadLine();

//Console.WriteLine("Введите время дня:");
//int hour = Convert.ToInt32(Console.ReadLine());

//if (hour >= 6 && hour < 12)
//{
//    Console.WriteLine("Доброе утро!");
//}
//else if (hour >= 12 && hour < 18)
//{
//    Console.WriteLine("Добрый день!");
//}
//else if (hour >= 18 && hour <= 23)
//{
//    Console.WriteLine("Добрый вечер!");
//}
//else if (hour >= 23 && hour == 0)
//{
//    Console.WriteLine("Доброй ночи!");
//}
//else if (hour >= 1 && hour < 6)
//{
//    Console.WriteLine("Доброй ночи!");
//}
//else if (hour == 24)
//{
//    Console.WriteLine("Полночь!");
//}
//else
//{
//    Console.WriteLine("Неправильное число!");
//}

//Console.WriteLine("Начало игры, выбирите один из пунктов\t\n1.Начало игры!\t\n2.Загрузить игру!\t\n3.Выход из игры!");
//main();
//string? game = Console.ReadLine();

//switch (game)
//{
//    case "1":
//        Console.WriteLine("Вход в игру!");
//        break;
//    case "2":
//        Console.WriteLine("Загрузить игру!");
//        break;
//    case "3":
//        Console.WriteLine("Выход из игры!");
//        break;
//}

//void main()
//{
//    Console.WriteLine("______------______");
//}

//void method(string name,int age)
//{
//    Console.WriteLine($"Ваше имя:{name}, Ваш возраст:{age}");
//    if (age > 18)
//    {
//        Console.WriteLine($"{name}, вам больше 18");
//    }
//    else
//    {
//        Console.WriteLine($"{name}, вам меньше 18");
//    }
//}

//method("Viktor", 12);