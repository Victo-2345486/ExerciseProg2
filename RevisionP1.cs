using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon
{
    public class RevisionP1
    {
        /// <summary>
        /// Écrit a la console "Allô p2"
        /// </summary>
        public static void Exercice1()
        {
            Console.WriteLine("Allô p2");
        }
        /// <summary>
        /// Écrit a la console Premier Entier : nb1 Deuxième Entier : nb2
        /// </summary>
        /// <param name="nb1">Nombre 1</param>
        /// <param name="nb2">Nombre 2</param>
        public static void Exercice2(int nb1, int nb2)
        {
            Console.WriteLine($"Premier entier : {nb1} \nDeuxième entier : {nb2}");
        }
        /// <summary>
        /// Addition deux nombre
        /// </summary>
        /// <param name="nb1">Nombre 1</param>
        /// <param name="nb2">Nombre 1</param>
        /// <returns>Return les deux nombres additionner</returns>
        public static int Exercice3(int nb1, int nb2)
        {
            int nb3 = nb1 + nb2;
            return nb3;
        }
        /// <summary>
        /// Écrit un nombre et le retourne
        /// </summary>
        /// <returns>Le nombre inscrit</returns>
        public static int Exercice4()
        {
            int nb1;
            Console.WriteLine("Inscriver un nombre");
            int.TryParse(Console.ReadLine(), out nb1);
            return nb1;
        }
        /// <summary>
        /// Écrit un nombre et le retourne mais si le nombre est 0 ou plus petit = -1
        /// </summary>
        /// <returns>Le nombre Écrit ou 0</returns>
        public static int Exercice5()
        {
            int nb1;
            Console.WriteLine("Inscriver un nombre");
            int.TryParse(Console.ReadLine(), out nb1);

            if (nb1 > 0)
            {

            }
            else if (nb1 <= 0)
            {
                nb1 = -1;
            }

            return nb1;
        }
        /// <summary>
        /// Écrit un nombre et le retourne et recommence tant qu'il est plus petit que 10
        /// </summary>
        /// <returns>Le nombre inscrit</returns>
        public static int Exercice6()
        {
            int nb1;
            Console.WriteLine("Inscriver un nombre");
            int.TryParse(Console.ReadLine(), out nb1);

            if (nb1 < 10)
            {
                Console.WriteLine(nb1);
                Exercice6();
            }
            else if (nb1 > 10)
            {
                Console.WriteLine(nb1);
            }

            return nb1;
        }
        /// <summary>
        /// Diviser les nombre en paramêtre
        /// </summary>
        /// <param name="nb1">Nombre 1</param>
        /// <param name="nb2">Nombre 2</param>
        /// <returns>Le resultat</returns>
        public static int Exercice7(int nb1, int nb2)
        {
            int tableau = nb1 / nb2;
            return tableau;
        }
        /// <summary>
        /// Crée un tableau avec le nombre en paramêtre
        /// </summary>
        /// <param name="nb1">Nombre 1</param>
        /// <returns>Le tableau créer</returns>
        public static int[] Exercice8(int nb1)
        {
            int[] nb2 = new int[nb1];
            return nb2;
        }
        /// <summary>
        /// Crée un tableau et le remplie de nombre aléatoire
        /// </summary>
        /// <param name="nb1">Longueur du tableau</param>
        /// <param name="nb2">Plus petit nombre</param>
        /// <param name="nb3">Plus Grand nombre</param>
        /// <returns>Le Tableau</returns>
        public static int[] Exercice9(int nb1, int nb2, int nb3)
        {
            int[] tableau = new int[nb1];

            Random rgn = new Random();


            for (int i = 0; i < tableau.Length; i++)
            {
                tableau[i] = rgn.Next(nb2, nb3 + 1);
            }

            return tableau;
        }
        /// <summary>
        /// Crée un tableau et le remplie de nombre aléatoire
        /// </summary>
        /// <param name="nb1">Longueur du tableau</param>
        /// <param name="nb2">Nombre inférieur ou égal au nombre 3</param>
        /// <param name="nb3">Plus Grand nombre</param>
        /// <returns>Le Tableau</returns>
        public static int[] Exercice10(int nb1, int nb2, int nb3)
        {
            int[] tableau = new int[nb1];
            Random rng = new Random();

            for (int i = 0; i < tableau.Length; i++)
            {
                tableau[i] = rng.Next(nb2, nb3 + 1);
            }

            return tableau;
        }
    }
}
