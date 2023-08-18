int[] myList = new int[10] {5, 2, 5, 3, 1, 9, 9, 6, 5, 2};
int[] pureList = new int[10];
int counter = 0; //counts the amount of numbers in purelist
foreach (int i in myList){
    if(!pureList.Contains(i)){        
        pureList[counter] = i;
        counter++;
    }}
Console.WriteLine("Orjinal liste: ");
for (int i = 0; i < myList.Length; i++){   
    Console.Write(myList[i] + " ");
}
Console.WriteLine("\n Düzenlenmiş liste: ");
for (int i = 0; i < counter; i++){    
Console.Write(pureList[i] + " ");
}