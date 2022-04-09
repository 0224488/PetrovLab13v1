using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrovLab13v1
{
    class Program
    {
//        Задан класс Building, который описывает здание. Класс содержит следующие элементы:

//        адрес здания;
//        длина здания;
//        ширина здания;
//        высота здания.
//        В классе Building нужно реализовать следующие методы:
//        конструктор с 4 параметрами;
//        свойства get/set для доступа к полям класса;
//        метод Print(), который выводит информацию о здании.
//
//        Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность.
//        В классе MultiBuilding реализовать следующие элементы:
//        конструктор с 5 параметрами – реализует вызов конструктора базового класса;
//        свойство get/set доступа к внутреннему полю класса;
//        метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса.
//        Класс MultiBuilding сделать таким, что не может быть унаследован.

        static void Main(string[] args) 
        {
            // Упрощенный код без ввода данных с клавиатуры и проверок значений, только реализация классов согласно задания

            Bilding bilding = new Bilding("Антелево",7,8,5);
            bilding.PrintBilding();
            MultiBilding multiBilding = new MultiBilding("Антелево", 7, 8, 5,2);
            multiBilding.PrintMultiBilding();
            Console.ReadKey();

        }
    }
    class Bilding
    {
        public string adressBilding { get; set; } // Адрес
        public int lengthBilding { get; set; }    // Длина
        public int widtBilding { get; set; }      // Ширина
        public int heightBilding { get; set; }    // Высота

        public void PrintBilding ()
        {
            Console.WriteLine("Адрес здания: {0}", adressBilding);
            Console.WriteLine("Длина здания: {0}", lengthBilding);
            Console.WriteLine("Ширина здания: {0}", widtBilding);
            Console.WriteLine("Высота здания: {0}", heightBilding);
        }
        public Bilding(string a, int l, int w, int h)
        {
            adressBilding = a;
            lengthBilding = l;
            widtBilding = w;
            heightBilding = h;
        }

    }
    sealed class MultiBilding : Bilding
    {
        public int floorBilding { get; set; }  //Этажность
        public MultiBilding(string a, int l, int w, int h, int f)
            :base(a,l,w,h)
        {
            floorBilding = f;
        }
        public void PrintMultiBilding()
        {
            PrintBilding();
            Console.WriteLine("Этажность здания: {0}", floorBilding);
        }
    }
}
