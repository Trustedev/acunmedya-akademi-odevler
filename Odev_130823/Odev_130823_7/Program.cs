using System;

static bool IsPrime(int num) { 
if (num <= 1)
    return false;

if (num <= 3)
    return true;

if (num % 2 == 0 || num % 3 == 0)

    return false;
for (int i = 5; i * i <= num; i += 6)
{
    if (num % i == 0 || num % (i + 2) == 0)
        return false;
}
return true;
}

int[] myList = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 13};
int sumPrime = 0;

foreach (int i in myList){
    if(IsPrime(i)){
        sumPrime += i;
    }}

Console.WriteLine("Sayı listesi: ");
for (int i = 0; i < myList.Length; i++)
{
    Console.Write(myList[i] + " ");
}
Console.WriteLine("\nİçindeki asal sayıların toplamı: " + sumPrime);