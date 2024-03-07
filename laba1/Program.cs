using laba1;

//MyRational num1 = new(0, 3);
//MyRational num2 = new(0, -2);
//MyRational num3 = num1;
TimeEuro timeEuro = new TimeEuro();
timeEuro.ShowTime();
TimeUSA timeUSA = new TimeUSA();
timeUSA.ShowTime();
timeUSA = new FunnyTimeUS(timeUSA);
timeUSA.ShowTime();
timeEuro = new FunnyTimeEuro(timeEuro);
timeEuro.ShowTime();
timeUSA = new TimeUSA();
timeUSA.ShowTime();
//timeEuro.ShowTime();
//timeUSA.ShowTime();

