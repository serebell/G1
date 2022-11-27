Console.WriteLine("Введите первое число");  
int firstNum = Convert.ToInt32(Console.ReadLine());  
Console.WriteLine("Введите второе число");  
int secondNum = Convert.ToInt32(Console.ReadLine()); 
if (firstNum>secondNum){  
    Console.WriteLine($"max = {firstNum}");  
} 
else {  
    Console.WriteLine($"max = {secondNum}");  
}
