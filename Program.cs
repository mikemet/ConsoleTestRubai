Console.WriteLine("Hello!");

List<string> lstRubai = [];

FileStream fileStream = new("testRubai.csv", FileMode.Open);
StreamReader sr = new(fileStream);

while (!sr.EndOfStream)
{
    lstRubai.Add(sr.ReadLine());
}

int countVal = lstRubai.Count();

Random rnd  = new();
int rIndex = rnd.Next(lstRubai.Count);

sr.Close();
fileStream.Close();

