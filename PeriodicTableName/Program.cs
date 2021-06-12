using System;
using System.Collections;
using System.Collections.Generic;

namespace PeriodicTableName
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> ElementsFromName = new List<String>();
            String[] Elements = { "H", "He", "Li", "Be", "B", "C", "N", "O", "F", "Ne", "Na", "Mg", "Al", "Si", "P", "S", "Cl", "Ar", "K", "Ca", "Sc", "Ti", "V", "Cr", "Mn", "Fe", "Co", "Ni", "Cu", "Zn", "Ga", "Ge", "As", "Se", "Br", "Kr", "Rb", "Sr", "Y", "Zr", "Nb", "Mo", "Tc", "Ru", "Rh", "Pd", "Ag", "Cd", "In", "Sn", "Sb", "Te", "I", "Xe", "Cs", "Ba", "La", "Ce", "Pr", "Nd", "Pm", "Sm", "Eu", "Gd", "Tb", "Dy", "Ho", "Er", "Tm", "Yb", "Lu", "Hf", "Ta", "W", "Re", "Os", "Ir", "Pt", "Au", "Hg", "Tl", "Pb", "Bi", "Po", "At", "Rn", "Fr", "Ra", "Ac", "Th", "Pa", "U", "Np", "Pu", "Am", "Cm", "Bk", "Cf", "Es", "Fm", "Md", "No", "Lr", "Rf", "Db", "Sg", "Bh", "Hs", "Mt", "Uun", "Uuu", "Uub", "Uut", "Uuq", "Uup", "Uuh", "Uus", "Uuo" };
            String[] ElementNames = { "Hydrogen", "Helium", "Lithium", "Beryllium", "Boron", "Carbon", "Nitrogen", "Oxygen", "Fluorine", "Neon", "Sodium", "Magnesium", "Aluminum", "Silicon", "Phosphorus", "Sulfur", "Chlorine", "Argon", "Potassium", "Calcium", "Scandium", "Titanium", "Vanadium", "Chromium", "Manganese", "Iron", "Cobalt", "Nickel", "Copper", "Zinc", "Gallium", "Germanium", "Arsenic", "Selenium", "Bromine", "Krypton", "Rubidium", "Strontium", "Yttrium", "Zirconium", "Niobium", "Molybdenum", "Technetium", "Ruthenium", "Rhodium", "Palladium", "Silver", "Cadmium", "Indium", "Tin", "Antimony", "Tellurium", "Iodine", "Xenon", "Cesium", "Barium", "Lanthanum", "Cerium", "Praseodymium", "Neodymium", "Promethium", "Samarium", "Europium", "Gadolinium", "Terbium", "Dysprosium", "Holmium", "Erbium", "Thulium", "Ytterbium", "Lutetium", "Hafnium", "Tantalum", "Tungsten", "Rhenium", "Osmium", "Iridium", "Platinum", "Gold", "Mercury", "Thallium", "Lead", "Bismuth", "Polonium", "Astatine", "Radon", "Francium", "Radium", "Actinium", "Thorium", "Protactinium", "Uranium", "Neptunium", "Plutonium", "Americium", "Curium", "Berkelium", "Californium", "Einsteinium", "Fermium", "Mendelevium", "Nobelium", "Lawrencium", "Rutherfordium", "Dubnium", "Seaborgium", "Bohrium", "Hassium", "Meitnerium", "Ununnilium", "Unununium", "Ununbium", "Ununtrium", "Ununquadium", "Ununpentium", "Ununhexium", "Ununseptium", "Ununoctium" };

            Console.WriteLine("Enter the name you would like to convert to periodic table elements: ");
            String enteredName = Console.ReadLine();

            for (int i = 0; i < enteredName.Length; i++) {
                ElementsFromName.Add(enteredName[i].ToString());
                if (i < enteredName.Length - 1)
                {
                    ElementsFromName.Add(enteredName[i] + "" + enteredName[i + 1]);
                }
            }
            for (int i = 0; i < ElementsFromName.Count; i++) {
                bool found = false;
                for (int j = 0; j < Elements.Length; j++)
                {
                    if (ElementsFromName[i].ToUpper() == Elements[j].ToUpper())
                    {
                        found = true;
                    }
                }
                if (!found)
                {
                    ElementsFromName[i] = " ";
                }
            }

            for (int i = 0; i < ElementsFromName.Count; i++)
            {
                if (ElementsFromName[i] == " ")
                {
                    ElementsFromName.RemoveAt(i);
                }
            }

            foreach (string s in ElementsFromName)
            {
                Console.WriteLine(s);
            }

            if ((ElementsFromName[0].Contains(enteredName[0]) || ElementsFromName[1].Contains(enteredName[0])) && (ElementsFromName[ElementsFromName.Count-1].Contains(enteredName[enteredName.Length-1]) || ElementsFromName[ElementsFromName.Count - 2].Contains(enteredName[enteredName.Length - 1])))
            {
                Console.WriteLine("Congratulations! Your name can be made from elements on the periodic table!");
            }

            else
            {
                Console.WriteLine("Sorry, your name cannot be made up from the periodic table :(");
            }
        }
    }
}

