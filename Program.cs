


//using System.Diagnostics;
//using System.Text;
//using System;

//Oxumali oldugunuz materiallar:

//http://csharpindepth.com/Articles/Chapter2/Events.aspx
//https://www.tutorialspoint.com/csharp/csharp_delegates.htm
//https://www.tutorialspoint.com/csharp/csharp_events.htm
//https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/lambda-expressions

//Task:

//1.Func adinda delegate yaradin hansi ki bir string parametr qebul edir ve void qaytarir.
//2. MyClass adinda bir class yaradin hansi ki, ozunde iki static olmayan method saxlayir(Space(), Reverse())

//   public void Space(string str); // e_x_a_m_p_l_e -> bu metod sadece her herifin arasina _ atir.
//public void Reverse(string str); // elpmaxe -> bu metod ise stringi tersine cevirir.

//3.Run adinda bir class yaradin hansi ki, ozunde runFunc(argument) adinda void function saxlayir.

//Mesele budur ki, men consoldan bir soz daxil edecem ve asagidaki runFunc i cagiracam. Netice olaraq hemen iki funksiya
//yuxarida gosterdiyim kimi cavablar qaytarmalidir.


//public static void Main()
//{
//    Console.WriteLine("Enter string")

//    var str = Console.ReadLine();
//    MyClass cls = new MyClass(str);
//    Func funcDell = new Func(params) // params sadece sizin ora vereceyiniz parametrlerdi	

//    burda funcDell-e functionlari verirsiniz

//    Run run = new Run();
//    run.runFunc(funcDell, str); //cagiranda Space() ve Reverse() functionlari ise dusmelidir
//}

//main-de bunnan artiq kod yaza bilmezsiniz. Amma Classlarda azadsiniz.

//Burda esas diqqet etmeli oldugunuz meqam metodlar MyClass dadir ama men onlari Run da cagiriram. Yeni o metodlari delagate 
//seklinde Run a gonderib orda invoke elemek lazimdir.

//Ugurlar...


using ConsoleApp14;
using System;
namespace N;
public class Program {
   


    static void Main(string[] arr) {


        Console.WriteLine("Enter string");

        var str = Console.ReadLine();
        MyClass cls = new MyClass(str);
        Func funcDell = new Func(cls.Space) ;
        // params sadece sizin ora vereceyiniz parametrlerdi	;
        funcDell = cls.Reverse;
                                     

        //burda funcDell-e functionlari verirsiniz;

        Run run = new Run();
        run.runFunc(funcDell, str); 
    }


//run.runFunc(funcDell, str); //cagiranda Space() ve Reverse() functionlari ise dusmelidir;
}