namespace Test_Guiter_Shop;

public class GuitarTest {
    Guitar mockNewGuitar = new Guitar("000001", 5000.52, new GuitarSpec("Nhong", "Stratocaster", "Alder"));

    [Fact]
    public void TestCreateNewGuitar() {
        Assert.IsType<Guitar>(mockNewGuitar);
    }

    [Fact]
    public void TestGetSerialNumber() {
        Assert.Equal(mockNewGuitar.GetSerialNumber(), "000001");
    }

    [Fact]
    public void TestGetPrice() {
        Assert.Equal(mockNewGuitar.GetPrice(), 5000.52);
    }

    [Fact]
    public void TestGuitarSpec() {
        Assert.Equal(mockNewGuitar.GetGuitarSpec().GetBuilder(), "Nhong");
        Assert.Equal(mockNewGuitar.GetGuitarSpec().GetModel(), "Stratocaster");
        Assert.Equal(mockNewGuitar.GetGuitarSpec().GetWood(), "Alder");

    }
}