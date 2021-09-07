//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;
using System.Text;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public double GetProductionCost()
        {
            double result = 0;
            double resultUnitCost = 0;
            double resultEquipmentCost = 0;
            foreach (Step item in this.steps)
            {
                resultUnitCost += item.UnitCostSubTotal;
                resultEquipmentCost += item.EquipmentSubTotal;
            }

            result = resultUnitCost + resultEquipmentCost;
            return Math.Round(result, 1);
        }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

          /*
        Utilicé Expert para delegar la funcion de calcular el costo total a
        la clase Recipe. Debido a que debe calcular un resultado en base a valores
        que existen en otras clases, utilizando Expert delegamos el calculo del subtotal
        a las clases que si conocen esa informacion.
        
        A su vez delegué la función de conseguir el texto de la receta a esta clase, ya que
        es la que conoce cada producto y maquinaria; para que luego este texto sea impreso por 
        la clase ConsolePrinter, esto siguiendo el SRP para que cada clase tenga una sola responsabilidad
        */
       
        public string GetRecipeText()
        {
            StringBuilder text = new StringBuilder($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                text.Append($"\n{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
            text.Append(($"\nCoste total de producción: {this.GetProductionCost()}"));
            return text.ToString();
        }
    }
}