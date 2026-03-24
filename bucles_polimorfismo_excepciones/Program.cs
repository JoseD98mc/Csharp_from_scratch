
var circ=new Circulo();
circ.Radio=20;
var result_area=circ.Area();
var result_perimetro=circ.Perimetro();

Console.WriteLine($"El area es: {result_area} y el perimetro es: {result_perimetro}");

abstract class Figura
{
    public abstract double Area();

    public abstract double Perimetro();
}

class Circulo : Figura
{
    public double Radio {get; set;}

    public override double Area() =>Math.PI*Radio*Radio;
    public override double Perimetro() => 2*Math.PI*Radio;
        
}


