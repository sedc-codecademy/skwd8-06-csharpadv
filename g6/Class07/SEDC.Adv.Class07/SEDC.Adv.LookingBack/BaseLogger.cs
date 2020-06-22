using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.LookingBack
{
    public abstract class BaseLogger
    {
        protected string _warningMessage = $"{DateTime.Now} [WARNING]";
        protected string _errorMessage = $"{DateTime.Now} [ERROR]";
        protected string _infoMessage = $"{DateTime.Now} [INFO]";
    }
}
