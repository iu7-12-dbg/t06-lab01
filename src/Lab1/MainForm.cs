﻿using Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordsProcessing;
using WordsProcessing.Algorithms;

namespace Lab1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            IKernel ninjectKernel = new StandardKernel(new NinjectConfigModule());
            CustomWordsDictionary = ninjectKernel.Get<WordsDictionary>();
            try
            {
                string[] dictionaryFileNames = ConfigurationManager.AppSettings["DictionariesFileNames"].Split(';');
                foreach (string dictionary in dictionaryFileNames)
                {
                    if (dictionary != "")
                        CustomWordsDictionary.AddWordsToDictionary(dictionary);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        WordsDictionary CustomWordsDictionary { get; set; }

        private void AddClosestWordsToList(List<string> closestWords)
        {
            lbClosestWords.Items.Clear();
            for (int i = 0; i < closestWords.Count; i++)
            {
                lbClosestWords.Items.Add(closestWords[i]);
            }
        }

        private void btnFindClosestWords_Click(object sender, EventArgs e)
        {
            try
            {
                string word = txtInputWord.Text;
                Task<List<string>> task = new Task<List<string>>(() => CustomWordsDictionary.GetClosestWords(word));
                task.ContinueWith(OnDictionaryProcessingComplete);
                toolStripStatusLabel.Text = "Поиск...";
                task.Start();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void OnDictionaryProcessingComplete(Task<List<string>> task)
        {
            Invoke(new Action<List<string>>(AddClosestWordsToList), task.Result);
            toolStripStatusLabel.Text = "Готово";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "";
        }
    }
}