int[] myList = new int[5]; 

for(int i = 0; i < myList.Length; i++){
    Console.WriteLine((i+1) + "/" + myList.Length + " sayı girişi yapın: ");
    myList[i] = int.Parse(Console.ReadLine());
}
int numMax = myList[0], numMin = myList[0];
for (int i = 0; i < myList.Length; i++){
    if (myList[i] > numMax)
    {
        numMax = myList[i];
    }
}
for (int i = 0; i < myList.Length; i++){
    if (myList[i] < numMin){
        numMin = myList[i];
    }
}
Console.WriteLine("Listedeki en küçük sayı: " + numMin + "\nListedeki en büyük sayı: " + numMax);

