﻿namespace BootCamp.Chapter.Items
{
    public class Legspiece
    {
        private string _name;
        private decimal _price;
        private float _weight;

        public Legspiece(string name, decimal price, float weight)
        {
            _name = name;
            _price = price;
            _weight = weight;
        }
        public string Name
        {
            get;
            set;
        }
        public decimal Price
        {
            get;
            set;
        }
        public float Weight
        {
            get;
            set;
        }

        private float _defense;
        public float Defense
        {
            get;
            set;
        }
    }
}
