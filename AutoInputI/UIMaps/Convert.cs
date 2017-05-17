namespace AutoInputI.UIMaps.ConvertClasses
{
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
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


    public partial class Convert
    {

        /// <summary>
        /// ConvertMethod - 使用“ConvertMethodParams”将参数传递到此方法中。
        /// </summary>
        public void ConvertMethod()
        {
            #region Variable Declarations
            WinTreeItem uI基金转换TreeItem = this.UI柜台销售系统Window.UIItemWindow.UIItemTree.UI日常交易管理TreeItem.UI基金转换TreeItem;
            WinEdit uIItemEdit = this.UI基金转换Window.UIItemWindow.UIItemEdit;
            WinButton uI打开Button = this.UI基金转换Window.UIItemWindow1.UIItemComboBox.UI打开Button;
            WinEdit uIItemEdit1 = this.UI密码输入Window.UIItemWindow.UIItemEdit;
            WinComboBox uIItemComboBox = this.UI基金转换Window.UIItemWindow1.UIItemComboBox;
            WinListItem uIItem000084ListItem = this.UIItemWindow.UIItemWindow1.UIItemList.UIItem000084ListItem;
            WinButton uI打开Button1 = this.UI基金转换Window.UIItemWindow2.UIItemComboBox.UI打开Button;
            WinListItem uIItem000178ListItem = this.UIItemWindow.UIItemWindow1.UIItemList.UIItem000178ListItem;
            WinComboBox uIItemComboBox1 = this.UI基金转换Window.UIItemWindow3.UIItemComboBox;
            WinEdit uIItemEdit2 = this.UI基金转换Window.UIItemWindow4.UIItemEdit;
            WinComboBox uIItemComboBox2 = this.UI基金转换Window.UIItemWindow5.UIItemComboBox;
            WinComboBox uIItemComboBox3 = this.UI基金转换Window.UIItemWindow6.UIItemComboBox;
            WinComboBox uIItemComboBox4 = this.UI基金转换Window.UIItemWindow7.UIItemComboBox;
            WinButton uI确定OButton = this.UI基金转换Window.UIItemWindow8.UI基金转换Client.UI确定OButton;
            WinButton uI是YButton = this.UI提示Window.UI是YWindow.UI是YButton;
            WinButton uI关闭CButton = this.UI返回信息Window.UIItemWindow.UI返回信息Client.UI关闭CButton;
            WinButton uI否NButton = this.UI提示Window.UI否NWindow.UI否NButton;
            WinButton uI关闭CButton1 = this.UI基金转换Window.UIItemWindow8.UI基金转换Client.UI关闭CButton;
            #endregion

            // 双击 “日常交易管理” -> “基金转换” 树项目
            Mouse.DoubleClick(uI基金转换TreeItem, new Point(22, 7));

            // 在 文本框 中键入“0015”
            uIItemEdit.Text = this.ConvertMethodParams.UIItemEditText;

            // 单击 “打开” 按钮
            Mouse.Click(uI打开Button, new Point(12, 7));

            // 在 文本框 中键入“********”
            Keyboard.SendKeys(uIItemEdit1, this.ConvertMethodParams.UIItemEditSendKeys, true);

            // 在 组合框 中键入“{Enter}”
            Keyboard.SendKeys(uIItemComboBox, this.ConvertMethodParams.UIItemComboBoxSendKeys, ModifierKeys.None);

            // 单击 “打开” 按钮
            Mouse.Click(uI打开Button, new Point(8, 10));

            // 单击 “000084” 列表项
            Mouse.Click(uIItem000084ListItem, new Point(36, 4));

            // 单击 “打开” 按钮
            Mouse.Click(uI打开Button1, new Point(6, 7));

            // 单击 “000178” 列表项
            Mouse.Click(uIItem000178ListItem, new Point(29, 4));

            // 在 组合框 中选择“1”
            uIItemComboBox1.SelectedItem = this.ConvertMethodParams.UIItemComboBoxSelectedItem;

            // 在 文本框 中键入“100”
            uIItemEdit2.Text = this.ConvertMethodParams.UIItemEditText1;

            // 在 组合框 中选择“1”
            uIItemComboBox2.SelectedItem = this.ConvertMethodParams.UIItemComboBoxSelectedItem1;

            // 在 组合框 中选择“1”
            uIItemComboBox3.SelectedItem = this.ConvertMethodParams.UIItemComboBoxSelectedItem2;

            // 在 组合框 中选择“A”
            uIItemComboBox4.SelectedItem = this.ConvertMethodParams.UIItemComboBoxSelectedItem3;

            // 单击 “确定&O” 按钮
            Mouse.Click(uI确定OButton, new Point(42, 14));

            // 单击 “是(&Y)” 按钮
            Mouse.Click(uI是YButton, new Point(25, 2));

            // 单击 “关闭&C” 按钮
            Mouse.Click(uI关闭CButton, new Point(59, 10));

            // 单击 “否(&N)” 按钮
            Mouse.Click(uI否NButton, new Point(68, 21));

            // 单击 “关闭&C” 按钮
            Mouse.Click(uI关闭CButton1, new Point(34, 9));
        }

        public virtual ConvertMethodParams ConvertMethodParams
        {
            get
            {
                if ((this.mConvertMethodParams == null))
                {
                    this.mConvertMethodParams = new ConvertMethodParams();
                }
                return this.mConvertMethodParams;
            }
        }

        private ConvertMethodParams mConvertMethodParams;
    }
    /// <summary>
    /// 要传递到“ConvertMethod”中的参数
    /// </summary>
    [GeneratedCode("编码的 UI 测试生成器", "14.0.23107.0")]
    public class ConvertMethodParams
    {

        #region Fields
        /// <summary>
        /// 在 文本框 中键入“0015”
        /// </summary>
        public string UIItemEditText = "0015";

        /// <summary>
        /// 在 文本框 中键入“********”
        /// </summary>
        public string UIItemEditSendKeys = "Z835TI3Zgo9E3U/I+xdySeWoFGtRJwY4met/VPhL3eHxTL1xoGRE8/dYy6bBzzkF3OVzBgkFX7PrX99k+" +
            "Ckshmb0QCrsA+Pec7XZ46Rdq+Y=";

        /// <summary>
        /// 在 组合框 中键入“{Enter}”
        /// </summary>
        public string UIItemComboBoxSendKeys = "{Enter}";

        /// <summary>
        /// 在 组合框 中选择“1”
        /// </summary>
        public string UIItemComboBoxSelectedItem = "1";

        /// <summary>
        /// 在 文本框 中键入“100”
        /// </summary>
        public string UIItemEditText1 = "100";

        /// <summary>
        /// 在 组合框 中选择“1”
        /// </summary>
        public string UIItemComboBoxSelectedItem1 = "1";

        /// <summary>
        /// 在 组合框 中选择“1”
        /// </summary>
        public string UIItemComboBoxSelectedItem2 = "1";

        /// <summary>
        /// 在 组合框 中选择“A”
        /// </summary>
        public string UIItemComboBoxSelectedItem3 = "A";



        public static string sfundcode;
        public static string tfundcode;
        #endregion
    }
}
