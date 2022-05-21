using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kniga
{
    public class Kniga
    {
        public int id = 0;
        public string name;
        public string secondname;
        public string surname;
        public string phonenumber;
        public string country;
        public string birth;
        public string organization;
        public string position;
        public string notes;
        public Dictionary<int, Onecontact> Allcontact = new Dictionary<int, Onecontact>();
        public static void Main(string[] args)
        {
            Kniga kniga = new Kniga();
            kniga.Menu();


        }
        private void Menu()
        {
            Console.WriteLine(" для создания новой записи введите команду: add");
            Console.WriteLine(" для просмотра записи введите команду: show");
            Console.WriteLine(" для редактирования записи введите команду: red");
            Console.WriteLine(" для удаления записи введите команду: del");
            Console.WriteLine(" для просмотра списка всех записей введите команду: all");
            Console.WriteLine(" для выхода из программы введите команду: end");
            Console.Write("введите команду: ");
            string reader = Console.ReadLine();
            string[] com = { "add", "show", "red", "del", "all", "end" };
            while (!com.Contains(reader))
            {
                Console.Write("команда не найдена");
                reader = Console.ReadLine();
            }
            if (reader.Contains(com[0]))
            {
                Console.WriteLine("создание");
                AddContact();
                Menu();
            }
            else if (reader.Contains(com[1]))
            {
                Console.WriteLine("просмотр");
                Show();
                Menu();
            }
            else if (reader.Contains(com[2]))
            {
                Console.WriteLine("редактирование");
                redact();
                Menu();
            }

            else if (reader.Contains(com[3]))
            {
                Console.WriteLine("удаление");
                Delete();
                Menu();
            }
            else if (reader.Contains(com[4]))
            {
                Console.WriteLine("весь список");
                Showall();
                Menu();
            }
            else if (reader.Contains(com[5]))
            {
                Console.WriteLine("конец");
                return;
            }
        }

        private void AddContact()
        {
            Onecontact onecontact = new Onecontact() { id1 = id };
            do
            {
                Console.WriteLine("введите имя");
                name = Console.ReadLine();
            }
            while (name == "");
            onecontact.name1 = name;
            do
            {
                Console.WriteLine("введите фамилию");
                surname = Console.ReadLine();
            }
            while (surname == "");
            onecontact.surname1 = surname;

            Console.WriteLine("введите отчество");
            secondname = Console.ReadLine();
            onecontact.secondname1 = secondname;

            Console.WriteLine("введите номер");
            phonenumber = Console.ReadLine();
            while (UInt64.TryParse(phonenumber, out ulong result) == false)
            {
                Console.WriteLine("корректно введите номер");
                phonenumber = Console.ReadLine();
            }
            onecontact.phonenumber1 = phonenumber;

            do
            {
                Console.WriteLine("введите страну");
                country = Console.ReadLine();
            }
            while (country == "");
            onecontact.country1 = country;

            Console.WriteLine("введите дату рождения");
            birth = Console.ReadLine();
            onecontact.birth1 = birth;

            Console.WriteLine("введите организацию");
            organization = Console.ReadLine();
            onecontact.organization1 = organization;

            Console.WriteLine("введите должность");
            position = Console.ReadLine();
            onecontact.position1 = position;

            Console.WriteLine("заметки");
            notes = Console.ReadLine();
            onecontact.notes1 = notes;
            Allcontact.Add(id, onecontact);
            id++;
        }
        private void redact()
        {
            Showall();
            Console.WriteLine("введите номер контакта");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("некорректный");
            }
            else if (!Allcontact.ContainsKey(id))
            {
                Console.WriteLine("запись не найдена");
            }
            else
            {
                Console.WriteLine("что нужно отредатировать" + "\n" + "1. Имя" + "\n" + "2. фамилия" + "\n" + "3. отчество" + "\n" + "4. номер" + "\n" + "5. страна" + "\n" + "6. дата рождения" + "\n" + "7. организация" + "\n" + "8. должность" + "\n" + "9. заметки");
                string elementnumber = Console.ReadLine();
                while (true)
                {
                    if (elementnumber == "1" || elementnumber == "2" || elementnumber == "3" || elementnumber == "4" || elementnumber == "5" || elementnumber == "6" || elementnumber == "7" || elementnumber == "8" || elementnumber == "9")
                    {
                        switch (elementnumber)
                        {
                            case "1":
                                Console.WriteLine("новое имя");
                                Allcontact[id].name1 = Console.ReadLine();
                                break;
                            case "2":
                                Console.WriteLine("новая фамилия");
                                Allcontact[id].surname1 = Console.ReadLine();
                                break;
                            case "3":
                                Console.WriteLine("новое отчество");
                                Allcontact[id].secondname1 = Console.ReadLine();
                                break;
                            case "4":
                                Console.WriteLine("введите номер");
                                string phone = Console.ReadLine();
                                while (UInt64.TryParse(phone, out ulong result) == false)
                                {
                                    Console.WriteLine("корректно введите номер");
                                    phone = Console.ReadLine();
                                }
                                Allcontact[id].phonenumber1 = phone;
                                break;
                            case "5":
                                Console.WriteLine("новая страна");

                                Allcontact[id].country1 = Console.ReadLine();
                                break;
                            case "6":
                                Console.WriteLine("новая дата");
                                Allcontact[id].birth1 = Console.ReadLine();
                                break;
                            case "7":
                                Console.WriteLine("новая организация");
                                Allcontact[id].organization1 = Console.ReadLine();
                                break;
                            case "8":
                                Console.WriteLine("новая должность");
                                Allcontact[id].position1 = Console.ReadLine();
                                break;
                            case "9":
                                Console.WriteLine("новая заметка");
                                Allcontact[id].notes1 = Console.ReadLine();
                                break;


                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("введите корректное значение");
                        elementnumber = Console.ReadLine();
                    }
                }
            }
        }
        private void Delete()
        {
            Showall();
            Console.WriteLine("введите номер контакта");
            string contnumber = Console.ReadLine();
            var cont = new Dictionary<int, Onecontact>(Allcontact);
            foreach (var item in cont)
            {
                Allcontact.Remove(item.Key);
                id--;
                return;
            }
        }
        private void Show()
        {
            Showall();
            Console.WriteLine("введите номер контакта");
            string contnumber = Console.ReadLine();
            if (int.TryParse(contnumber, out int number))
            {
                if (Allcontact.ContainsKey(number))
                {
                    Console.WriteLine(Allcontact[number].fullinfo());
                }
                else
                {
                    Console.WriteLine("контакта не существует");
                }
            }
        }

        private void Showall()
        {
            foreach (var item in Allcontact)
            {
                Console.WriteLine(item.Value.shortinfo());
            }
        }
    }
}
