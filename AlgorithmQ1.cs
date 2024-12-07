namespace Algorithm
{
    public class AlgorithmClassb
    {
        public static void AlgorithmQ1()
        {
            PrintVowelPosition();
            static void PrintVowelPosition()
            {
                string s = "Hello WORLD";
                List<int> results = GetVowelPosition(s);
                string finalResult = "";
                for(int i = 0; i < results.Count; i++)
                {
                    finalResult += results[i] + ",";
                }

                Console.WriteLine(finalResult);
            }
            static List<int> GetVowelPosition(string s)
            {
                List<int> vowelsLocation = new List<int>();
                char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
                for (int i = 0; i < s.Length; i++)
                {
                    foreach (char vowel in vowels)
                    {
                        if (s[i] == vowel)
                        {
                            vowelsLocation.Add(i);
                        }
                    }
                }
                return vowelsLocation;
            }
        }

        // Question2============
        public static void AlgorithmQ2()
        {
            PrintShiftedLetters();
            static void PrintShiftedLetters()
            {
                string inputLetters = "abc123XYz!";
                string adjustedLetters = ShiftLetters(inputLetters);
                Console.WriteLine(adjustedLetters);
            }
            static string ShiftLetters(string inputString)
            {
                
                char[] shiftCharacter = new char [inputString.Length];
                for (int i = 0; i < inputString.Length; i++)
                {
                    char currentCharacter = inputString[i];
                    if (currentCharacter >= 'a' && currentCharacter <= 'z')
                    {
                        if (currentCharacter == 'a')
                        {
                            shiftCharacter[i] = 'z';
                        }
                        else
                        {
                            shiftCharacter[i] = (char)(currentCharacter - 1);
                        }
                    }
                    else if (currentCharacter >= 'A' && currentCharacter <= 'Z')
                    {
                        if (currentCharacter == 'A')
                        {
                            shiftCharacter[i] = 'Z';
                        }
                        else
                        {
                            shiftCharacter[i] = (char)(currentCharacter - 1);
                        }
                    }
                    else {
                        shiftCharacter[i] = currentCharacter;
                    }
                }
                return new string(shiftCharacter);
            }
        }


        // Question 3
        public static void AlgorithmQ3()
        {
            PrintManipulateLetters();
            static void PrintManipulateLetters()
            {
                string word = "HelLo WoRlD!,";
                string changedLetters = manipulateLetters(word);
                Console.WriteLine(changedLetters);
            }
            static string manipulateLetters(string inputString)
            {
                char[] manipulateCharacter = new char [inputString.Length];
                for (int i = 0; i < inputString.Length; i++)
                {
                    char currentCharacter = inputString[i];
                    if (currentCharacter >= 'a' && currentCharacter <= 'z')
                    {
                        if (currentCharacter == 'z')
                        {
                            manipulateCharacter[i] = 'a';
                        }
                        else
                        {
                            manipulateCharacter[i] = (char)(currentCharacter - 32);
                        }

                    }
                    else if (currentCharacter >= 'A' && currentCharacter <= 'Z')
                    {
                        if (currentCharacter == 'z')
                        {
                            manipulateCharacter[i] = 'a';
                        }
                        else
                        {
                            manipulateCharacter[i] = (char)(currentCharacter + 32);
                        
                        }

                    }
                    else 
                    {
                        manipulateCharacter[i] = currentCharacter;
                    }
                }
                return new string(manipulateCharacter);
            }
        }
    }
}