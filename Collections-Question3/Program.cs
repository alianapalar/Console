Console.Write("Enter a sentence: ");
string sentence = Console.ReadLine();

char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
List<char> vowelsInSentence = new List<char>();

for (int i = 0; i < sentence.Length; i++)
{
    if (vowels.Contains(sentence[i]))
        vowelsInSentence.Add(sentence[i]);
}

vowelsInSentence.Sort();

Console.WriteLine("Vowels in the sentence: " + string.Join(", ", vowelsInSentence));
