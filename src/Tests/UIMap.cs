namespace Tests
{
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    
    
    public partial class UIMap
    {
        /// <summary>
        /// Проверяет правильность результата в листбоксе при введении слова "малако". 
        /// </summary>
        public void ResultViewManyItemsAssert()
        {
            #region Variable Declarations
            WinList uILbClosestWordsList = this.UIЛабораторная1Window.UILbClosestWordsWindow.UILbClosestWordsList;
            #endregion

            // assert
            Assert.AreEqual(uILbClosestWordsList.Items.Count, 8);
            Assert.AreEqual(uILbClosestWordsList.Items[0].GetProperty("Value"), "Бамако");
            Assert.AreEqual(uILbClosestWordsList.Items[1].GetProperty("Value"), "далеко");
            Assert.AreEqual(uILbClosestWordsList.Items[2].GetProperty("Value"), "макака");
            Assert.AreEqual(uILbClosestWordsList.Items[3].GetProperty("Value"), "малага");
            Assert.AreEqual(uILbClosestWordsList.Items[4].GetProperty("Value"), "малаец");
            Assert.AreEqual(uILbClosestWordsList.Items[5].GetProperty("Value"), "молоко");
            Assert.AreEqual(uILbClosestWordsList.Items[6].GetProperty("Value"), "облако");
            Assert.AreEqual(uILbClosestWordsList.Items[7].GetProperty("Value"), "салака");
        }

        /// <summary>
        /// Проверяет правильность результата в листбоксе при введении слова "testing". 
        /// </summary>
        public void ResultViewSingleItemsAssert()
        {
            #region Variable Declarations
            WinList uILbClosestWordsList = this.UIЛабораторная1Window.UILbClosestWordsWindow.UILbClosestWordsList;
            #endregion

            // assert
            Assert.AreEqual(uILbClosestWordsList.Items.Count, 1);
            Assert.AreEqual(uILbClosestWordsList.Items[0].GetProperty("Value"), "testing");
        }
    }
}
