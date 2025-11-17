using Desktop.Views;
using Microsoft.Reporting.WinForms;
using Service.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.ViewReports
{
    public partial class DiscosViewReport : Form
    {
        ReportViewer _report;
        List<DiscosView> _disco;

        public DiscosViewReport(List<DiscosView> disco)
        {
            InitializeComponent();
            _report = new ReportViewer();
            _disco = disco;
            _report.Dock = DockStyle.Fill;
            this.Controls.Add(_report);
        }

        private void DiscosViewReport_Load(object sender, EventArgs e)
        {
            _report.LocalReport.ReportEmbeddedResource = "Desktop.ViewReports.DiscosViewReport.rdlc";
            var discos = _disco.Select(i => new
            {
                //agregar al reporte los campos que se desean mostrar
                //Titulo = i.Titulo,
                //Artista = i.Artista,
                //Genero = i.Genero,

            }).ToList();

            _report.LocalReport.DataSources.Add(new ReportDataSource("DSDiscos", discos));
            _report.SetDisplayMode(DisplayMode.PrintLayout);
            _report.ZoomMode = ZoomMode.Percent;
            _report.ZoomPercent = 100;

            _report.RefreshReport();
        }
    }
}
