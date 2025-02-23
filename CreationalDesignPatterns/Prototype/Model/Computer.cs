﻿using System;

namespace CreationalDesignPatterns.Prototype.Model
{
    class Computer : ICloneable
    {
        public Computer()
        {
            Board = new MotherBoard();
            Board.Brand = "Dell";
            Board.HasLanPort = 2;
            Board.USBPortsCount = 3;


            GPU = new GraphicsCard();
            GPU.AmountOfRam = 4;
            GPU.GpuFrequency = 1.1;

        }


        public int AmountOfCores { get; set; }
        public string FactoryName { get; set; }
        public GraphicsCard GPU { get; set; }
        public MotherBoard Board { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }


        private object CustomClone()
        {
            var clone = (Computer)MemberwiseClone();

            clone.GPU = new GraphicsCard()
            {
                AmountOfRam = 90,
                GpuFrequency = 0.111d
                
            };

            return clone;
        }
    }
}
