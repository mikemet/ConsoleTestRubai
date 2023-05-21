using System.ComponentModel;

List<string> list = new List<string>();

FileStream fileStream = new FileStream("testRubai.csv", FileMode.Open);
StreamReader sr = new StreamReader(fileStream);

while (!sr.EndOfStream)
{
    list.Add(sr.ReadLine());
}

sr.Close();
fileStream.Close();

Random rnd = new Random();
int mIndex = rnd.Next(list.Count);

if (mIndex >= list.Count - 3)
{
    mIndex = list.Count - 4;
}

while (mIndex % 4 != 0)
{
    mIndex++;
}
string str = list[mIndex];
List<string> result = new List<string>
{
    str
};

for (int i = 0; i < 3; i++)
{
    mIndex++;
    result.Add(list[mIndex]);
}

foreach (var item in result)
{
    Console.WriteLine(item);
}

Console.WriteLine();
Console.WriteLine("End of programm. Press any key...");
_= Console.ReadLine();