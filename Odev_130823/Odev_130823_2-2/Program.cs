
//Decrypt function
static int decryptData(int cryptDataIncoming)
{
    string cryptData = cryptDataIncoming.ToString();
    int[] decDigits = new int[4];
    decDigits[0] = int.Parse(cryptData[2].ToString());
    decDigits[1] = int.Parse(cryptData[3].ToString()); // when i input 1634 it threw array out of bounds error
    decDigits[2] = int.Parse(cryptData[0].ToString());
    decDigits[3] = int.Parse(cryptData[1].ToString());

    for (int i = 0; i < 4; i++)
    {
        decDigits[i] = (decDigits[i] - 7 + 10) % 10;
    }

    int decData = decDigits[0] * 1000 + decDigits[1] * 100 + decDigits[2] * 10 + decDigits[3];
    return decData;
}

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
Console.WriteLine("Şifre çözüldü, veri: " + decryptData(commData));