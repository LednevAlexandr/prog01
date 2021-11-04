// Вид 1

void Method1()
{
    Console.WriteLine("Автор...");
}

// Вид 2

void Method2(string msg, int count)
{
    int i=0;
    while (i<count)
    {
       Console.WriteLine(msg);    
       i++; 
    }
}

//Вид 3

int Method3()
{
    return DateTime.Now.Year;

}

int year = Method3();
Console.WriteLine(year);

//Вид 4
// string Method4(int count, string c)
// {
    // int i=0;
    // string result = string.Empty;
// 
    // while (i<count)
    // {
        // result = result + c;
        //  i++;
    // }
    // return result;
// }
// 
// String res = Method4(4, "текст");
// Console.WriteLine(res);

//Вид 4
 string Method4(int count, string c)
 {
     int i=0;
     string result = string.Empty;
 
     for(i=0;i<count;i++)
     {
         result = result + c;
     }
     return result;
     }
 
 String res = Method4(4, "текст");
 Console.WriteLine(res);