using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using System.Threading;


namespace Tests
{
    /// <summary>
    /// Summary description for CodedUITest
    /// </summary>
    [CodedUITest]
    public class CodedUITest
    {
        public CodedUITest()
        {
        }

        /// <summary>
        /// Запускает тестируемое приложение перед каждым функциональным тестом.
        /// </summary>
        [TestInitialize]
        public void StartApp()
        {
            ApplicationUnderTest.Launch(Environment.CurrentDirectory + @"/../../../Lab1/bin/Debug/Lab1.exe");
        }

        /// <summary>
        /// Закрывает тестируемое приложение после каждого теста.
        /// </summary>
        [TestCleanup]
        public void CloseApp()
        {
            this.UIMap.CloseAppRecordedMethod();
        }

        /// <summary>
        /// Тестирует пункт 3.SelectDictionary.3.FileSelect функциональных требований.
        /// Файл словаря должен выбираться через пункт меню Файл->Выбрать словарь, после чего он становится активным. 
        /// </summary>
        [TestMethod]
        public void FileSelectCodedUITest()
        {
            this.UIMap.FileSelectRecordedMethod();
            this.UIMap.FileSelectAssert();
        }

        /// <summary>
        /// Тестирует пункт 3.SelectDictionary.3.Reselect функциональных требований.
        /// В случае, если до этого уже был выбран какой-либо словарь, то он перестаёт быть активным и 
        /// выгружается из памяти программы, а вместо него загружается новый.  
        /// </summary>
        [TestMethod]
        public void FileReselectCodedUITest()
        {
            this.UIMap.FileReselectRecordedMethod();
            this.UIMap.FileReselectAssert();
        }

        /// <summary>
        /// Тестирует пункт 3.FindClosestWords.3.ResultView функциональных требований.
        /// Найденные слова должны выводиться в специальный ListBox.
        /// </summary>
        [TestMethod]
        public void ResultViewManyCodedUITest()
        {
            this.UIMap.ResultViewManyRecordedMethod();
            Thread.Sleep(3500);  // Даём время вычислительному потоку отработать доконца.
            this.UIMap.ResultViewManyCountAssert();
            this.UIMap.ResultViewManyItemsAssert();
        }

        /// <summary>
        /// Тестирует пункт 3.FindClosestWords.3.ResultView функциональных требований.
        /// Одно найденное слово должно вывестись в специальный ListBox.
        /// </summary>
        [TestMethod]
        public void ResultViewSingleCodedUITest()
        {
            this.UIMap.ResultViewSingleRecordedMethod();
            Thread.Sleep(3500);  // Даём время вычислительному потоку отработать доконца.
            this.UIMap.ResultViewSingleCountAssert();
            this.UIMap.ResultViewSingleItemsAssert();
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
