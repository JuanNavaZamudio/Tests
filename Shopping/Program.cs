

MenuOptions SelectedOption = 0;

void printOptions(){
    Console.WriteLine("1) Add an item");

}

MenuOptions GetUserOption(){
      try{
          return (MenuOptions)Convert.ToInt32((Console.ReadLine()));
      }catch{
          return 0;
      }
}


do{
    Console.WriteLine("Welcome, choose an option");
    printOptions();
    
    switch(SelectedOption){

    }
}while(SelectedOption == MenuOptions.Exit);

enum MenuOptions{AddItem=1,Purchase=2,GetTotalItems=3,GetTotalPurchase=4,Exit=5}
