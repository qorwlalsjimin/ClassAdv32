using System;

namespace ClassAdv32
{
    internal class Product
    {
        private string name;
        private int price;

        //생성자
        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        //소멸자
        ~Product() //객체가 소멸될때
        {
            Console.WriteLine(this.name + "의 소멸자 호출");

        }
    }
}