using System.Runtime.Intrinsics.Arm;

public class Address {
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country){
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsUSA(){
        bool domestic;
        if(_country == "USA"){
            domestic = true;
        }else {
            domestic = false;
        }
        return domestic;
    }

    public string GetAddressText(){
        return $"{_street}, {_city}, {_state}, {_country}";
    }
}