using System.ComponentModel.Design.Serialization;

public class Product {
    private String _name;
    private String _id;
    private Double _price;
    private int _quantity;

    public Product(String name, String id, Double price, int quantity){
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }
    public double GetPrice(){
        double cost = Convert.ToDouble(_price*_quantity);
        return cost;
    }

    public String GetName(){
        return _name;
    }
    public String GetId(){
        return _id;
    }
}