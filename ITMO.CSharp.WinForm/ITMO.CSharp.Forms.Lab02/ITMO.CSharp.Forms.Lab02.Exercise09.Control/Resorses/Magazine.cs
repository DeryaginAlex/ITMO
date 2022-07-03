using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiblWorm
{
    class Magazine : Item, IPubs
    {
        private String volume;    // том
        private int number;        // номер
        private String magtitle;       // название
        private int magyear;      // год выпуска

        public bool IfSubs { get; set; } // подписка на журнал

        public Magazine(string volume, int number, string magtitle, int magyear, int maginvNumber, bool taken)
            : base(maginvNumber, taken)
        {
            this.volume = volume;
            this.number = number;
            this.magtitle = magtitle;
            this.magyear = magyear;
        }

        public override void Return()    // операция "вернуть"
        {
            taken = true;
        }

        // реализация интерфейса

        public void Subs()
        {
                // действия при оформлении подписки на журнал
        }

        public override string ToString()
        {
            if (IfSubs)
            return "\nЖурнал:\n Название: " + magtitle + "\nТом: " + volume +
                    "\nИнв. номер: " + number + "\nГод выпуска: " + magyear + "\n Подписка оформлена";
            else
                return "\nЖурнал:\n Название: " + magtitle + "\nТом: " + volume +
                    "\n Инв. номер: " + number + "\nГод выпуска: " + magyear + "\n Подписка не оформлена"; ;
        }
    }
}
