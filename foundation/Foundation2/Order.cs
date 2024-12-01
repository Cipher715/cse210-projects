public class Order {
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer){
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product){
        _products.Add(product);
    }

    public double GetTotalPrice(){
        double price = 0;
        foreach(Product product in _products){
            price += product.GetTotalCost();
        }
        if(_customer.IsInUSA()){
            price += 5;
        }else {
            price += 35;
        }
        return price;
    }

    public List<string> GetPackingLabel(){
        List<string> packingLabel = new List<string>();
        foreach(Product product in _products){
            packingLabel.Add(product.GetProductText());
        }
        return packingLabel;
    }

    public List<string> GetShippingLabel(){
        return _customer.GetShippingText();
    }
} 