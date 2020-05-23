
using System;

namespace TestNinja.Fundamentals
{
    public class ErrorLogger
    {
        public string LastError { get; set; }
        private Guid _errorId;

        public event EventHandler<Guid> ErrorLogged; 
        
        public void Log(string error)
        {
            // null
            // ""
            // " "
            if (String.IsNullOrWhiteSpace(error))
                throw new ArgumentNullException();

            LastError = error;

            // Write the log to a storage
            // ...
            _errorId = Guid.NewGuid();
            OnErrorLogged();
        }

        public virtual void OnErrorLogged()
        {
            //  Responsible for rasing the event
            ErrorLogged?.Invoke(this, _errorId);
        }
    }
}