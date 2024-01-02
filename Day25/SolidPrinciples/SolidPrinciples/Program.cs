using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace SolidPrinciples
{
    //public interface Text
    //{
    //    void Print();
    //}
    //class format : Text
    //{
    //    public void Print()
    //    {
    //        Console.WriteLine("Dependency Injection");
    //    }
    //}
    //public class ConstructorInjection
    //{
    //    private Text _text;
    //    public ConstructorInjection(Text T1)
    //    {
    //        this._text = T1;

    //    }
    //    public void Print()
    //    {
    //        _text.P
    //        print();
    //    }
    //}

        public interface INotificationAction
    {
        void ActOnNotification(String message);
    }
    class Simple
    {
        INotificationAction task = null;
        public void notify(INotificationAction at, string messages)
        {
            this.task = at;
            task.ActOnNotification(messages);
        }
    }
    class EvenLogWriter : INotificationAction
    {
        public void ActOnNotification(String message)
        {
            Console.WriteLine("Click on the Bell to Ring");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            //ConstructorInjection ci = new ConstructorInjection(new format());
            //ci.Print();
            //Console.ReadKey();

            EvenLogWriter elw = new EvenLogWriter();
            Simple at = new Simple();
            at.notify(elw, "To Logg");
            Console.ReadKey();
        }


       
    }
}