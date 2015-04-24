using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Newtonsoft.Json;
using EChartsNet;

namespace EChartsNetTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_static_Click(this.btn_static,new EventArgs());
        }

        private void echarts1_DbClickReturnParam(object sender)
        {
            echartsParam ep = (echartsParam)JsonConvert.DeserializeObject(this.echarts1.param, typeof(echartsParam));
            MessageBox.Show(ep.name.ToString());
        }

        private void btn_static_Click(object sender, EventArgs e)
        {
            EChartsNet.echartsOption eoption = new EChartsNet.echartsOption();
            eoption.title.text = "Demo";
            eoption.tooltip.trigger = "item";
            eoption.legend.data = new ArrayList();
            eoption.legend.data.Add("Actual");
            eoption.legend.data.Add("Balance");
            eoption.toolbox.show = true;
            eoption.toolbox.feature.magicType.show = true;
            eoption.toolbox.feature.magicType.type = new ArrayList();
            eoption.toolbox.feature.magicType.type.Add("line");
            eoption.toolbox.feature.magicType.type.Add("bar");
            eoption.toolbox.feature.restore.show = true;
            eoption.xAxis = new echartsOption.optionXAxis[1];
            eoption.xAxis[0].type = "category";
            eoption.xAxis[0].data = new ArrayList();
            eoption.xAxis[0].data.Add("Jan");
            eoption.xAxis[0].data.Add("Feb");
            eoption.xAxis[0].data.Add("Mar");
            eoption.xAxis[0].data.Add("Apr");
            eoption.xAxis[0].data.Add("May");
            eoption.xAxis[0].data.Add("Jun");
            eoption.xAxis[0].data.Add("Jul");
            eoption.xAxis[0].data.Add("Aug");
            eoption.xAxis[0].data.Add("Sep");
            eoption.xAxis[0].data.Add("Oct");
            eoption.xAxis[0].data.Add("Nov");
            eoption.xAxis[0].data.Add("Dec");
            eoption.yAxis = new echartsOption.optionYAxis[1];
            eoption.yAxis[0].type = "value";
            eoption.series = new echartsOption.optionSeries[2];
            eoption.series[0].name = "Actual";
            eoption.series[0].type = "bar";
            eoption.series[0].data = new ArrayList();
            eoption.series[0].data.Add(1);
            eoption.series[0].data.Add(2);
            eoption.series[0].data.Add(3);
            eoption.series[0].data.Add(4);
            eoption.series[0].data.Add(5);
            eoption.series[0].data.Add(6);
            eoption.series[0].data.Add(7);
            eoption.series[0].data.Add(8);
            eoption.series[0].data.Add(9);
            eoption.series[0].data.Add(10);
            eoption.series[0].data.Add(11);
            eoption.series[0].data.Add(12);
            //
            eoption.series[1].name = "Balance";
            eoption.series[1].type = "bar";
            eoption.series[1].data = new ArrayList();
            eoption.series[1].data.Add(12);
            eoption.series[1].data.Add(11);
            eoption.series[1].data.Add(10);
            eoption.series[1].data.Add(9);
            eoption.series[1].data.Add(8);
            eoption.series[1].data.Add(7);
            eoption.series[1].data.Add(6);
            eoption.series[1].data.Add(5);
            eoption.series[1].data.Add(4);
            eoption.series[1].data.Add(3);
            eoption.series[1].data.Add(2);
            eoption.series[1].data.Add(1);
            //
            this.echarts1.option = JsonConvert.SerializeObject(eoption);
            this.echarts1.initialECharts(false);
        }

        private void btn_dynamic_Click(object sender, EventArgs e)
        {
            EChartsNet.echartsOption eoption = new EChartsNet.echartsOption();
            eoption.title.text = "Demo";
            eoption.tooltip.trigger = "item";
            eoption.legend.data = new ArrayList();
            eoption.legend.data.Add("Actual");
            eoption.legend.data.Add("Balance");
            eoption.toolbox.show = true;
            eoption.toolbox.feature.magicType.show = true;
            eoption.toolbox.feature.magicType.type = new ArrayList();
            eoption.toolbox.feature.magicType.type.Add("line");
            eoption.toolbox.feature.magicType.type.Add("bar");
            eoption.toolbox.feature.restore.show = true;
            eoption.xAxis = new echartsOption.optionXAxis[1];
            eoption.xAxis[0].type = "category";
            eoption.xAxis[0].data = new ArrayList();
            eoption.xAxis[0].data.Add("Jan");
            eoption.xAxis[0].data.Add("Feb");
            eoption.xAxis[0].data.Add("Mar");
            eoption.xAxis[0].data.Add("Apr");
            eoption.xAxis[0].data.Add("May");
            eoption.xAxis[0].data.Add("Jun");
            eoption.xAxis[0].data.Add("Jul");
            eoption.xAxis[0].data.Add("Aug");
            eoption.xAxis[0].data.Add("Sep");
            eoption.xAxis[0].data.Add("Oct");
            eoption.xAxis[0].data.Add("Nov");
            eoption.xAxis[0].data.Add("Dec");
            eoption.yAxis = new echartsOption.optionYAxis[1];
            eoption.yAxis[0].type = "value";
            eoption.series = new echartsOption.optionSeries[2];
            eoption.series[0].name = "Actual";
            eoption.series[0].type = "bar";
            eoption.series[0].data = new ArrayList();
            eoption.series[0].data.Add(1);
            eoption.series[0].data.Add(2);
            eoption.series[0].data.Add(3);
            eoption.series[0].data.Add(4);
            eoption.series[0].data.Add(5);
            eoption.series[0].data.Add(6);
            eoption.series[0].data.Add(7);
            eoption.series[0].data.Add(8);
            eoption.series[0].data.Add(9);
            eoption.series[0].data.Add(10);
            eoption.series[0].data.Add(11);
            eoption.series[0].data.Add(12);
            //
            eoption.series[1].name = "Balance";
            eoption.series[1].type = "bar";
            eoption.series[1].data = new ArrayList();
            eoption.series[1].data.Add(12);
            eoption.series[1].data.Add(11);
            eoption.series[1].data.Add(10);
            eoption.series[1].data.Add(9);
            eoption.series[1].data.Add(8);
            eoption.series[1].data.Add(7);
            eoption.series[1].data.Add(6);
            eoption.series[1].data.Add(5);
            eoption.series[1].data.Add(4);
            eoption.series[1].data.Add(3);
            eoption.series[1].data.Add(2);
            eoption.series[1].data.Add(1);
            //
            this.echarts1.option = JsonConvert.SerializeObject(eoption);
            this.echarts1.initialECharts(true);
        }
    }
}
