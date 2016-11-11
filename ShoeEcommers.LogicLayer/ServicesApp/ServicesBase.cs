using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoeEcommers.LogicLayer.ServicesApp
{
    public class ServicesBase : IDisposable
    {
        protected List<IDisposable> ListDisposable { get; set; }

        public ServicesBase()
        {
            ListDisposable = new List<IDisposable>();
        }

        private bool _isDispose;
        public void Dispose()
        {
            Dispose(true);
        }

        public void Dispose(bool disposing)
        {
            if (disposing && !_isDispose)
            {
                ListDisposable.ForEach(d=>d.Dispose());
                _isDispose = true;
            }
        }
    }
}
