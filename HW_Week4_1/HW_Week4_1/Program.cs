using HW_Week4_1;


Book myBook1 = new Book("bare hasti", 250, "Milan Kundera", "Parviz Homayonpour");
Book myBook2 = new Book("salam" , 500 , "amir nameni" , "hosein sadoqi");
Book myBook3 = new Book("To Kill a Mockingbird",600, "Harper Lee","leila sdq" );
Book myBook4 = new Book("1984",700, "George Orwell", "sara raad");
Book myBook5 = new Book("The Catcher in the Rye",800, "amir nameni","elahe sdq");
//myBook1.DisplayBookInfo();
//myBook1.IncreasePrice(50);
Book[] booksArray = { myBook1,myBook2,myBook3,myBook4,myBook5 };
booksArray[4].AllBooksOfAuther("amir nameni", booksArray);

