namespace Test_Guiter_Shop;

public class GuitarSpecTest {
    GuitarSpec mockNewGuitarSpec =  new GuitarSpec("Nhong", "Stratocaster", "Alder");

    [Fact]
    public void TestCreateNewGuitarSpec() {
        Assert.IsType<GuitarSpec>(mockNewGuitarSpec);
    }

    [Fact]
    public void TestGetBuilder() {
        Assert.Equal(mockNewGuitarSpec.GetBuilder(), "Nhong");
    }

    [Fact]
    public void TestGetModel() {
        Assert.Equal(mockNewGuitarSpec.GetModel(), "Stratocaster");
    }

    [Fact]
    public void TestGetWood() {
        Assert.Equal(mockNewGuitarSpec.GetWood(), "Alder");
    }

}