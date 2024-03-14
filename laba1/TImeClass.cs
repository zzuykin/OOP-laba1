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


}
