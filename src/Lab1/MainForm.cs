using Ninject;
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
    /// <summary>
    /// Класс MainForm
    /// описывает интерфейс приложения
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Конструктор MainForm
        /// инициализирует объект класса и заполняет члены начальными значениями
        /// </summary>
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

        /// <summary>
        /// Метод AddClosestWordsToList
        /// выводит в объект ListBox интерфейса список слов с минимальным редакционным расстоянием
        /// по отношению к введенному слову
        /// </summary>
        /// <param name="closestWords"></param>
        private void AddClosestWordsToList(List<string> closestWords)
        {
            lbClosestWords.Items.Clear();
            for (int i = 0; i < closestWords.Count; i++)
            {
                lbClosestWords.Items.Add(closestWords[i]);
            }
        }

        /// <summary>
        /// Метод btnFindClosestWords_Click
        /// обрабатывает нажатие кнопки "Поиск",
        /// запускает в отдельном потоке поиск слов по словарю, у которых
        /// редакционное расстояние минимально по отношению к введенному слову
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Метод OnDictionaryProcessingComplete
        /// вызывает метод для вывода списка найденных слов на экран.
        /// Метод выполняется по окончанию поиска слов по словарю
        /// </summary>
        /// <param name="task"></param>
        private void OnDictionaryProcessingComplete(Task<List<string>> task)
        {
            Invoke(new Action<List<string>>(AddClosestWordsToList), task.Result);
            toolStripStatusLabel.Text = "Готово";
        }

        /// <summary>
        /// Метод MainForm_Load
        /// обновляет интерфейс при его загрузке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "";
        }
    }
}
