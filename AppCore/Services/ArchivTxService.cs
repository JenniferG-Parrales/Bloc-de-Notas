using AppCore.IServices;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
     public class ArchivotxtServices : BaseService<ArchivTxt>, IArchivTxService
        {
            IArchivTxModel archivotxtModel;
            public ArchivotxtServices(IArchivTxModel model) : base(model)
            {
                this.archivotxtModel = model;
            }
            public void EditName(ArchivTxt t, string n)
            {
                archivotxtModel.EditName(t, n);
            }

            public void EditText(ArchivTxt t)
            {
                archivotxtModel.EditText(t);
            }
        }
    }