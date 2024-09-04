StreamReader olvas = new StreamReader("nevek.txt");
while (olvas.EndOfStream)
{
    Console.WriteLine(olvas.ReadLine());
}