using CrudPessoas.Models;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Excel
{
    public class ExcelBLL
    {
        public IEnumerable<GastoModel> RetornaGastos(string diretorioArquivo)
        {
            List<GastoModel> gastos = new List<GastoModel>();
            diretorioArquivo = @"C:\Users\gugag\OneDrive\Área de Trabalho\planilhagasto.xlsx";
            string path = diretorioArquivo;
            FileInfo fileInfo = new FileInfo(path);

            ExcelPackage package = new ExcelPackage(fileInfo);
            ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();
            
            int rows = worksheet.Dimension.Rows;             

            for (int i = 2; i <= rows; i++)
            {                
                  gastos[i-2].Descricao=  worksheet.Cells[i, 1].Value.ToString();
                  gastos[i-2].Valor =double.Parse( worksheet.Cells[i,2].Value.ToString());                                  
            }
            return gastos;
        }
    }
}
