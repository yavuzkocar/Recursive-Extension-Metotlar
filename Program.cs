using System;

namespace Recursive_Extension_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
           //rekürsif = öz yinelemeli
           //3^4 dün yapımı=3*3*3*3
           int result = 1;
           for (int i = 1; i < 5; i++)
           {
               result=result*3;
           }
           Console.WriteLine(result);
           islemler instance = new();
           Console.WriteLine(instance.expo(3,4));
           //expo(3,4)=
           //expo(3,3)*3=
           //expo(3,2)*3*3=
           //expo(3,2)*3*3*3=
           //3*3*3*3=3^4 islem tamam...

           //extension metotlar
           string ifade="yavuz kocar. ";
           bool sonuc = ifade.CheckSpaces();
           Console.WriteLine(sonuc);
           if (sonuc)
           {
               Console.WriteLine(ifade.RemoveWhiteSpaces());
           }
           Console.WriteLine(ifade.MakeUpperCase());
           Console.WriteLine(ifade.MakeLoverCase());

           int[] dizi={9,3,6,5,5,8,7,6};
           dizi.SortArray();
           dizi.ekranayazdır();
           int sayi=5;
           Console.WriteLine(sayi.isevernumber());
           Console.WriteLine(ifade.getfirscharacter());

        }
    }
    public class islemler
    {
        public int expo(int sayi, int üst)
        {
            if (üst<2)
            {
                return sayi;
            }
            return expo(sayi, üst-1)*sayi;
        }
        
    }
    public static class extencions
        {
            public static bool CheckSpaces(this string param)
            {
               return param.Contains(" ");
            }
            public static string RemoveWhiteSpaces(this string param)
            {
                 string[] dizi = param.Split(" ");
                  return string.Join("",dizi);
            }

            public static string MakeUpperCase(this string param)
            {
               return param.ToUpper();
            }

            public static string MakeLoverCase(this string param)
            {
               return param.ToLower();
            }

            public static int[] SortArray(this int[] param)
            {
               Array.Sort(param);
               return param;
            }
            public static void ekranayazdır(this int[] param)
            {
                foreach (var item in param)
                Console.WriteLine(item);
            }
            public static bool isevernumber(this int param)
            {
                return param%2==0;
            }

            public static string getfirscharacter(this string param)
             {
                return param.Substring(0,1);//1. indexten başlayıp 1 karakter getirir 
             }


        }

}
