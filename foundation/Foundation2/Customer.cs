public class Customer {
    private string _name;
    private Address _address;

    public Customer(string name, Address address){
        _name = name;
        _address = address;
    }

    public bool IsInUSA(){
        return _address.IsUSA();
    }

    public List<string> GetShippingText(){
        List<string> result = new List<string>{$"{_name}", _address.GetAddressText()};
        return result;
    }
}