using Microsoft.VisualBasic;


int counter = 0;
DateTime startTime = DateTime.Now;

while(counter <= 3000000)
{
    if(counter % 1000000 == 0 && counter != 0)
    {        
        Console.WriteLine(counter + "\n" + ((DateTime.Now - startTime)/60).TotalMilliseconds + " saniyede tamamlandı.\n"); 
    }
    counter += 1;
}
