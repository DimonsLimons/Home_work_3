/* Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли 
оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да*/

Console.WriteLine("Enter the Number"); 
int Number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(IsPalindrome(Number));        
Console.ReadKey(true);        

static bool IsPalindrome(int Number)      
{
    if (Number >= 0 && Number <10)        
    return true;
    int NumberLength = GetLength(Number);
    int[] digits = new int[NumberLength];
        for (int i = NumberLength - 1; i >= 0; i--) 
        {
            digits[i] = Number % 10;
            Number /= 10;
        }
             for (int i = 0; i < NumberLength/2; i++)
             {
                if (digits[i] != digits[NumberLength - i - 1])
                return false;
             }
            return true;            
}        
               
static int GetLength(int Number)        
{
    int N = 0;
    while (Number > 0)
    {
        Number /= 10;
        N++;
    }
    return N;
 }
    