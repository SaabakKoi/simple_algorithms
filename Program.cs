Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0){
    Console.WriteLine($"{number} является числом, кратным 7 и 23");
}else{
    Console.WriteLine($"{number} НЕ является числом, кратным 7 и 23");
}
