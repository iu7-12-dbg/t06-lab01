namespace WordsProcessingWeb.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using WordsProcessingWeb.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WordsProcessingWeb.DAL.DictionaryDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WordsProcessingWeb.DAL.DictionaryDBContext context)
        {
            Dictionary rusDictionary = new Dictionary { Name = "Rus" };
            Dictionary UKDictionary = new Dictionary { Name = "UK" };
            context.Dictionaries.Add(rusDictionary);
            context.Dictionaries.Add(UKDictionary);
            context.SaveChanges();

            StreamReader rusStream = new StreamReader(@"C:\Users\valeriya\Desktop\testing\t06-lab01\src\Lab1\bin\Debug\Dictionaries\pro-lingRus.txt");
            string line;
            while ((line = rusStream.ReadLine()) != null)
            {
                Word word = new Word { Text = line, Dictionary = rusDictionary };
                context.Words.Add(word);                
            }
            rusStream.Close();
            context.SaveChanges();

            StreamReader UKStream = new StreamReader(@"C:\Users\valeriya\Desktop\testing\t06-lab01\src\Lab1\bin\Debug\Dictionaries\UK.txt");
            
            while ((line = UKStream.ReadLine()) != null)
            {
                Word word = new Word { Text = line, Dictionary = UKDictionary };
                context.Words.Add(word);                
            }
            UKStream.Close();
            context.SaveChanges();         
        }
    }
}
