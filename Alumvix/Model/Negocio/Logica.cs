using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.Model.Negocio
{
    internal class Logica
    {
        int acumulador;

        public int SumarGastos(List<GastoDto> gastos)
        {
            acumulador = 0;
            foreach (GastoDto gasto in gastos)
            {
                acumulador += gasto.ValorGasto;
            }
            return acumulador;
        }

        public int SumarAbonos(List<AbonoDto> abonos)
        {
            acumulador = 0;
            foreach (AbonoDto abono in abonos)
            {
                acumulador += abono.ValorAbono;
            }
            return acumulador;
        }

        public int ObtenerRestantePorPagar(int totalAbonos, int valorContrato) 
        {
            return valorContrato - totalAbonos;
        }

        public int ObtenerUtilidad(int totalAbonos, int totalGastos)
        {
            int utilidad = totalAbonos - totalGastos;
            if (utilidad < 0)
            {
                utilidad = 0;
            }
            return utilidad;
        }

        public int ConsultarCantidadContratos(int idCliente)
        {
            ContratoDao contratoDao = new ContratoDao();
            int contadorContratos = contratoDao.ObtenerContratos(idCliente).Count;
            return contadorContratos;
        }

        public static int AplicarIVA(int valor, int idIva)
        {
            ContratoDao contratoDao = new ContratoDao();
            double iva = contratoDao.ConsultarIVA(idIva);
            return (int)(valor * iva) + valor;
        }

        public static int QuitarIVA(int valor)
        {
            return Convert.ToInt32(valor / (1 + new ContratoDao().ConsultarIVA(1)));
        }

        public int SumarTiposDeGastos(int mes, int anio) 
        {
            ReporteDao reporteDao = new ReporteDao();
            int totalGastosPorMes = reporteDao.ObtenerTotalGastosPorMes(mes, anio);
            int totalGastosInternos = reporteDao.ObtenerTotalGastosInternosPorMes(mes, anio);
            int sumaGastos = totalGastosPorMes + totalGastosInternos;
            return sumaGastos;          
        }

        public int SumarTiposDeGastos(int anio)
        {
            ReporteDao reporteDao = new ReporteDao();
            int totalGastosPorAnio = reporteDao.ObtenerTotalGastosPorAnio(anio);
            int totalGastosInternos = reporteDao.ObtenerTotalGastosInternosPorAnio(anio);
            int sumaGastos = totalGastosPorAnio + totalGastosInternos;
            return sumaGastos;
        }

        public void ExportToExcel(ListView lv)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    for (int j = 1; j <= lv.Columns.Count; j++)
                    {
                        ws.Columns[j].AutoFit();
                        ws.Cells[1, j] = lv.Columns[j - 1].Text;
                    }
                    int i = 2;
                    foreach (ListViewItem item in lv.Items)
                    {
                        for (int k = 1; k <= item.SubItems.Count; k++)
                        {
                            ws.Cells[i, k] = item.SubItems[k - 1].Text;
                        }
                        i++;
                    }
                    wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, false, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                    MessageBox.Show("El archivo ha sido exportado de manera exitosa");
                }
            }
        }

        public void ExportTextBoxesToExcel(List<System.Windows.Forms.TextBox> textBoxes, ListView listView)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;

                    for (int j = 1; j <= listView.Columns.Count; j++)
                    {
                        ws.Columns[j].AutoFit();
                        ws.Cells[1, j] = listView.Columns[j - 1].Text;
                    }
                    int i = 2;
                    foreach (ListViewItem item in listView.Items)
                    {
                        for (int k = 1; k <= item.SubItems.Count; k++)
                        {
                            ws.Cells[i, k] = item.SubItems[k - 1].Text;
                        }
                        i++;
                    }

                    int _lastRow = ws.Range["A" + ws.Rows.Count].End[Microsoft.Office.Interop.Excel.XlDirection.xlUp].Row + 1;
                    ws.Cells[_lastRow, 1] = "**********";
                    ws.Cells[_lastRow, 2] = "**********";
                    ws.Cells[_lastRow, 3] = "**********";
                    ws.Cells[_lastRow, 4] = "**********";

                    _lastRow = ws.Range["A" + ws.Rows.Count].End[Microsoft.Office.Interop.Excel.XlDirection.xlUp].Row + 1;

                    ws.Cells[_lastRow, 1] = "Cantidad de Contratos";
                    ws.Cells[_lastRow, 2] = "Total Ventas";
                    ws.Cells[_lastRow, 3] = "Total Gastos";
                    ws.Cells[_lastRow, 4] = "Utilidad";

                    _lastRow = ws.Range["A" + ws.Rows.Count].End[Microsoft.Office.Interop.Excel.XlDirection.xlUp].Row + 1;

                    ws.Cells[_lastRow, 1] = textBoxes[0].Text;
                    ws.Cells[_lastRow, 2] = textBoxes[1].Text;
                    ws.Cells[_lastRow, 3] = textBoxes[2].Text;
                    ws.Cells[_lastRow, 4] = textBoxes[3].Text;

                    wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, false, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                    MessageBox.Show("El archivo ha sido exportado de manera exitosa");
                }
            }
        }


    }
}
