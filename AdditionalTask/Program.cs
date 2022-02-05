using System;
using System.Text;

namespace AdditionalTask
{
    internal struct Notebook
    {
        private string _model, _manufacturer;
        private double _price;

        public Notebook(string model, string manufacturer, double price)
        {
            _model = model;
            _manufacturer = manufacturer;
            _price = price;
        }

        public void Print() => Console.WriteLine($"Mode: {_model}, manufactured by {_manufacturer}, price: {_price} $.");
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook hp = new Notebook("Pavilion 15", "HP", 700);
            hp.Print();

        }
    }
}
