using laba1;


var item1 = new TimeEuro();
Console.WriteLine(item1.ShowTime());

var timeDecorator = new TimeEuroDecorator(item1);
Console.WriteLine(timeDecorator.ShowTime());


var item2 = new TimeUSA();
Console.WriteLine(item2.ShowTime());

var timeUSDEC = new TimeUSADecorator(item2);
Console.WriteLine(timeUSDEC.ShowTime());