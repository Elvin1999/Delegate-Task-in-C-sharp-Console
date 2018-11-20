using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DelegateTask
{
    class MyClass
    {
        public void Space(string str)
        {
            var str2 = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                str2 += str[i] + " ";
            }
            Console.WriteLine(str2);
        }
        public void Reverse(string str)
        {
            var newstr=str.Reverse();
            Console.WriteLine(newstr);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //   Console.WriteLine("Enter string");

            // var str = Console.ReadLine();
            //       MyClass cls = new MyClass(str);
            //     Func funcDell = new Func(params) // params sadece sizin ora vereceyiniz parametrlerdi	

            // burda funcDell-e functionlari verirsiniz

            // Run run = new Run();
            //         run.runFunc(funcDell, str); //cagiranda Space() ve Reverse() functionlari ise dusmelidir
            //     }
        }
    }
}