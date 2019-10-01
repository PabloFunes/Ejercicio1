using System;

public class CalculadoraDeAreas
{
	public CalculadoraDeAreas()
	{
	}

    public double AreaCuadrado(double Lado)
    {
        return Math.Pow(Lado, 2);
    }

    public double AreaCirculo(double RadioCircunf)
    {
        const double NumPi = Math.PI;
        return (NumPi * (Math.Pow(RadioCircunf, 2)));

    }

    public double AreaTriangulo(double BaseTriangulo, double AlturaTriangulo)
    {
        return ((BaseTriangulo * AlturaTriangulo) / (2));
    }

    public double AreaRectangulo(double AlturaRectangulo,double BaseRectangulo)
    {
        return (AlturaRectangulo * BaseRectangulo);
    }

}
