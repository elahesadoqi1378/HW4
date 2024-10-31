

namespace HW_Week4_1
{
    public class Book
    {
        public Book(string name, int price , string author , string narrator)
        {
            Name = name;
            Price = price;
            Author = author;
            Narrator = narrator;
            
        }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Narrator { get; set; }
        public int Price { get; private set; }
      
 

        public void SetPrice(int price)
        {
            Price = price;
        }
        public void RecordBookInfo(string name, string author, string narrator, int price)
        {
            Name = name;
            Author = author;
            Narrator = narrator;
            Price = price; // This will use the property setter
        }
        public void DisplayBookInfo()
        {
            Console.WriteLine("Name is:" + Name);
            Console.WriteLine("Author is: " + Author);
            Console.WriteLine("Narrator is:" + Narrator);
            Console.WriteLine("Price is:" + Price);
        }
        public void IncreasePrice(int amount)
        {
            if (amount > 0)
            {
               Price+= amount;
                Console.WriteLine("new price is" +Price);
            }
        }

        //// Method to get the price
        //public int GetPrice()
        //{
        //    return Price;
        //}
        public void AllBooksOfAuther(string author, Book[] booksArray)
        {
            for(int i = 0; i< booksArray.Length; i++)
            {
                if (booksArray[i].Author == author)
                {
                    Console.WriteLine("all books of this author is:" + booksArray[i].Name);
                }
                
            }

        }

    }

}
