//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------
using System;

namespace Full_GRASP_And_SOLID.Library
{
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public double UnitCostSubTotal
        {
            get
            {
                return this.Input.UnitCost;
            }
        }

        public double EquipmentSubTotal
        {
            get
            {
                return ((Convert.ToDouble(this.Time)) / (60 * 60)) * this.Equipment.HourlyCost;
            }
        }


        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }
    }
}