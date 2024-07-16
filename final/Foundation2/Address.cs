using System.Runtime.CompilerServices;

public class Address {
    private String _street;
    private String _city;
    private String _province;
    private String _country;

    public Address(String street, String city, String province, String country){
        _street = street;
        _city = city;
        _province = province;
        _country = country;
    }
    public bool IsInUSA(){
        if(_country == "USA"){
            return true;
        }else{
            return false;
        }
    }

    public String GetString(){
        return $"{_street}\n{_city}, {_province}\n{_country}";
    }
}