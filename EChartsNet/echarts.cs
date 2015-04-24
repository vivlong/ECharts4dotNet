using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace EChartsNet
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class echarts : UserControl
    {
        public echarts()
        {
            InitializeComponent();
        }
        public object option { get; set; }
        private bool blnDocumentLoaded = false;
        private bool blnDynamicData = false;

        public string param;
        [Category("echarts"), Description("Get DBClick return params.\nGet DBClick return params")]
        private string strParam
        {
            get { return param; }
            set {
                param = value;
                if (DbClickReturnParam != null)
                {
                    DbClickReturnParam(this);
                }
            }
        }
        public void initialECharts(bool dynamicData)
        {
            blnDynamicData = dynamicData;
            if (blnDocumentLoaded)
            {
                Object[] objArray = new Object[1];
                objArray[0] = (Object)this.option;
                if (blnDynamicData)
                {
                    this.webBrowser1.Document.InvokeScript("showDynamic", objArray);
                }
                else
                {
                    this.webBrowser1.Document.InvokeScript("showChart", objArray);
                }
            }
            else {
                string strHtml = Application.StartupPath + @"\assets\echarts.html";
                if (File.Exists(strHtml))
                {
                    this.webBrowser1.Navigate(strHtml);
                    this.webBrowser1.ObjectForScripting = this;
                }
            }            
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Object[] objArray = new Object[1];
            objArray[0] = (Object)this.option;
            this.webBrowser1.Document.InvokeScript("showChart", objArray);
            objArray[0] = (Object)this.Height;
            this.webBrowser1.Document.InvokeScript("setPosition", objArray);
            blnDocumentLoaded = true;
        }
        private void webBrowser1_SizeChanged(object sender, EventArgs e)
        {
            if (blnDocumentLoaded)
            {
                Object[] objArray = new Object[1];
                objArray[0] = (Object)this.Height;
                this.webBrowser1.Document.InvokeScript("setPosition", objArray);
            }
        }
        public void showDetail(string strJsRetunedParam)
        {
            strParam = JsonConvert.SerializeObject((object)JsonConvert.DeserializeObject(strJsRetunedParam, typeof(echartsParam)));
        }

        public delegate void DbClickHandle(object sender);
        public event DbClickHandle DbClickReturnParam;
    }
}
