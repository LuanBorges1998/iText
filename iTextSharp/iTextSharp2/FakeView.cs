using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iTextSharp2
{
    public class FakeView : IView
    {
        #region IView Members

        public void Render(ViewContext viewContext, TextWriter writer)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}