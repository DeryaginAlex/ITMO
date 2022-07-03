using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiblWorm
{
    class Book : Item
    {
        private string author;
        private string title;
        private string publisher;
        private int pages;
        private int year;

        private double cust;
        private bool returnSrok;

        private static double price = 9;

        static Book()       //статический конструктор
        {
            price = 100;
        }

        public Book(string author, string title, string publisher, int pages, int year, long invNumber, bool taken) : base(invNumber, taken)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        public Book()
        {

        }

        public static void SetPrice(double price)
        {
            Book.price = price;
        }

        public override string ToString()
        {
            if (IsAvailable())
                return "\nКнига:\n Автор: " + author + "\n Название: " + title +
                        "\n Год издания: " + year + "., " + pages + " стр. \n Стоимость аренды: " + price + " p.\n" + base.ToString()
                        + "\nИтого за чтение: " + cust + " p.";
            else
                return "\nКнига:\n Автор: " + author + "\n Название: " + title +
                    "\n Год издания: " + year + "., " + pages + " стр. \n Стоимость аренды: " + price + " p.\n" + base.ToString();
        }

        public void PriceBook(int s)
        {
            if (returnSrok == true)
                cust = s * price;
            else cust = s * (price + price * 0.13);
        }

        public void ReturnSrok()
        {
            returnSrok = true;
        }

        public override void Return()    // операция "вернуть"
        {
            if (returnSrok == true)
                taken = true;
            else
                taken = false;
        }
    }
}