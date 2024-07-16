public class Order {
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    
    public double GetTotalPrice(){
        double totalCost = 0;
        if(_customer.isInUSA()){
            totalCost += 5;
        }else{
            totalCost += 35;
        }
        foreach(Product product in _products){
            totalCost += product.GetPrice();
        }
        return totalCost;
    }

    public Order(Customer customer){
        _customer = customer;
    }

    public void AddProduct(Product product){
        _products.Add(product);
    }

    public String GetPackingLabel(){
        String label = "";
        foreach (Product product in _products){
            label += $"Product: {product.GetName()}\nID: {product.GetId()}\n";
        }

        return label;
    }
    public String GetShippingLabel(){
        String label = "";
        label += $"{_customer.GetName()}\n{_customer.GetAddress()}";
        return label;
    }
}