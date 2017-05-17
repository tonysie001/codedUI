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
using AutoInputI.UIMaps.SPurchaseClasses;
using AutoInputI.UIMaps.ConvertClasses;

namespace AutoInputI
{
    /// <summary>
    /// CodedUITest1 的摘要说明
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
        }



        [TestMethod]
        //[Ignore]
        [DataSource("InMoney")]
        public void CodedUITestMethod1()
        {
            UIMaps.InMoneyClasses.InMoney im = new UIMaps.InMoneyClasses.InMoney();
            im.InMoneyMethodParams.UIItemEditText = testContextInstance.DataRow["account"].ToString();
            im.InMoneyMethodParams.UIItemEditText1 = testContextInstance.DataRow["money"].ToString();

            im.InMoneyMethod();


            // 若要为此测试生成代码，请从快捷菜单中选择“为编码的 UI 测试生成代码”，然后选择菜单项之一。
        }

        [TestMethod]
        [Ignore]
        [DataSource("RPurchase")]
        public void CodedUITestMethod2()
        {
            UIMaps.RPurchaseClasses.RPurchase rp = new UIMaps.RPurchaseClasses.RPurchase();
            rp.RPurchaseMethodParams.UIItemEditText = testContextInstance.DataRow["account"].ToString();
            rp.RPurchaseMethodParams.UIItemEditSendKeys = testContextInstance.DataRow["password"].ToString();
            rp.RPurchaseMethodParams.UIItemEditText1 = testContextInstance.DataRow["fundcode"].ToString();
            rp.RPurchaseMethodParams.UIItemEditText2 = testContextInstance.DataRow["money"].ToString();
            rp.RPurchaseMethodParams.UIItemComboBoxSelectedItem1 = testContextInstance.DataRow["discount"].ToString();
            rp.RPurchaseMethodParams.UIItemComboBoxSelectedItem = testContextInstance.DataRow["buytype"].ToString();
            rp.RPurchaseMethodParams.UIItemComboBoxSelectedItem2 = testContextInstance.DataRow["ftype"].ToString();
            rp.RPurchaseMethod();
        }


        [TestMethod]
        //[Ignore]
        [DataSource("SPurchase")]
        public void CodedUITestMethod3()
        {
            UIMaps.SPurchaseClasses.SPurchase sp = new UIMaps.SPurchaseClasses.SPurchase();
            sp.SPurchaseMethodParams.accounttextboxText = testContextInstance.DataRow["account"].ToString();
            sp.SPurchaseMethodParams.UIItemEditSendKeys = testContextInstance.DataRow["password"].ToString();
            sp.SPurchaseMethodParams.UIItemEditText = testContextInstance.DataRow["fundcode"].ToString();
            sp.SPurchaseMethodParams.textedit1Text = testContextInstance.DataRow["money"].ToString();
            sp.SPurchaseMethodParams.UIItemComboBoxSelectedItem = testContextInstance.DataRow["ftype"].ToString();
            sp.SPurchaseMethodParams.UIItemComboBoxSelectedItem1 = testContextInstance.DataRow["discount"].ToString();
            SPurchaseMethodParams.fundname = testContextInstance.DataRow["fundname"].ToString();
            sp.SPurchaseMethod();
        }


        [TestMethod]
        //[Ignore]
        [DataSource("Sell")]
        public void CodedUITestMethod4()
        {
            UIMaps.SellClasses.Sell sell = new UIMaps.SellClasses.Sell();
            sell.SellMethodParams.UIItemEditText = testContextInstance.DataRow["account"].ToString();
            sell.SellMethodParams.UIItemEditSendKeys1 = testContextInstance.DataRow["password"].ToString();
            sell.SellMethodParams.UIItemEditText1 = testContextInstance.DataRow["fundcode"].ToString();
            sell.SellMethodParams.UIItemEditText2 = testContextInstance.DataRow["money"].ToString();
            sell.SellMethodParams.UIItemComboBoxSelectedItem = testContextInstance.DataRow["selltype"].ToString();
            sell.SellMethodParams.UIItemComboBoxSelectedItem1 = testContextInstance.DataRow["ftype"].ToString();
            sell.SellMethodParams.UIItemComboBoxSelectedItem2 = testContextInstance.DataRow["discount"].ToString();
            sell.SellMethodParams.UIItemComboBoxSelectedItem3 = testContextInstance.DataRow["hdiscount"].ToString();
            sell.SellMethod();
        }



        [TestMethod]
       // [Ignore]
        [DataSource("Convert")]
        public void CodedUITestMethod5()
        {
            UIMaps.ConvertClasses.Convert convert = new UIMaps.ConvertClasses.Convert();
            convert.ConvertMethodParams.UIItemEditText = testContextInstance.DataRow["account"].ToString();
            convert.ConvertMethodParams.UIItemEditSendKeys = testContextInstance.DataRow["password"].ToString();
            ConvertMethodParams.sfundcode = testContextInstance.DataRow["sfundcode"].ToString();
            ConvertMethodParams.tfundcode = testContextInstance.DataRow["tfundcode"].ToString();
            convert.ConvertMethodParams.UIItemEditText1 = testContextInstance.DataRow["money"].ToString();
            convert.ConvertMethodParams.UIItemComboBoxSelectedItem = testContextInstance.DataRow["discount"].ToString();
            convert.ConvertMethodParams.UIItemComboBoxSelectedItem1 = testContextInstance.DataRow["hdiscount"].ToString();
            convert.ConvertMethodParams.UIItemComboBoxSelectedItem2 = testContextInstance.DataRow["bdiscount"].ToString();
            convert.ConvertMethodParams.UIItemComboBoxSelectedItem3 = testContextInstance.DataRow["ftype"].ToString();
            convert.ConvertMethod();
        }



        [TestMethod]
        [Ignore]
        [DataSource("Convert")]
        public void CodedUITestMethod6()
        {
            UIMaps.Convert1Classes.Convert1 convert1 = new UIMaps.Convert1Classes.Convert1();
            convert1.ConvertMethod1Params.UIItemEditText = testContextInstance.DataRow["account"].ToString();
            convert1.ConvertMethod1Params.UIItemEditSendKeys1 = testContextInstance.DataRow["password"].ToString();
            // string sfundcode = testContextInstance.DataRow["sfundcode"].ToString();
            // convert1.ConvertMethod1Params.UIItemEditText1 = testContextInstance.DataRow["sfundcode"].ToString();
            //   convert1.ConvertMethod1Params.UIItemEditText3 = testContextInstance.DataRow["money"].ToString();
            //  convert1.ConvertMethod1Params.UIItemEditText2 = testContextInstance.DataRow["tfundcode"].ToString();
            //convert1.ConvertMethod1Params.UIItemComboBoxSelectedItem = testContextInstance.DataRow["discount"].ToString();
            //convert1.ConvertMethod1Params.UIItemComboBoxSelectedItem1 = testContextInstance.DataRow["hdiscount"].ToString();
            //convert1.ConvertMethod1Params.UIItemComboBoxSelectedItem2 = testContextInstance.DataRow["bdiscount"].ToString();
            //convert1.ConvertMethod1Params.UIItemComboBoxSelectedItem3 = testContextInstance.DataRow["ftype"].ToString();
            convert1.ConvertMethod1();
        }


        #region 附加测试特性

        // 编写测试时，可以使用以下附加特性: 

        ////运行每项测试之前使用 TestInitialize 运行代码 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // 若要为此测试生成代码，请从快捷菜单中选择“为编码的 UI 测试生成代码”，然后选择菜单项之一。
        //}

        ////运行每项测试之后使用 TestCleanup 运行代码
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // 若要为此测试生成代码，请从快捷菜单中选择“为编码的 UI 测试生成代码”，然后选择菜单项之一。
        //}

        #endregion

        /// <summary>
        ///获取或设置测试上下文，该上下文提供
        ///有关当前测试运行及其功能的信息。
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
    }
}
