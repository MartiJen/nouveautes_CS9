using System;

namespace nouveautes_CS9
{
    struct PersonneStruct
    {
        public string nom { get; set; }
        public int age { get; set; }

        public void Afficher()
        {
            Console.WriteLine("Nom " + nom + " - age " + age + " ans");
        }
    }

    /*ecord PersonneRecord
    {
        public string nom { get; set; }
        public int age { get; set; }

        public PersonneRecord(string nom, int age)
        {
            this.nom = nom;
            this.age = age;
        }

        public void Deconstruct(out string nom, out int age)
        {
            nom = this.nom;
            age = this.age;
        }

        public void Afficher()
        {
            Console.WriteLine("Nom " + nom + " - age " + age + " ans");
        }
    }*/

    // Immutable
    record PersonneRecord(string nom, int age);

    record PersonneRecordAffichable : PersonneRecord
    {
        public PersonneRecordAffichable(string nom, int age) : base(nom, age)
        {
        }

        public void Afficher()
        {
            Console.WriteLine("Nom " + nom + " - age " + age + " ans");
        }
    }

    class PersonneClass
    {
        public string nom { get; set; }
        public int age { get; set; }

        public void Afficher()
        {
            Console.WriteLine("Nom " + nom + " - age " + age + " ans");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Passage par valeur
            /*int a = 5;
            int b = 10;

            b = a;
            a = 6;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = ", +b);*/

            // Passage par réference
            var personne1 = new PersonneRecordAffichable("Toto", 20); //{ nom = "toto", age = 20 };
            var personne2 = personne1 with { nom = "Tata" };

            var (nom, age) = personne1;

            Console.WriteLine("nom: " + personne1.nom);
            Console.WriteLine("nom; " + nom);
            Console.WriteLine("age: " + age);

            personne1.Afficher();
            //personne2.Afficher();

            //Console.WriteLine(personne1.Equals(personne2));

            /* Types simples (int, float, char...) -> Value type (valeur)
             * structure -> Value Type (valeur = les valeurs des champs)
             * class -> Reference type (valeur = adresse de l'objet)
             * List<string> -> Reference type (valeur = adresse de l'objet)
             */
        }
    }
}
