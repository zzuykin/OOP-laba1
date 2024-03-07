using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{

    public abstract class Time
    {
        public abstract void ShowTime();
    }

    public class TimeEuro : Time
    {
        protected CultureInfo time = new CultureInfo("es-ES", false);
        public override void ShowTime()
        {
            string text = DateTime.Now.ToString(time);
            Console.WriteLine(text);
        }
    }
    // en-US
    public class TimeUSA : Time
    {
        protected CultureInfo time = new CultureInfo("en-US", false);
        public override void ShowTime()
        {
            string text = DateTime.Now.ToString(time);
            Console.WriteLine(text);
        }
    }

    public abstract class TimeUSADecorator : TimeUSA
    {
        protected TimeUSA timeUSA;
        public TimeUSADecorator(TimeUSA timeUSA)
        {
            this.timeUSA = timeUSA;
        }
        public override void ShowTime()
        {
            timeUSA.ShowTime();
        }
    }

    public abstract class TimeEuroDecorator : TimeEuro
    {
        protected TimeEuro timeEuro;
        public TimeEuroDecorator(TimeEuro timeEuro)
        {
            this.timeEuro = timeEuro;
        }
        public override void ShowTime()
        {
            base.ShowTime();
        }
    }

    public class FunnyTimeEuro : TimeEuroDecorator
    {
        public FunnyTimeEuro(TimeEuro timeEuro) : base(timeEuro) { }
        public override void ShowTime()
        {
            StringBuilder text = new StringBuilder(DateTime.Now.ToString(time));
            text.Insert(8, " !@$ ");
            Console.WriteLine(text.ToString());
        }
    }
    public class FunnyTimeUS : TimeUSADecorator
    {
        public FunnyTimeUS(TimeUSA timeUSA) : base(timeUSA) { }
        public override void ShowTime()
        {
            StringBuilder text = new StringBuilder(DateTime.Now.ToString(time));
            text.Insert(8, " !@$ ");
            Console.WriteLine(text.ToString());
        }
    }
   //public abstract class Decorator : Time
    //{
    //    protected Time timeItem;
    //    public Decorator(Time item)
    //    {
    //        this.timeItem = item;
    //    }
    //    public override void ShowTime()
    //    {
    //        timeItem.ShowTime();
    //    }
    //}
    //public class TimeDecorator : Decorator
    //{
    //    public TimeDecorator(Time item) : base(item) { }
    //    public override void ShowTime()
    //    {
    //        base.ShowTime();
    //        Console.WriteLine("HUI!");
    //    }
    //}


}
