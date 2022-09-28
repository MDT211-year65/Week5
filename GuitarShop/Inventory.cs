public class Inventory {
    private Guitar[] guitars;

    public Inventory(Guitar[] guitars) {
        this.guitars = guitars;
    }

    public Guitar GetGuitar(string serialNumber) {
        foreach(Guitar guitar in guitars) {
            if (guitar.GetSerialNumber().Equals(serialNumber)) {
                return guitar;
            }
        }

        return null;
    }

     public Guitar GetGuitar(double price) {
        foreach(Guitar guitar in guitars) {
            if (guitar.GetPrice().Equals(price)) {
                return guitar;
            }
        }

        return null;
    } 

    public Guitar Search(Guitar searchGuitar) {
        foreach(Guitar guitar in guitars) { 
            string serialNumber = searchGuitar.GetSerialNumber();
            double price = searchGuitar.GetPrice();

            if (guitar.GetSerialNumber().Equals(serialNumber) && 
                guitar.GetPrice().Equals(price)) {
                    return guitar;
            }

        }

        return null;
    }
}