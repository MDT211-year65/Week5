namespace Test_Guiter_Shop;

public class InventoryTest {

    Inventory inventory = new Inventory(initializeInventoryMockData());
    Guitar mockNewGuitar = new Guitar("000001", 5000.52, new GuitarSpec("Nhong", "Stratocaster", "Alder"));
    Guitar mockGuitarIsNotFound = new Guitar("000021", 5000.52, new GuitarSpec("Nhong", "Stratocaster", "Alder"));

    private static Guitar[] initializeInventoryMockData() {
        Guitar[] guitars = { new Guitar("000001", 5000.52, new GuitarSpec("Nhong", "Stratocaster", "Alder")),
        new Guitar("000002", 7412.52, new GuitarSpec("Jame", "Stratocaster", "Alder")),
        new Guitar("000003", 3917.52, new GuitarSpec("Jo", "Stratocaster", "Alder")),
        new Guitar("000004", 8254.52, new GuitarSpec("Ning", "Stratocaster", "Alder")),
        new Guitar("000005", 1234.52, new GuitarSpec("Ning", "Stratocaster", "Alder"))};

        return guitars;
    }

    [Fact]
    public void TestCreateInventory() {
        Assert.IsType<Inventory>(inventory);
    }

    [Fact]
    public void TestGetGuitarFromSerialNumberIsCorrected() {
        Assert.True(inventory.GetGuitar("000001") != null);
    }

    [Fact]
    public void TestGetGuitarFromSerialNumberIsIncorrect() {
        Assert.True(inventory.GetGuitar("000041") == null);
    }

    [Fact]
    public void TestGetGuitarFromPriceIsCorrect() {
        Assert.True(inventory.GetGuitar(5000.52) != null);
    }

    [Fact]
    public void TestGetGuitarFromPriceIsInCorrect() {
        Assert.True(inventory.GetGuitar(5000.51) == null);
    }

    [Fact]
    public void TestGetGuitarFromSearchSerialNumberAndPriceIsCorrect() {
        Assert.True(inventory.Search(mockNewGuitar) != null);
    }

    [Fact]
    public void TestGetGuitarFromSearchSerialNumberAndPriceIsInCorrect() {
        Assert.True(inventory.Search(mockGuitarIsNotFound) == null);
    }

}