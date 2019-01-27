using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;

namespace Mikrotik
{
    class Reporte 
    {
        public CrystalReport1 report;
        public Reporte()
        {
            try
            {
                report = new CrystalReport1();
            }
            catch(Exception)
            {

            }
        }
        
        public string imprimirReport(DataSet1 dts)
        {
            try
            {
                string cErr = "";
                DataTable tabla = new DataTable();
                tabla = dts.Usuarios;
                report.SetDataSource(tabla);
                //report.
                report.PrintToPrinter(1,false,0,0);

                report.Close();
                report.Dispose();

                return cErr;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
