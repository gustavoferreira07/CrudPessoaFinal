using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CrudPessoas.Models;
using OfficeOpenXml;
using System.IO;

namespace CrudPessoas.Infra.ExcelInfra
{
    public class ExcelService
    {
        public IEnumerable<Models.GastoModel> RetornaGastos(string diretorioArquivo, PessoaModel pessoa)
        {
            List<GastoModel> gastos = new List<GastoModel>();
            GastoModel gastoModel;
            using (ExcelPackage package = new ExcelPackage(new FileInfo(diretorioArquivo)))
            {                
                ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();

                int rows = worksheet.Dimension.Rows;
                int column = worksheet.Dimension.Columns;
                for (int i = 2; i <= rows; i++)
                {
                    gastoModel = new GastoModel();
                    gastoModel.Descricao = worksheet.Cells[i, 1].Value.ToString();
                    gastoModel.Valor = double.Parse(worksheet.Cells[i, 2].Value.ToString());
                    gastoModel.idPessoa = pessoa.Id;
                    gastos.Add(gastoModel);
                }
                return gastos;
            }
        }
    }
}