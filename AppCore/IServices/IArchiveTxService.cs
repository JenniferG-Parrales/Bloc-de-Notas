
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.IServices
{
    public interface IArchivTxService : IServices<ArchivTxt>
    {
        void EditText(ArchivTxt t);
        void EditName(ArchivTxt t, string n);
    }
}
