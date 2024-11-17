
List<string> lstRubai = [];

FileStream fileStream = new("testRubai.csv", FileMode.Open);
StreamReader sr = new(fileStream);

while (!sr.EndOfStream)
{
    lstRubai.Add(sr.ReadLine());
}

//int countVal = lstRubai.Count();    // для справки

Random rnd = new();
int rIndex = rnd.Next(1, lstRubai.Count);

sr.Close();
fileStream.Close();

string str = lstRubai[rIndex - 1];

//Console.WriteLine(countVal);
Console.WriteLine(rIndex);
Console.WriteLine(str);