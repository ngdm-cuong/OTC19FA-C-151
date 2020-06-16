class TacoPrice
{
    private decimal dollarPrice;
    private decimal looniePrice;
    const decimal CONVERSION = 1.2892;

    public decimal DollarPrice { get => dollarPrice; set => dollarPrice = value; }
    public decimal LooniePrice { get => looniePrice; set => looniePrice = value; }

    public TacoPrice(decimal dollarPrice, decimal looniePrice)
    {
        this.dollarPrice = dollarPrice;
        this.looniePrice = looniePrice;
    }
    public TacoPrice()
    {

    }
    public decimal LoonieToDollarPrice()
    {
        
        return looniePrice*CONVERSION;
    }
    public string GetLowerPrice()
    {
        // TODO: Implement
        return "";
    }

    public override string ToString()
    {
        return string.Format("Buy from the {0}",
                              "American" +
                              " Taco Bell.");
    }

}