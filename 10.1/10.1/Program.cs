//Порушено принцип єдиності обов'язку. Клас Order виконує забагато роботи. Можна виправити
//це створивши нові класи і передавши їм частину обов'язків

class Item
{

}
class Order
{
    private List<Item> itemList;
    internal List<Item> ItemList
    {
        get
        {
            return itemList;
        }
        set
        {
            itemList = value;
        }
    }   
   
}

class OrderInformation
{
    public void CalculateTotalSum() {/*...*/}
    public void GetItems() {/*...*/}
    public void GetItemCount() {/*...*/}
    public void PrintOrder() {/*...*/}
    public void ShowOrder() {/*...*/}
}

class ModifyOrder
{
    public void AddItem(Item item) {/*...*/}
    public void DeleteItem(Item item) {/*...*/}
    public void Load() {/*...*/}
    public void Save() {/*...*/}
    public void Update() {/*...*/}
    public void Delete() {/*...*/}
}
