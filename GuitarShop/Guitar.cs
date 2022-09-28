public class Guitar {
    private string serialNumber;
    private double price;
    private GuitarSpec spec;

    public Guitar(string serialNumber,
     double price,
     GuitarSpec spec) {
        this.serialNumber = serialNumber;
        this.price = price;
        this.spec = spec;
    }

    public string GetSerialNumber() {
        return this.serialNumber;
    }

    public double GetPrice() {
        return this.price;
    }

    public void SetPrice(double newPrice) {
        this.price = newPrice;
    }

    public GuitarSpec GetGuitarSpec() {
        return this.spec;
    }

}