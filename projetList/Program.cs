using System;


namespace Encapsulation
{
    class MainProgram
    {
        public static void Main(string[] args)
        {
            //Creation de la liste
            List<string> listCollection = new List<string>();

            //Ajout des 3 chaines de caractères 

            listCollection.Add(" Paris ");
            listCollection.Add(" est une belle ville. ");
            listCollection.Add("Mais il peut y avoir des problemes de transports.");


            //Suppresion de 2 elements de la liste
            listCollection.RemoveAt(0);
            listCollection.Remove("Mais il peut y avoir des problemes de transports.");

            // Modification du second element de la liste
            //Mais il n'en reste plus qu'un à ce niveau la

            listCollection[0] = "wild school";

            foreach (string item in listCollection)
            {
                Console.WriteLine(item);
            }
        }
    }
}