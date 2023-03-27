abstract class Figura
{
    public int x {get;set;} 
    public int y {get;set;}
    public int l {get;set;}
    public int a {get;set;}
    public string color {get;set;}

    public Figura(int x, int y, int l, int a, string c)
    {
        
        this.x=x;
        this.x=y;
        this.a=a;
        this.l=l;
        this.color=c;
    }

    public abstract void Dibuja();
    public abstract void Area();
}
public class Rectangulo
{
    
}
class Circulo : Figura
{
    public double diametro {get; set;}
    public Circulo (int x, int y, int l, int a, string c, int d)
    :base(x, y, l, a, c)
    {
        diametro = d;
    }
    public override void Dibuja()
    {
        Console.WriteLine($"se dibuja un circulo");
    }
    public override double Area();
    {
        return Math.Pow(diametro/2,2);
    }
}
public class Triangulo
{
    public class Dibuja()
    {
        Console.writeLine()
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        
    }
}