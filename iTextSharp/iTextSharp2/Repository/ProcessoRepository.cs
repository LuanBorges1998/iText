using iTextSharp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iTextSharp2.Repository
{
    public class ProcessoRepository
    {
        private DataModel _DataModel;
        public DataModel DataModel
        {
            get{
                if (_DataModel == null)
                    _DataModel = new DataModel();
                return _DataModel;
            }
            set{
                _DataModel = value;
            }
        }

        public Processo GetProcesso(int id)
        {
            return DataModel.Processo.FirstOrDefault(x => x.Id == id);
        }

    }
}