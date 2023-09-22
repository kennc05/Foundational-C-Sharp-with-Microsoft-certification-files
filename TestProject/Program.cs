string pangram = "The quick brown fox jumps over the lazy dog";

string[] pangramArray = pangram.Split(' ');

string[] panagramReversed = new string[pangramArray.Length];

int i = 0;
foreach (string word in pangramArray)
{
	char[] wordArray = word.ToCharArray();
	Array.Reverse(wordArray);
	panagramReversed[i] = String.Join("", wordArray);
	i++;
}

string reversedPangram = string.Join(" ", panagramReversed);

Console.WriteLine(reversedPangram);