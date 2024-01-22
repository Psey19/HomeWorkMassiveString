//Задача №1
// char[,] Array2D = new char[,]
// {
//     {'a', 'b', 'c'},
//     {'d', 'e', 'f'}
// };

// string GetStringFromChar(char [,] Array)
// {
//     string str = "";
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             str += Array[i, j];
//         }
//     }
//     return str;
// }

// string res = GetStringFromChar(Array2D);
// Console.WriteLine(res);


//Задача №2
// string str = "aBcD1ef!-";
// Console.WriteLine(str.ToLower());


//Задача №3
// string str = "шалаш";

// void ShowPalin(string Str)
// {
//     int count = 0;
//     for (int i = 0; i < Str.Length / 2; i++)
//     {
//         if (Str[i] == Str[Str.Length - 1 - i])
//         {
//             count++;
//         }
//     }
//     if (count == Str.Length / 2)
//     {
//         Console.WriteLine("Yes");
//     }
//     else{
//         Console.WriteLine("No");
//     }
// }


// ShowPalin(str);



//Задача №4

string ReverseWords(string str2)
{
string[] Words = str2.Split(' ');
Array.Reverse(Words);
return string.Join(" ", Words);}

string str = "Hello My World";
Console.WriteLine(ReverseWords(str));
