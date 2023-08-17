using System.Reflection.Metadata;
using System.Text;


//Encrypt function
static int encryptData(int dataIncoming)
{    
    string dataString = dataIncoming.ToString();
    int[] dataDigits = new int[4];
    for (int i = 0; i < 4; i++)
    {
        dataDigits[i] = (int.Parse(dataString[i].ToString()) + 7) % 10;
    }
    int dataEncrypted = dataDigits[2] * 1000 + dataDigits[3] * 100 + dataDigits[0] * 10 + dataDigits[1];
    return dataEncrypted;
}




// Get user input and validate it has 4 digits then print out encrypted data
int commData;
do
{
 
    Console.Write("4 BASAMAKLI TAMSAYI VERI GIRİŞİ YAPIN: ");
    commData = int.Parse(Console.ReadLine());
    
    if (commData > 9999 || commData < 1000)
    {
        Console.WriteLine("HATA: GİRİLEN SAYI 4 BASAMAKLI TAMSAYI DEĞİL!");
    }
}
while (commData > 9999 || commData < 1000);
Console.WriteLine("Şifreli veri: " + encryptData(commData));



