string[] arrStrings = File.ReadAllLines("testRubai.csv");

Random rnd = new();
int mIndex = rnd.Next(arrStrings.Length);

if (mIndex >= arrStrings.Length - 3)
{
    mIndex = arrStrings.Length - 4;
}

while (mIndex % 4 != 0)
{
    mIndex++;
}

string str = arrStrings[mIndex];
Console.WriteLine(str);

for (int i = 0; i < 3; i++)
{
    mIndex++;
    Console.WriteLine(arrStrings[mIndex]);
}


Console.WriteLine();
Console.WriteLine("End of programm. Press any key...");
_= Console.ReadLine();