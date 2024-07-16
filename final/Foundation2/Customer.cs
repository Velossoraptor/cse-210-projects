public class Customer {
    private String _name;
    private Address _address;

    public Customer(String name, Address address){
        _name = name;
        _address = address;
    }
    public bool isInUSA(){
        if(_address.IsInUSA()){
            return true;
        }else{
            return false;
        }
    }

    public String GetName(){
        return _name;
    }

    public String GetAddress(){
        return _address.GetString();
    }
}