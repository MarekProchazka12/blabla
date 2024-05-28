using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;


class Program
{
    public delegate void Delegatos(int x);
    public static void Vec1(int x) => Console.WriteLine(x*2);
  
    public static void Vec2(int x) => Console.WriteLine(x*3);
    
    static void Main(string[] args)
    {
        Delegatos delegat = new Delegatos(Vec1);
        delegat += Vec2;
        delegat(2);




        //SPOJOVY SEZNAM
        /*Spojovy_seznam spojak = new Spojovy_seznam();
        spojak.AddNaZacatek(5);
        spojak.AddNaZacatek(4);
        spojak.AddNaZacatek(3);
        Console.WriteLine(spojak.ToString());*/
    }
}
class Spojovy_seznam
{
    public Node first = null;
    public Node last = null;

    public void AddNaZacatek(int v)
    {
        Node novy = new Node();
        novy.value = v;
        if(first == null)
        {
            novy.next = null;
            first = novy;
            last = novy;
            return;
        }
        novy.next = first;
        first = novy;
    }

    public override string ToString()
    {
        Node aktualni = first;
        string celek = "";
        while(true)
        {
            if(aktualni.next == null)
            {
                celek += $"{aktualni.value},";
                return (celek);
            }
            else
            {
                celek += $"{aktualni.value},";
                aktualni = aktualni.next;
            }
        }
    }
}
class Node
{
    public int value;
    public Node next;
}