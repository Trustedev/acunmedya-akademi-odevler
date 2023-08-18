//Can be written more effectively
int numberFirst;
int numberSecond;
int userAnswer;
int isFinished = 0;

while (isFinished == 0) { //main while start

    

do //get first num
{
        
Console.Write("İLK: 1 BASAMAKLI TAMSAYIYI GİRİN: ");
numberFirst = int.Parse(Console.ReadLine());

if (numberFirst > 9 || numberFirst < -9)
{
Console.WriteLine("HATA: GİRİLEN SAYI 1 BASAMAKLI TAMSAYI DEĞİL!");
}
}
while (numberFirst > 9 || numberFirst < -9);
    
do //get second num
{

    Console.Write("İKİNCİ: 1 BASAMAKLI TAMSAYIYI GİRİN: ");
    numberSecond = int.Parse(Console.ReadLine());

    if (numberSecond > 9 || numberSecond < -9)
    {
        Console.WriteLine("HATA: GİRİLEN SAYI 1 BASAMAKLI TAMSAYI DEĞİL!");
    }
}
while (numberSecond > 9 || numberSecond < -9);


do//ask question and get answer
{
        
    Console.Write("SORU: " + numberFirst + " çarpı " + numberSecond + " nedir? \n" );
    userAnswer = int.Parse(Console.ReadLine());

    if (userAnswer != numberFirst * numberSecond)
    {
        Console.WriteLine("HATA: Yanlış cevap, tekrar dene!");
    }
    
}
while (userAnswer != numberFirst * numberSecond);

    Console.WriteLine("Devam edelim mi? 0 = evet / 1 = hayır");
    isFinished = int.Parse(Console.ReadLine());    

}//main while end