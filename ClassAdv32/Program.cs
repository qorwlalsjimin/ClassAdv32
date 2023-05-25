using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ClassAdv32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //소멸자 예시 - 프로그램 종료될때 객체 사라짐
            Product product1 = new Product("과자", 1000);
            Product product2 = new Product("아이스크림", 1000);
            Product product3 = new Product("케이크", 1000);

            /*
             * 객체 생성의 역순으로 소멸된다
             케이크의 소멸자 호출
             아이스크림의 소멸자 호출
             과자의 소멸자 호출
            */


            //속성(Property) 실습
            Box box = new Box(10, 10);
            box.Width = 100; //올바른 값
            box.Height = 100;
            Console.WriteLine("Area: "+box.GetArea());
            try
            {
                box.Width = -10; //잘못된 값이 들어간 경우
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
