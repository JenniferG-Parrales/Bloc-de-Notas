using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class StreamArchivTxRepository : IArchivTxModel
    {
        string carpetaPath = Directory.GetCurrentDirectory() + @"\Archivos";
        public void Create(ArchivTxt t)
        {
            string archivoPath = @"\" + t.Nombre + ".txt";
            File.Create(carpetaPath + archivoPath);
        }

        public void Delete(ArchivTxt t)
        {
            string archivoPath = @"\" + t.Nombre + ".txt";
            File.Delete(carpetaPath + archivoPath);
        }

        public void EditName(ArchivTxt t, string n)
        {
            string nuevoNombrePath = @"\" + n + ".txt";
            string archivoPath = @"\" + t.Nombre + ".txt";
            File.Move(carpetaPath + archivoPath, carpetaPath + nuevoNombrePath);
        }

        public void EditText(ArchivTxt t)
        {
            string archivoPath = @"\" + t.Nombre + ".txt";
            File.AppendAllText(carpetaPath + archivoPath, t.Informacion);
        }
    }
}