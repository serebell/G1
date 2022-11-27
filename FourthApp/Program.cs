Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
string output = "";
int currentEvenNum = 2;
while(currentEvenNum<=num){ 
    if(currentEvenNum == 2){ 
        output = "2"; 
        currentEvenNum = currentEvenNum + 2; 
        continue; 
    } 
    output = output+$", {currentEvenNum}";
    currentEvenNum=currentEvenNum+2;
}
Console.WriteLine(output);