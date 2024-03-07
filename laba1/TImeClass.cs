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
        public abstract string ShowTime();
    }

    public sealed class TimeEuro : Time
    {
        protected CultureInfo time = new CultureInfo("es-ES", false);
        public override string ShowTime()
        {
            return DateTime.Now.ToString(time);
        }
    }
    // en-US
    public class TimeUSA : Time
    {
        protected CultureInfo time = new CultureInfo("en-US", false);
        public override string ShowTime()
        {
            return DateTime.Now.ToString(time);
        }
    }

    public abstract class Decorator : Time
    {
        private Time item;
        public Decorator(Time item)
        {
            this.item = item;
        }
        public override string ShowTime()
        {
            return item.ShowTime();
        }
    }
    public class TimeEuroDecorator : Decorator
    {
        public TimeEuroDecorator(TimeEuro item) : base(item) { }
        public override string ShowTime()
        {
            StringBuilder text = new StringBuilder(base.ShowTime());
            text.Insert(8, " !@$ ");
            return text.ToString();
       }
    }
    public class TimeUSADecorator : Decorator
    {
        public TimeUSADecorator(TimeUSA item) : base(item) { }
        public override string ShowTime()
        {
            StringBuilder text = new StringBuilder(base.ShowTime());
            text.Insert(8, " !@$ ");
            return text.ToString();
        }
    }
    //public abstract class TimeUSADecorator : TimeUSA
    //{
    //    protected TimeUSA timeUSA;
    //    public TimeUSADecorator(TimeUSA timeUSA)
    //    {
    //        this.timeUSA = timeUSA;
    //    }
    //    public override void ShowTime()
    //    {
    //        timeUSA.ShowTime();
    //    }
    //}

    //public abstract class TimeEuroDecorator : TimeEuro
    //{
    //    protected TimeEuro timeEuro;
    //    public TimeEuroDecorator(TimeEuro timeEuro)
    //    {
    //        this.timeEuro = timeEuro;
    //    }
    //    public override void ShowTime()
    //    {
    //        base.ShowTime();
    //    }
    //}

    //public class FunnyTimeEuro : TimeEuroDecorator
    //{
    //    public FunnyTimeEuro(TimeEuro timeEuro) : base(timeEuro) { }
    //    public override void ShowTime()
    //    {
    //StringBuilder text = new StringBuilder(DateTime.Now.ToString(time));
    //text.Insert(8, " !@$ ");
    //        Console.WriteLine(text.ToString());
    //    }
    //}
    //public class FunnyTimeUS : TimeUSADecorator
    //{
    //    public FunnyTimeUS(TimeUSA timeUSA) : base(timeUSA) { }
    //    public override void ShowTime()
    //    {
    //        StringBuilder text = new StringBuilder(DateTime.Now.ToString(time));
    //        text.Insert(8, " !@$ ");
    //        Console.WriteLine(text.ToString());
    //    }
    //}
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
    //        Console.WriteLine("!");
    //    }
    //}


}
