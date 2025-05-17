
using System.Text;

InvertString();

void InvertString()
{
    string txt = "Isto é um texto!";
    StringBuilder auxtxt = new StringBuilder();

    for (int i = txt.Length - 1; i >= 0; i--)
    {
        auxtxt.Append(txt[i]);
    }

    Console.WriteLine(auxtxt.ToString());
}