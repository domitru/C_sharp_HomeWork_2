 Console.WriteLine("Введите трёхзначное число: ");
 int a = Convert.ToInt32(Console.ReadLine());

 if (a/100 > 9)
 {
     Console.Write("Введеное число не трехзначное.");
 }
 else
 {
     Console.WriteLine($"Вторая  цифра этого числа: {(a%100-a%10)/10}");
 }