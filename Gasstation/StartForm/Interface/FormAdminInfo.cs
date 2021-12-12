using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Gasstation.StartForm.Interface
{
    public partial class FormAdminInfo : Form
    {
        SqlFunction sf = new SqlFunction();
        public FormAdminInfo()
        {
            InitializeComponent();
            zedGraph.IsShowPointValues = true;
            zedGraph.PointValueEvent += new ZedGraphControl.PointValueHandler(zedGraph_PointValueEvent);
        }

        private string zedGraph_PointValueEvent(ZedGraphControl sender, GraphPane pane, CurveItem curve, int iPt)
        {
            PointPair point = curve[iPt];
            string result = string.Format("Кол-во: {0:F0}", point.Y);
            return result;
        }

        private void FormAdminInfo_Load(object sender, EventArgs e)
        {
            labelCountClient.Text = sf.GetCountClients();
            labelCountStation.Text = sf.GetCountStation();
            labelCountShop.Text = sf.GetCountShop();
            dgv_FuelPrice.DataSource = sf.GetAdminFuelPrice();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data = sf.GetShopPeriod(dtpStart.Text, dtpEnd.Text);
            DrawDiagramm(data);
        }

        private void DrawDiagramm(DataTable data)
        {
            GraphPane pane = zedGraph.GraphPane;
            pane.CurveList.Clear();
            pane.Title.Text = "Зависимость покупок от даты";
            pane.XAxis.Title.Text = "Дата";
            pane.YAxis.Title.Text = "Количество покупок";


            double[] yValues = new double[data.Rows.Count];
            string[] xValues = new string[data.Rows.Count];

            for (int i = 0; i < data.Rows.Count; i++)
            {
                DateTime date = Convert.ToDateTime(data.Rows[i][1]);
                xValues[i] = date.ToString("dd-MM");
                yValues[i] = Convert.ToDouble(data.Rows[i][0]);
            }

            BarItem bar = pane.AddBar("Кол-во", null, yValues, Color.Firebrick);
            pane.XAxis.Scale.TextLabels = xValues;
            pane.XAxis.Type = ZedGraph.AxisType.Text;

            pane.BarSettings.MinBarGap = 0.0f;
            pane.BarSettings.MinClusterGap = 1.5f;

            zedGraph.AxisChange();
            zedGraph.Invalidate();
        }
    }
}
