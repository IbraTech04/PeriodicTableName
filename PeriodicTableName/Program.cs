using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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
                    ElementsFromName[i] = null;
                }
            }

            ElementsFromName = ElementsFromName.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().ToList();

            /*foreach (string i in ElementsFromName)
            {
                Console.WriteLine(i);
            }*/

            for (int i = 0; i < Math.Pow(ElementsFromName.Count, ElementsFromName.Count); i++)
            {
                ElementsFromName.Shuffle();
                string Something = string.Join("", ElementsFromName);
                string somethingElse = string.Join(" ", ElementsFromName);
                if (Something.Length < enteredName.Length)
                {
                    break;
                }
                if (Something.Substring(0,enteredName.Length) == (enteredName))
                {
                    Console.WriteLine("\nCongratulations! Your name can be made from the periodic table:");

                    string finalString = "";
                    int index = 0;
                    for (int u = 0; u < ElementsFromName.Count; u++)
                    {
                        string temp = ElementsFromName[u];
                        if (temp.Length == 1)
                        {
                            index+= 2;
                            if (temp == enteredName.Substring(enteredName.Length - 1))
                            {
                                index--;
                                break;
                            }
                        }
                        else
                        {
                            index += 3;
                            if (temp == enteredName.Substring(enteredName.Length - 2))
                            {
                                index--;
                                break;
                            }
                        }
                    }

                    finalString = somethingElse.Substring(0, index);

                    Console.WriteLine("Debug " + finalString);

                    string[] elementsInName = finalString.Split(' ');
                    
                    Elements = Elements.Select(s => s.ToUpper()).ToArray();

                    for (int j = 0; j < elementsInName.Length; j++)
                    {
                        int newIndex = Array.IndexOf(Elements, elementsInName[j].ToUpper());
                        if (newIndex != -1)
                        {
                            Console.WriteLine($"\n{ ElementNames[newIndex]} \n Element Number {newIndex+1} \n Element Symbol: {Elements[newIndex]}");
                        }
                    }
                    Console.WriteLine();
                    foreach (string z in elementsInName)
                    {
                        if (z != String.Empty)
                        {
                            if (z.Length > 1)
                            {
                                Console.Write($"{char.ToUpper(z[0]) + z.Substring(1)} ");
                            }
                            else
                            {
                                Console.Write($"{char.ToUpper(z[0])} ");
                            }
                        }
                    }
                    return;
                }
            }
            Console.WriteLine("\nUnfortunately your name cannot be spelled out by the elements of the periodic table");
        }
    }
    static class test { 
        private static Random rng = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}

