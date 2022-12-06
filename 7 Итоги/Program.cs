abstract class Person
{
    public string name;
    public int numberPhone;
    public void Greetings()
    {
        Console.WriteLine("Меня зовут {0}", name);
    }
    public Person()
    {
        name = Console.ReadLine();
        numberPhone = Convert.ToInt32(Console.ReadLine());
    }
    public Person(string Серафим)
    {
        name = Серафим;
        numberPhone = Convert.ToInt32(Console.ReadLine());
    }
    public Person(string Серафим, int phone)
    {
        name = Серафим;
        numberPhone = phone;
    }

    public int NumberPhone
    {
        get
        {
            return NumberPhone;
        }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Ваш номер не удовлетворяет требованиям");
            }    
            else
            {
                NumberPhone = value;
            }
        }
    }
}

class Customer : Person
{}
class Courier : Person
{}
class Address
{
   public string address;
}
class Delivery
{
    public Address address;
    public virtual string DeliveryTo(string address)
    {
        Console.WriteLine("Доставлено на");
        return address;
    }
}
    
class HomeDelivery : Delivery
{
    public override string DeliveryTo(string address)
    {
        Console.WriteLine("Доставлено на дом");
        return address;
    }
}

class PickPointDelivery : Delivery
{
    public override string DeliveryTo(string address)
    {
        Console.WriteLine("Доставлено на точку выдачи");
        return address;
    }
}

class ShopDelivery : Delivery
{
    public override string DeliveryTo(string address)
    {
        Console.WriteLine("Доставлено на магазин");
        return address;
    } 
}

class Order<TDelivery,TOrderItem > where TDelivery : Delivery where TOrderItem : OrderItem
{
    public TDelivery Delivery;

    public TOrderItem OrderItem;

    public string Description;

    public void DisplayAddress()
    {
       Console.WriteLine(Delivery.address);
    }
}

class OrderItem
{

}

// Помарка, было крайне не понятно делать некоторые вещи(но интересно)
// Поэтому хотелось бы чтобы проверяющий(тоесть вы) оставили советы на будущее <3



