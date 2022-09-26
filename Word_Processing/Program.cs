//      Работа с текстом
// Дан текс. В тексте нужно все пробелы заменить черточками, 
// мелкие буквы "к" заменить большими "К", а большие "С" заменить маленикими "с".
// Текст: - Я думаю, - сказал князь, улыбаясь, - что,
// ежели бы вас послали вместо нашего милого Винценгероде,
// вы бы взяли приступом согласие русского короля.
// Вы так красноречивы. Вы дадите мне чаю? 

string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие русского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwerty"
//             012345
// s[3] = r  s[5] = y  и тд
string Replace(string text, char Old_version, char New_version)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == Old_version) result = result + $"{New_version}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string New_Text = Replace(text, ' ', '|');
Console.WriteLine( New_Text );
Console.WriteLine();
New_Text = Replace(New_Text, 'к', 'К');
Console.WriteLine( New_Text );
System.Console.WriteLine();
New_Text = Replace(New_Text, 'С', 'с');
Console.WriteLine( New_Text );

