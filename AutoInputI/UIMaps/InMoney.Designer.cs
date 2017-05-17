﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      此代码由编码的 UI 测试生成器生成。
//      版本: 14.0.0.0
//
//      如果重新生成代码，则更改此文件可能会导致错误的行为，
//      并将丢失这些更改。
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace AutoInputI.UIMaps.InMoneyClasses
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("编码的 UI 测试生成器", "14.0.23107.0")]
    public partial class InMoney
    {
        
        /// <summary>
        /// InMoneyMethod - 使用“InMoneyMethodParams”将参数传递到此方法中。
        /// </summary>
        public void InMoneyMethod()
        {
            #region Variable Declarations
            WinTreeItem uI资金存入TreeItem = this.UI柜台销售系统Window.UIItemWindow.UIItemTree.UI资金管理TreeItem.UI资金存入TreeItem;
            WinEdit uIItemEdit = this.UI资金存入Window.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = this.UI资金存入Window.UIItemWindow1.UIItemEdit;
            WinComboBox uIItemComboBox = this.UI资金存入Window.UIItemWindow2.UIItemComboBox;
            WinListItem uIItem001民生银行上海分行营业部ListItem = this.UIItemWindow.UIItemWindow1.UIItemList.UIItem001民生银行上海分行营业部ListItem;
            WinButton uI确定OButton = this.UI资金存入Window.UIItemWindow3.UI资金存入Client.UI确定OButton;
            WinControl uI提示Dialog = this.UI提示Window.UI提示Dialog;
            WinButton uI是YButton = this.UI提示Window.UI是YWindow.UI是YButton;
            WinButton uI关闭CButton = this.UI返回信息Window.UIItemWindow.UI返回信息Client.UI关闭CButton;
            WinButton uI否NButton = this.UI提示Window.UI否NWindow.UI否NButton;
            WinButton uI关闭CButton1 = this.UI资金存入Window.UIItemWindow3.UI资金存入Client.UI关闭CButton;
            #endregion

            // 双击 “资金管理” -> “资金存入” 树项目
            Mouse.DoubleClick(uI资金存入TreeItem, new Point(23, 18));

            // 在 文本框 中键入“0015”
            uIItemEdit.Text = this.InMoneyMethodParams.UIItemEditText;

            // 在 文本框 中键入“10000”
            uIItemEdit1.Text = this.InMoneyMethodParams.UIItemEditText1;

            // 单击 组合框
            Mouse.Click(uIItemComboBox, new Point(143, 8));

            // 单击 “001|民生银行上海分行营业部” 列表项
            Mouse.Click(uIItem001民生银行上海分行营业部ListItem, new Point(135, 1));

            // 单击 “确定&O” 按钮
            Mouse.Click(uI确定OButton, new Point(49, 17));

            // 单击 “提示” Dialog
            Mouse.Click(uI提示Dialog, new Point(108, 101));

            // 单击 “是(&Y)” 按钮
            Mouse.Click(uI是YButton, new Point(60, 10));

            // 单击 “关闭&C” 按钮
            Mouse.Click(uI关闭CButton, new Point(41, 7));

            // 单击 “否(&N)” 按钮
            Mouse.Click(uI否NButton, new Point(39, 19));

            // 单击 “关闭&C” 按钮
            Mouse.Click(uI关闭CButton1, new Point(33, 5));
        }
        
        #region Properties
        public virtual InMoneyMethodParams InMoneyMethodParams
        {
            get
            {
                if ((this.mInMoneyMethodParams == null))
                {
                    this.mInMoneyMethodParams = new InMoneyMethodParams();
                }
                return this.mInMoneyMethodParams;
            }
        }
        
        public UI柜台销售系统Window UI柜台销售系统Window
        {
            get
            {
                if ((this.mUI柜台销售系统Window == null))
                {
                    this.mUI柜台销售系统Window = new UI柜台销售系统Window();
                }
                return this.mUI柜台销售系统Window;
            }
        }
        
        public UI资金存入Window UI资金存入Window
        {
            get
            {
                if ((this.mUI资金存入Window == null))
                {
                    this.mUI资金存入Window = new UI资金存入Window();
                }
                return this.mUI资金存入Window;
            }
        }
        
        public UIItemWindow4 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow4();
                }
                return this.mUIItemWindow;
            }
        }
        
        public UI提示Window UI提示Window
        {
            get
            {
                if ((this.mUI提示Window == null))
                {
                    this.mUI提示Window = new UI提示Window();
                }
                return this.mUI提示Window;
            }
        }
        
        public UI返回信息Window UI返回信息Window
        {
            get
            {
                if ((this.mUI返回信息Window == null))
                {
                    this.mUI返回信息Window = new UI返回信息Window();
                }
                return this.mUI返回信息Window;
            }
        }
        #endregion
        
        #region Fields
        private InMoneyMethodParams mInMoneyMethodParams;
        
        private UI柜台销售系统Window mUI柜台销售系统Window;
        
        private UI资金存入Window mUI资金存入Window;
        
        private UIItemWindow4 mUIItemWindow;
        
        private UI提示Window mUI提示Window;
        
        private UI返回信息Window mUI返回信息Window;
        #endregion
    }
    
    /// <summary>
    /// 要传递到“InMoneyMethod”中的参数
    /// </summary>
    [GeneratedCode("编码的 UI 测试生成器", "14.0.23107.0")]
    public class InMoneyMethodParams
    {
        
        #region Fields
        /// <summary>
        /// 在 文本框 中键入“0015”
        /// </summary>
        public string UIItemEditText = "0015";
        
        /// <summary>
        /// 在 文本框 中键入“10000”
        /// </summary>
        public string UIItemEditText1 = "10000";
        #endregion
    }
    
    [GeneratedCode("编码的 UI 测试生成器", "14.0.23107.0")]
    public class UI柜台销售系统Window : WinWindow
    {
        
        public UI柜台销售系统Window()
        {
            #region 搜索条件
            this.SearchProperties[WinWindow.PropertyNames.Name] = "柜台销售系统";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "TMainForm";
            this.WindowTitles.Add("柜台销售系统");
            #endregion
        }
        
        #region Properties
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this);
                }
                return this.mUIItemWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow mUIItemWindow;
        #endregion
    }
    
    [GeneratedCode("编码的 UI 测试生成器", "14.0.23107.0")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region 搜索条件
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "TTreeView";
            this.WindowTitles.Add("柜台销售系统");
            #endregion
        }
        
        #region Properties
        public UIItemTree UIItemTree
        {
            get
            {
                if ((this.mUIItemTree == null))
                {
                    this.mUIItemTree = new UIItemTree(this);
                }
                return this.mUIItemTree;
            }
        }
        #endregion
        
        #region Fields
        private UIItemTree mUIItemTree;
        #endregion
    }
    
    [GeneratedCode("编码的 UI 测试生成器", "14.0.23107.0")]
    public class UIItemTree : WinTree
    {
        
        public UIItemTree(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region 搜索条件
            this.WindowTitles.Add("柜台销售系统");
            #endregion
        }
        
        #region Properties
        public UI资金管理TreeItem UI资金管理TreeItem
        {
            get
            {
                if ((this.mUI资金管理TreeItem == null))
                {
                    this.mUI资金管理TreeItem = new UI资金管理TreeItem(this);
                }
                return this.mUI资金管理TreeItem;
            }
        }
        #endregion
        
        #region Fields
        private UI资金管理TreeItem mUI资金管理TreeItem;
        #endregion
    }
    
    [GeneratedCode("编码的 UI 测试生成器", "14.0.23107.0")]
    public class UI资金管理TreeItem : WinTreeItem
    {
        
        public UI资金管理TreeItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region 搜索条件
            this.SearchProperties[WinTreeItem.PropertyNames.Name] = "资金管理";
            this.SearchProperties["Value"] = "0";
            this.WindowTitles.Add("柜台销售系统");
            #endregion
        }
        
        #region Properties
        public WinTreeItem UI资金存入TreeItem
        {
            get
            {
                if ((this.mUI资金存入TreeItem == null))
                {
                    this.mUI资金存入TreeItem = new WinTreeItem(this);
                    #region 搜索条件
                    this.mUI资金存入TreeItem.SearchProperties[WinTreeItem.PropertyNames.Name] = "资金存入";
                    this.mUI资金存入TreeItem.SearchProperties["Value"] = "1";
                    this.mUI资金存入TreeItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    this.mUI资金存入TreeItem.SearchConfigurations.Add(SearchConfiguration.NextSibling);
                    this.mUI资金存入TreeItem.WindowTitles.Add("柜台销售系统");
                    #endregion
                }
                return this.mUI资金存入TreeItem;
            }
        }
        #endregion
        
        #region Fields
        private WinTreeItem mUI资金存入TreeItem;
        #endregion
    }
    
    [GeneratedCode("编码的 UI 测试生成器", "14.0.23107.0")]
    public class UI资金存入Window : WinWindow
    {
        
        public UI资金存入Window()
        {
            #region 搜索条件
            this.SearchProperties[WinWindow.PropertyNames.Name] = "资金存入";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "TFrmCapitalIn";
            this.WindowTitles.Add("资金存入");
            #endregion
        }
        
        #region Properties
        public UIItemWindow1 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow1(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIItemWindow11 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow11(this);
                }
                return this.mUIItemWindow1;
            }
        }
        
        public UIItemWindow2 UIItemWindow2
        {
            get
            {
                if ((this.mUIItemWindow2 == null))
                {
                    this.mUIItemWindow2 = new UIItemWindow2(this);
                }
                return this.mUIItemWindow2;
            }
        }
        
        public UIItemWindow3 UIItemWindow3
        {
            get
            {
                if ((this.mUIItemWindow3 == null))
                {
                    this.mUIItemWindow3 = new UIItemWindow3(this);
                }
                return this.mUIItemWindow3;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow1 mUIItemWindow;
        
        private UIItemWindow11 mUIItemWindow1;
        
        private UIItemWindow2 mUIItemWindow2;
        
        private UIItemWindow3 mUIItemWindow3;
        #endregion
    }
    
    [GeneratedCode("编码的 UI 测试生成器", "14.0.23107.0")]
    public class UIItemWindow1 : WinWindow
    {
        
        public UIItemWindow1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region 搜索条件
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "THsEdit";
            this.SearchProperties[WinWindow.PropertyNames.Instance] = "17";
            this.WindowTitles.Add("资金存入");
            #endregion
        }
        
        #region Properties
        public WinEdit UIItemEdit
        {
            get
            {
                if ((this.mUIItemEdit == null))
                {
                    this.mUIItemEdit = new WinEdit(this);
                    #region 搜索条件
                    this.mUIItemEdit.WindowTitles.Add("资金存入");
                    #endregion
                }
                return this.mUIItemEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIItemEdit;
        #endregion
    }
    
    [GeneratedCode("编码的 UI 测试生成器", "14.0.23107.0")]
    public class UIItemWindow11 : WinWindow
    {
        
        public UIItemWindow11(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region 搜索条件
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "THsEdit";
            this.SearchProperties[WinWindow.PropertyNames.Instance] = "15";
            this.WindowTitles.Add("资金存入");
            #endregion
        }
        
        #region Properties
        public WinEdit UIItemEdit
        {
            get
            {
                if ((this.mUIItemEdit == null))
                {
                    this.mUIItemEdit = new WinEdit(this);
                    #region 搜索条件
                    this.mUIItemEdit.WindowTitles.Add("资金存入");
                    #endregion
                }
                return this.mUIItemEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIItemEdit;
        #endregion
    }
    
    [GeneratedCode("编码的 UI 测试生成器", "14.0.23107.0")]
    public class UIItemWindow2 : WinWindow
    {
        
        public UIItemWindow2(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region 搜索条件
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "THsComboBox";
            this.SearchProperties[WinWindow.PropertyNames.Instance] = "2";
            this.WindowTitles.Add("资金存入");
            #endregion
        }
        
        #region Properties
        public WinComboBox UIItemComboBox
        {
            get
            {
                if ((this.mUIItemComboBox == null))
                {
                    this.mUIItemComboBox = new WinComboBox(this);
                    #region 搜索条件
                    this.mUIItemComboBox.WindowTitles.Add("资金存入");
                    #endregion
                }
                return this.mUIItemComboBox;
            }
        }
        #endregion
        
        #region Fields
        private WinComboBox mUIItemComboBox;
        #endregion
    }
    
    [GeneratedCode("编码的 UI 测试生成器", "14.0.23107.0")]
    public class UIItemWindow3 : WinWindow
    {
        
        public UIItemWindow3(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region 搜索条件
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "TPanel";
            this.SearchProperties[WinWindow.PropertyNames.Instance] = "2";
            this.WindowTitles.Add("资金存入");
            #endregion
        }
        
        #region Properties
        public UI资金存入Client UI资金存入Client
        {
            get
            {
                if ((this.mUI资金存入Client == null))
                {
                    this.mUI资金存入Client = new UI资金存入Client(this);
                }
                return this.mUI资金存入Client;
            }
        }
        #endregion
        
        #region Fields
        private UI资金存入Client mUI资金存入Client;
        #endregion
    }
    
    [GeneratedCode("编码的 UI 测试生成器", "14.0.23107.0")]
    public class UI资金存入Client : WinClient
    {
        
        public UI资金存入Client(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region 搜索条件
            this.WindowTitles.Add("资金存入");
            #endregion
        }
        
        #region Properties
        public WinButton UI确定OButton
        {
            get
            {
                if ((this.mUI确定OButton == null))
                {
                    this.mUI确定OButton = new WinButton(this);
                    #region 搜索条件
                    this.mUI确定OButton.SearchProperties[WinButton.PropertyNames.Name] = "确定O";
                    this.mUI确定OButton.WindowTitles.Add("资金存入");
                    #endregion
                }
                return this.mUI确定OButton;
            }
        }
        
        public WinButton UI关闭CButton
        {
            get
            {
                if ((this.mUI关闭CButton == null))
                {
                    this.mUI关闭CButton = new WinButton(this);
                    #region 搜索条件
                    this.mUI关闭CButton.SearchProperties[WinButton.PropertyNames.Name] = "关闭C";
                    this.mUI关闭CButton.WindowTitles.Add("资金存入");
                    #endregion
                }
                return this.mUI关闭CButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUI确定OButton;
        
        private WinButton mUI关闭CButton;
        #endregion
    }
    
    [GeneratedCode("编码的 UI 测试生成器", "14.0.23107.0")]
    public class UIItemWindow4 : WinWindow
    {
        
        public UIItemWindow4()
        {
            #region 搜索条件
            this.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "桌面";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32769";
            #endregion
        }
        
        #region Properties
        public UIItemWindow12 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow12(this);
                }
                return this.mUIItemWindow1;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow12 mUIItemWindow1;
        #endregion
    }
    
    [GeneratedCode("编码的 UI 测试生成器", "14.0.23107.0")]
    public class UIItemWindow12 : WinWindow
    {
        
        public UIItemWindow12(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region 搜索条件
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "ComboLBox";
            #endregion
        }
        
        #region Properties
        public UIItemList UIItemList
        {
            get
            {
                if ((this.mUIItemList == null))
                {
                    this.mUIItemList = new UIItemList(this);
                }
                return this.mUIItemList;
            }
        }
        #endregion
        
        #region Fields
        private UIItemList mUIItemList;
        #endregion
    }
    
    [GeneratedCode("编码的 UI 测试生成器", "14.0.23107.0")]
    public class UIItemList : WinList
    {
        
        public UIItemList(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
        }
        
        #region Properties
        public WinListItem UIItem001民生银行上海分行营业部ListItem
        {
            get
            {
                if ((this.mUIItem001民生银行上海分行营业部ListItem == null))
                {
                    this.mUIItem001民生银行上海分行营业部ListItem = new WinListItem(this);
                    #region 搜索条件
                    this.mUIItem001民生银行上海分行营业部ListItem.SearchProperties[WinListItem.PropertyNames.Name] = "001|民生银行上海分行营业部";
                    #endregion
                }
                return this.mUIItem001民生银行上海分行营业部ListItem;
            }
        }
        #endregion
        
        #region Fields
        private WinListItem mUIItem001民生银行上海分行营业部ListItem;
        #endregion
    }
    
    [GeneratedCode("编码的 UI 测试生成器", "14.0.23107.0")]
    public class UI提示Window : WinWindow
    {
        
        public UI提示Window()
        {
            #region 搜索条件
            this.SearchProperties[WinWindow.PropertyNames.Name] = "提示";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add("提示");
            #endregion
        }
        
        #region Properties
        public WinControl UI提示Dialog
        {
            get
            {
                if ((this.mUI提示Dialog == null))
                {
                    this.mUI提示Dialog = new WinControl(this);
                    #region 搜索条件
                    this.mUI提示Dialog.SearchProperties[UITestControl.PropertyNames.Name] = "提示";
                    this.mUI提示Dialog.SearchProperties[UITestControl.PropertyNames.ControlType] = "Dialog";
                    this.mUI提示Dialog.WindowTitles.Add("提示");
                    #endregion
                }
                return this.mUI提示Dialog;
            }
        }
        
        public UI是YWindow UI是YWindow
        {
            get
            {
                if ((this.mUI是YWindow == null))
                {
                    this.mUI是YWindow = new UI是YWindow(this);
                }
                return this.mUI是YWindow;
            }
        }
        
        public UI否NWindow UI否NWindow
        {
            get
            {
                if ((this.mUI否NWindow == null))
                {
                    this.mUI否NWindow = new UI否NWindow(this);
                }
                return this.mUI否NWindow;
            }
        }
        #endregion
        
        #region Fields
        private WinControl mUI提示Dialog;
        
        private UI是YWindow mUI是YWindow;
        
        private UI否NWindow mUI否NWindow;
        #endregion
    }
    
    [GeneratedCode("编码的 UI 测试生成器", "14.0.23107.0")]
    public class UI是YWindow : WinWindow
    {
        
        public UI是YWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region 搜索条件
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "6";
            this.WindowTitles.Add("提示");
            #endregion
        }
        
        #region Properties
        public WinButton UI是YButton
        {
            get
            {
                if ((this.mUI是YButton == null))
                {
                    this.mUI是YButton = new WinButton(this);
                    #region 搜索条件
                    this.mUI是YButton.SearchProperties[WinButton.PropertyNames.Name] = "是(Y)";
                    this.mUI是YButton.WindowTitles.Add("提示");
                    #endregion
                }
                return this.mUI是YButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUI是YButton;
        #endregion
    }
    
    [GeneratedCode("编码的 UI 测试生成器", "14.0.23107.0")]
    public class UI否NWindow : WinWindow
    {
        
        public UI否NWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region 搜索条件
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "7";
            this.WindowTitles.Add("提示");
            #endregion
        }
        
        #region Properties
        public WinButton UI否NButton
        {
            get
            {
                if ((this.mUI否NButton == null))
                {
                    this.mUI否NButton = new WinButton(this);
                    #region 搜索条件
                    this.mUI否NButton.SearchProperties[WinButton.PropertyNames.Name] = "否(N)";
                    this.mUI否NButton.WindowTitles.Add("提示");
                    #endregion
                }
                return this.mUI否NButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUI否NButton;
        #endregion
    }
    
    [GeneratedCode("编码的 UI 测试生成器", "14.0.23107.0")]
    public class UI返回信息Window : WinWindow
    {
        
        public UI返回信息Window()
        {
            #region 搜索条件
            this.SearchProperties[WinWindow.PropertyNames.Name] = "返回信息";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "TReturnInfoForm";
            this.WindowTitles.Add("返回信息");
            #endregion
        }
        
        #region Properties
        public UIItemWindow5 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow5(this);
                }
                return this.mUIItemWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow5 mUIItemWindow;
        #endregion
    }
    
    [GeneratedCode("编码的 UI 测试生成器", "14.0.23107.0")]
    public class UIItemWindow5 : WinWindow
    {
        
        public UIItemWindow5(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region 搜索条件
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "TPanel";
            this.SearchProperties[WinWindow.PropertyNames.Instance] = "2";
            this.WindowTitles.Add("返回信息");
            #endregion
        }
        
        #region Properties
        public UI返回信息Client UI返回信息Client
        {
            get
            {
                if ((this.mUI返回信息Client == null))
                {
                    this.mUI返回信息Client = new UI返回信息Client(this);
                }
                return this.mUI返回信息Client;
            }
        }
        #endregion
        
        #region Fields
        private UI返回信息Client mUI返回信息Client;
        #endregion
    }
    
    [GeneratedCode("编码的 UI 测试生成器", "14.0.23107.0")]
    public class UI返回信息Client : WinClient
    {
        
        public UI返回信息Client(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region 搜索条件
            this.WindowTitles.Add("返回信息");
            #endregion
        }
        
        #region Properties
        public WinButton UI关闭CButton
        {
            get
            {
                if ((this.mUI关闭CButton == null))
                {
                    this.mUI关闭CButton = new WinButton(this);
                    #region 搜索条件
                    this.mUI关闭CButton.SearchProperties[WinButton.PropertyNames.Name] = "关闭C";
                    this.mUI关闭CButton.WindowTitles.Add("返回信息");
                    #endregion
                }
                return this.mUI关闭CButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUI关闭CButton;
        #endregion
    }
}
