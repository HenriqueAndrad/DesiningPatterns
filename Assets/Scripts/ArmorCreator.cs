using Factory;

public class ArmorCreator : Creator
{
    private int m_ID;

    public void CreateProduct()
    {
        FactoryMethod();
    }
    public override IProduct FactoryMethod()
    {
        m_ID++;
        return new Armor(m_ID.ToString());
    }
}
