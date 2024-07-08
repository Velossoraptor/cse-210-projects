public class Rectangle : Shape {
    private Double _length = 0;
    private Double _width = 0;

    public Rectangle(String color, Double length, Double width){
        _length = length;
        _width = width;
        SetColor(color);
    }
    public override double GetArea()
    {
        return _length*_width;
    }
}