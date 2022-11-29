using System;
using System.Collections.Generic;
using System.Linq;

namespace InspectorLib
{
    public class FunctionInsp
    {
        string[] List_of_inspectors = {"Иванов Иван Иванович", "Зиронов Татар Александрович", "Миронов Ааврал Васильевич", "Васильев Василий Иванович"};//Массив отвечающий за список сотрудников
        string Name_of_the_Chief_Inspector = ("Васильев Василий Иванович");//Массив содержащий имя главного инспектора
        string Conclusion;//Создаеться для вывода содержимого библиотеки

        public FunctionInsp(string Conclusion)
        {
            this.Conclusion = Conclusion;

            void GetСarInspection()//№1 данный метод возвращает ФИО главного инспектора автоинспекции.
            {
                Console.WriteLine($"Название – АЗК г. Чита");//Вывод в консоль названия автоинспекции
            }
            GetСarInspection();//Вызов метода

            void GetInspector()//№2 данный метод возвращает название автоинспекции.
            {
                    Console.WriteLine($"Главный инспектор – {Name_of_the_Chief_Inspector}");
            }
            GetInspector();//Вызов метода

            string SetInspector()//№3 заменяет ФИО главного инспектора
            {
                string fullname = " ";
                Console.WriteLine($"Введите имя нового главного инспектора из списка");
                Console.WriteLine($"Список инспекторов: 1-Иванов Иван Иванович 2-Зиронов Татар Александрович 3-Миронов Ааврал Васильевич 4-Васильев Василий Иванович");

                string Pressed = Console.ReadLine();

                for (int i=0; i< List_of_inspectors.Length; i++)
                {
                    if (List_of_inspectors[i] == Pressed)
                    {
                        Name_of_the_Chief_Inspector.Remove(0);
                        Name_of_the_Chief_Inspector = List_of_inspectors[i];
                    }
                }
                return fullname;
            }
            SetInspector();//Вызов метода

            void GenerateNumber()//№4 возвращает сгенерированный номер пользователю
            {
                Random rand = new Random();

                int stringlen = rand.Next(1, 1);
                int randValue;
                string symbol = "";
                char letter;

                for (int i = 0; i < stringlen; i++)
                {

                    // Генерация случайного числа.
                    randValue = rand.Next(0, 26);

                    //Генерация случайного символа и преобразования
                    //Случайного числа в символ.
                    letter = Convert.ToChar(randValue + 65);

                    //Добавление буквы к строке.
                    symbol = symbol + letter;
                }

                    Random sluchainaya_velichina = new Random(); //Обращение к классу случайных величин
                    int Number = sluchainaya_velichina.Next(1, 100); //Переменная Number принимает значение от 1 до 100

                    Random sluchainaya_velichina1 = new Random();
                    int code = sluchainaya_velichina1.Next(1, 75);

                Console.Write("Госномер:" + symbol + "-" + Number + "-" + code);//Вывод результата
            }
            GenerateNumber();//Вызов метода

            void GetWorker()//№5 данный метод возвращает список сотрудников

            {
                Console.WriteLine($" ");
                Console.WriteLine($"ФИО сотрудников автоинспекции: ");

                for (int i = 0; i < List_of_inspectors.Length; i++)
                {
                    Console.WriteLine($"{List_of_inspectors[i]}");
                }
            }
            GetWorker();//Вызов метода

            void AddWorker()//№6 данный метод добавляет нового сотрудника в список сотрудников.
            {
                Array.Resize(ref List_of_inspectors, List_of_inspectors.Length + 1);
                List_of_inspectors[List_of_inspectors.Length - 1] = "Лапин Роман Дмитриевич";
            }
            AddWorker();//Вызов метода
        }
        public void Conclusionofthemessage()
        {
            Console.WriteLine($"{Conclusion}");//Выводит содержимое библиотеки в консоль
        }
    }
}
