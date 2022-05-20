using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Kniga
{
    public class Onecontact
    {
        public int id1;
        public string name1;
        public string secondname1;
        public string surname1;
        public string phonenumber1;
        public string country1;
        public string birth1;
        public string organization1;
        public string position1;
        public string notes1;
        public string fullinfo()
        {
            return "\n" + "Id: " + this.id1 + "\n" + "Фамилия: " + this.surname1 + "\n" + "Имя: " + this.name1 + "\n" + "Отчество: " + this.secondname1 + "\n" + "Номер телефона: " + this.phonenumber1 + "\n" + "Страна: " + this.country1 + "\n" + "Дата рождения: " + this.birth1 + "\n" + "Организация: " + this.organization1 + "\n" + "Должность: " + this.position1 + "\n" + "Заметки: " + this.notes1;
        }
        public string shortinfo()
        {
            return this.id1 + " " + this.surname1 + " " + this.name1 + " " + this.phonenumber1;
        }

    }
}
