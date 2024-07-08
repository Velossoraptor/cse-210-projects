public class Square : Shape {
    private Double _side = 0;

    public Square(String color, Double side){
        _side = side;
        SetColor(color);
    }
    public override double GetArea()
    {
        return _side*_side;
    }
}