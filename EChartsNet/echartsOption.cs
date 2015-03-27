using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace EChartsNet
{
    public class echartsOption
    {
        public struct optionTitle
        {
            public string text { get; set; }
            public string subtext { get; set; }
        }
        public optionTitle title;

        public struct optionTooltip
        {
            public string trigger { get; set; }
        }
        public optionTooltip tooltip;

        public struct optionLegend
        {
            public ArrayList data { get; set; }
        }
        public optionLegend legend;

        public struct optionToolbox
        {
            public bool show { get; set; }
            public struct optionToolboxFeature
            {
                public struct optionToolboxFeatureMark
                {
                    public bool show { get; set; }
                }
                public optionToolboxFeatureMark mark;

                public struct optionToolboxFeatureDataView
                {
                    public bool show { get; set; }
                }
                public optionToolboxFeatureDataView dataView;

                public struct optionToolboxFeatureMagicType
                {
                    public bool show { get; set; }
                    public ArrayList type { get; set; }
                }
                public optionToolboxFeatureMagicType magicType;

                public struct optionToolboxFeatureRestore
                {
                    public bool show { get; set; }
                }
                public optionToolboxFeatureRestore restore;

                public struct optionToolboxFeatureSaveAsImage
                {
                    public bool show { get; set; }
                }
                public optionToolboxFeatureSaveAsImage saveAsImage;
            }
            public optionToolboxFeature feature;
        }
        public optionToolbox toolbox;

        public bool calculable { get; set; }

        public struct optionXAxis
        {
            public string type { get; set; }
            public ArrayList data { get; set; }
        }
        public optionXAxis[] xAxis;

        public struct optionYAxis
        {
            public string type { get; set; }
        }
        public optionYAxis[] yAxis;

        public struct optionSeries
        {
            public string name { get; set; }
            public string type { get; set; }
            public ArrayList data { get; set; }
        }
        public optionSeries[] series;
    }
}
