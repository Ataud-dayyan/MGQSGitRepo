// Console.WriteLine("Enter text of choice: ");
// string text = Console.ReadLine()!;
// Console.Clear();

// string result = ManipulateString(text);
// Console.WriteLine("{0}\n{1}\n{2}\n{3}", text, text.Length, result, result.Length);

// string ManipulateString(string str)
// {
//     string[] splitedStrs = str.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
//     string[] manipulatedStrs = new string[splitedStrs.Length];
//     int counter = 0;

//     foreach (string splitStr in splitedStrs)
//     {
//         if (splitStr.Length >= 5)
//         {
//             string reversedWord = ReverseString(splitStr);
//             manipulatedStrs[counter++] = reversedWord;
//         }
//         else
//         {
//             manipulatedStrs[counter++] = splitStr;
//         }
//     }

//     return string.Join(' ', manipulatedStrs);
// }

// string ReverseString(string str)
// {
//     int i, j = 0;
//     char[] reversed = new char[str.Length];

//     for (i = str.Length - 1; i >= 0; i--)
//     {
//         reversed[j++] = str[i];
//     }

//     return new string(reversed);
// }