using Sas.Restaurant.Business.Managers;
using Sas.Restaurant.Business.Services;
using Sas.Restaurant.DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Business.Workers
{
    public class RestaurantWorker : IWorker
    {
        private IUnitOfWork _uow;

        public IUrunService UrunService { get; set; }
        public ITanimService TanimService { get; set; }
        public IPorsiyonService PorsiyonService { get; set; }
        public IEkMalzemeService EkMalzemeService { get; set; }
        public IMusteriService MusteriService { get; set; }
        public ITelefonService TelefonService { get; set; }
        public IAdresService AdresService { get; set; }

        public RestaurantWorker(string connetionString=null)
        {
            _uow = new RestaurantUnitOfWork(connetionString);
            UrunService = new UrunManager(_uow);
            TanimService = new TanimManager(_uow);
            PorsiyonService = new PorsiyonManager(_uow);
            EkMalzemeService = new EkMalzemeManager(_uow);
            MusteriService = new MusteriManager(_uow);
            TelefonService = new TelefonManager(_uow);
            AdresService = new AdresManager(_uow);
        }

        public bool Commit()
        {
            return _uow.Commit();
        }

        public void DetectChanges()
        {
            _uow.DetectChanges();
        }

        public bool HasChanges()
        {
            return _uow.HasChanges();
        }

        private bool disposedValue;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~RestaurantWorker()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
