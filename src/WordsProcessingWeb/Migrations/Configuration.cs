namespace WordsProcessingWeb.Migrations
{
    using System;
    using System.Collections.Generic;
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
            context.Configuration.AutoDetectChangesEnabled = false;

            Dictionary rusDictionary = new Dictionary { Name = "Rus" };
            Dictionary UKDictionary = new Dictionary { Name = "UK" };
            context.Dictionaries.Add(rusDictionary);
            context.Dictionaries.Add(UKDictionary);
            context.SaveChanges();

            string DataPath = AppDomain.CurrentDomain.BaseDirectory + "/../App_Data/TxtDictionaries";

            StreamReader rusStream = new StreamReader(DataPath + "/pro-lingRus.txt");
            string line;
            List<Word> words = new List<Word>();
            while ((line = rusStream.ReadLine()) != null)
            {
                words.Add(new Word { Text = line, Dictionary = rusDictionary });
            }
            rusStream.Close();
            context.Words.AddRange(words);
            context.SaveChanges();

            StreamReader UKStream = new StreamReader(DataPath + "/UK.txt");
            words.Clear();
            while ((line = UKStream.ReadLine()) != null)
            {
                words.Add(new Word { Text = line, Dictionary = UKDictionary });
            }
            UKStream.Close();
            context.Words.AddRange(words);
            context.SaveChanges();         
        }
    }
}
