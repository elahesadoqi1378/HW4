
namespace HW_Week4_2
{
    
    public class BankAccount
    {
        public BankAccount(  string accountnumber , string accountowner )
        {
            
            AccountNumber = accountnumber;
            AccountOwner = accountowner;
            Invontery = 100000;
            
        }
        public string  AccountNumber { get; set; }
        public string AccountOwner { get; set; }
        public Decimal Invontery { get; private set; }


        public void SetInventory(Decimal invent)
        {
            Invontery = invent;
        }


        public void Deposit(Decimal money)
        {
            if (money > 0)
            {
                Invontery += money;
                Console.WriteLine(" your new invontory is:" +Invontery);
            }
            else
            {
                Console.WriteLine("money that you want to deposit must be positive.");
            }
        }
        public void PickUp(Decimal money)
        {
            if (money > 0 && money<Invontery)
            {
                Invontery -= money;
                Console.WriteLine("your new inventory is:" + Invontery);
            }
             else if (money> Invontery)
             {
               Console.WriteLine("your inventory is not enough for picking up");
             }
             else
             {
                Console.WriteLine("money that you want pick must be positive.");
             }

        }
        public void DisplayInventory()
        { 
             Console.WriteLine("Inventory is:" + Invontery);
            //Console.WriteLine("Employee is:" + Employee);
            //Console.WriteLine("AccountNumber is:" + AccountNumber);
            //Console.WriteLine("Accountowner is:" + AccountOwner);
           
        }

    }

    
    

  
}
