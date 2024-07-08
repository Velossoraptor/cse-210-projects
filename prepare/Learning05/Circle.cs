public class Circle : Shape {
    private Double _radius = 0;

    public Circle(String color, Double radius){
        _radius = radius;
        SetColor(color);
    }
    public override double GetArea()
    {
        return Math.PI*(_radius*_radius);
    }
}