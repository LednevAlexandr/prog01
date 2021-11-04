
//Таблица умножения
//for (int i=2; i<=10;i++)
//{
  //for (int j = 2; j <=10; j++)
  //{
    //  Console.WriteLine($"{i} x {j} = {i*j}");

  //}
  //Console.WriteLine();
//}

//Дан текст . В тексте нужно все пробнлы заменит черточками,
// маленькие буквы "к" заменить юольшими "К", а юольшие "С" заменить маленькими "с".
string text = "Я думаю,- сказал князь, улыбаясь, - что, "
            +"ежели бы вас послали вместо нашего милого Винценгероде, "
            +"вы бы взяли приступом согласие прусского короля. "
            +"Вы так красноречивы. Вы дадите мне чаю?";

string Replaxe(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue)  result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replaxe(text,' ','|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replaxe(newText,'к','К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replaxe(newText,'с','С');
Console.WriteLine(newText);
