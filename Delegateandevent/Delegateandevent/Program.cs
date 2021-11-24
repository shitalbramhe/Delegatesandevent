using Delegateandevent;
using System;
namespace Delegateandevent
{ 
    class Program
    {
        public static event DelEventHandler add;
        static void Main(string[] args)
        {
                        Console.WriteLine("Delegate program");
                        Operation obj = new Operation(DelegateDemo.Addition);
                        Console.WriteLine("Addition is={0}", obj(23, 27));
                      
                        MulticastDelegate.ImplementDelegate();
                       
                        add += new DelEventHandler(EventHandler.India);
                        add += new DelEventHandler(EventHandler.USA);
                        add += new DelEventHandler(EventHandler.England);
                        add.Invoke();
                       
        }
    }          

}

