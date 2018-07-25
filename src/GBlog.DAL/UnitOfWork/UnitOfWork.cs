using GBlog.DAL.Repositories;
using System;

namespace GBlog.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IPostRepository _postRepository;
        public UnitOfWork(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        void IUnitOfWork.Complete()
        {
            throw new NotImplementedException();
        }

        public IPostRepository PostRepository
        {
            get
            {
                return _postRepository;
            }
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls



        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~UnitOfWork() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        void IDisposable.Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
