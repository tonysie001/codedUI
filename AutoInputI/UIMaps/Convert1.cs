namespace AutoInputI.UIMaps.Convert1Classes
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


    public partial class Convert1
    {

        /// <summary>
        /// ConvertMethod1 - 使用“ConvertMethod1Params”将参数传递到此方法中。
        /// </summary>
        public void ConvertMethod1()
        {
            #region Variable Declarations
            WinTreeItem uI基金转换TreeItem = this.UI柜台销售系统Window.UIItemWindow.UIItemTree.UI日常交易管理TreeItem.UI基金转换TreeItem;
            WinEdit uIItemEdit = this.UI基金转换Window.UIItemWindow1.UIItemEdit;
            WinEdit uIItemEdit1 = this.UI基金转换Window.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit2 = this.UI密码输入Window1.UIItemWindow.UIItemEdit;
            WinComboBox uIItemComboBox = this.UI基金转换Window.UIItemWindow11.UIItemComboBox;
            WinButton uIItemButton = this.UI基金转换Window.UIItemWindow.UI基金转换Client.UIItemButton;
            WinButton uI确定YButton = this.UI基金选择Window.UIItemWindow.UI基金选择Client.UI确定YButton;
            WinButton uIItemButton1 = this.UI基金转换Window.UIItemWindow.UI基金转换Client.UIItemButton1;
            WinButton uI关闭CButton = this.UI基金转换Window.UIItemWindow3.UI基金转换Client.UI关闭CButton;
            #endregion

            // 双击 “日常交易管理” -> “基金转换” 树项目
            Mouse.DoubleClick(uI基金转换TreeItem, new Point(68, 21));

            // 在 文本框 中键入“0015”
            uIItemEdit.Text = this.ConvertMethod1Params.UIItemEditText;

            // 在 文本框 中键入“{Enter}”
            Keyboard.SendKeys(uIItemEdit1, this.ConvertMethod1Params.UIItemEditSendKeys, ModifierKeys.None);

            // 在 文本框 中键入“********”
            Keyboard.SendKeys(uIItemEdit2, this.ConvertMethod1Params.UIItemEditSendKeys1, true);

            // 在 组合框 中键入“{Enter}”
            Keyboard.SendKeys(uIItemComboBox, this.ConvertMethod1Params.UIItemComboBoxSendKeys, ModifierKeys.None);

            // 单击 “...1” 按钮
            Mouse.Click(uIItemButton, new Point(13, 6));

            // 单击 “确定&Y” 按钮
            Mouse.Click(uI确定YButton, new Point(58, 18));

            // 单击 “...2” 按钮
            Mouse.Click(uIItemButton1, new Point(20, 19));

            // 单击 “确定&Y” 按钮
            Mouse.Click(uI确定YButton, new Point(64, 16));

            // 单击 “关闭&C” 按钮
            Mouse.Click(uI关闭CButton, new Point(24, 8));
        }

        public virtual ConvertMethod1Params ConvertMethod1Params
        {
            get
            {
                if ((this.mConvertMethod1Params == null))
                {
                    this.mConvertMethod1Params = new ConvertMethod1Params();
                }
                return this.mConvertMethod1Params;
            }
        }

        private ConvertMethod1Params mConvertMethod1Params;
    }
    /// <summary>
    /// 要传递到“ConvertMethod1”中的参数
    /// </summary>
    [GeneratedCode("编码的 UI 测试生成器", "14.0.23107.0")]
    public class ConvertMethod1Params
    {

        #region Fields
        /// <summary>
        /// 在 文本框 中键入“0015”
        /// </summary>
        public string UIItemEditText = "0015";

        /// <summary>
        /// 在 文本框 中键入“{Enter}”
        /// </summary>
        public string UIItemEditSendKeys = "{Enter}";

        /// <summary>
        /// 在 文本框 中键入“********”
        /// </summary>
        public string UIItemEditSendKeys1 = "Z835TI3Zgo9E3U/I+xdySeWoFGtRJwY4met/VPhL3eHxTL1xoGRE8/dYy6bBzzkF3OVzBgkFX7PrX99k+" +
            "Ckshmb0QCrsA+Pec7XZ46Rdq+Y=";

        /// <summary>
        /// 在 组合框 中键入“{Enter}”
        /// </summary>
        public string UIItemComboBoxSendKeys = "{Enter}";
        #endregion
    }
}
