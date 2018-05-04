

using System;

namespace Isen.Cs.Library.Lessons
{
    public class B_Enumerations
    {
        public void RunEnumerations()
        {
            // Affichage du label
            Console.WriteLine($"JourSemaine.Lundi = {JourSemaine.Lundi}");
            //Afficher l'entier sous-jacent
            Console.WriteLine($"JourSemaine.Lundi = {(int)JourSemaine.Lundi}");
            // int > vers valeurs d"enum
            int day4 = 4;
            JourSemaine whoIsday4 = (JourSemaine) day4;
            Console.WriteLine($"day4 = {whoIsday4}");
            //String > valeur d'enum
            string mardi = "Mardi";
            JourSemaine parsed = (JourSemaine)Enum.Parse(
                typeof(JourSemaine),
                mardi);
            Console.WriteLine($"parsed = {parsed}");
            // .Net Core / .Net > 4
            JourSemaine parsed2;
            bool didItWork = Enum.TryParse("Mercredi", out parsed2);
            Console.WriteLine($"parsed2 = {parsed2} / worked ? {didItWork}");
            var enumNames = Enum.GetNames(typeof(JourSemaine));// string[]
            var enumValues = Enum.GetValues(typeof(JourSemaine)); // JourSemaine[] sous-typé
            foreach (var enumName in enumNames) Console.WriteLine(enumName);
            foreach (JourSemaine enumValue in enumValues) Console.WriteLine((int) enumValue);

            var jour = (JourSemaine)(new Random().Next(1, 7));
            DayOfWeek foundDayOfWeek;
            switch (jour)
            {
                case JourSemaine.Lundi:
                    foundDayOfWeek = DayOfWeek.Monday;
                    break;
                case JourSemaine.Mardi:
                    foundDayOfWeek = DayOfWeek.Tuesday;
                    break;
                case JourSemaine.Mercredi:
                    foundDayOfWeek = DayOfWeek.Wednesday;
                    break;
                case JourSemaine.Jeudi:
                    foundDayOfWeek = DayOfWeek.Thursday;
                    break;
                case JourSemaine.Vendredi:
                    foundDayOfWeek = DayOfWeek.Friday;
                    break;
                case JourSemaine.Samedi:
                    foundDayOfWeek = DayOfWeek.Saturday;
                    break;
                case JourSemaine.Dimanche:
                    foundDayOfWeek = DayOfWeek.Sunday;
                    break;
                default:
                    foundDayOfWeek = DayOfWeek.Sunday;
                    break;
            }

            Console.WriteLine($" {nameof(foundDayOfWeek)} = {foundDayOfWeek}");
        }

        public enum JourSemaine
        {
            Lundi = 1,
            Mardi = 2,
            Mercredi = 3,
            Jeudi = 4,
            Vendredi = 5,
            Samedi = 6,
            Dimanche = 7,
        }

        public enum Result
        {
            succes , echec
        }
    }
}