//1st Task

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());

// if (number % 7 == 0 && number % 23 == 0){
//     Console.WriteLine($"{number} является числом, кратным 7 и 23");
// }else{
//     Console.WriteLine($"{number} НЕ является числом, кратным 7 и 23");
// }

// 2nd Task

// Console.Write("Введите координаты точки Х: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координаты точки Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if(x == 0 || y == 0){
//     System.Console.WriteLine("Для получения координатной четверти ни одна из точек не может находиться на оси, т.е. иметь значение 0");
// }else{
//     if(x > 0 && y > 0){
//         System.Console.WriteLine("1");
//     } else if(x > 0 && y < 0){
//         System.Console.WriteLine("4");
//     } else if(x < 0 && y < 0){
//         System.Console.WriteLine("3");
//     } else if(x < 0 && y > 0){
//         System.Console.WriteLine("2");
//     }
// }

//3rd Task

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if( number > 9 && number < 100){
    int leftDigit = number / 10;
    int rightDigit = number % 10;
    if( leftDigit > rightDigit){
        System.Console.WriteLine(leftDigit);
    }else{
        System.Console.WriteLine(rightDigit);
    }
} else {
    System.Console.WriteLine("Введите число в диапазоне от 10 до 99 включительно");
}
