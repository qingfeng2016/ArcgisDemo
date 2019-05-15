using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.esriSystem;
using System.IO;
using System.Runtime.InteropServices;
using ESRI.ArcGIS.DataSourcesRaster;
using ESRI.ArcGIS.SpatialAnalyst;
using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.DataSourcesFile;

namespace MyArcgis
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            ESRI.ArcGIS.RuntimeManager.Bind(ESRI.ArcGIS.ProductCode.EngineOrDesktop);
            InitializeComponent();
        }              
      
        private void Form1_Load(object sender, EventArgs e)
        {
            string mxdFile = @"C:\Users\Administrator\Desktop\测试数据\水系沉积物插值\水系沉积物插值结果.mxd";
            if (axMapControl1.CheckMxFile(mxdFile))
            {
                axMapControl1.LoadMxFile(mxdFile);
            }

        }

       
    }
}
