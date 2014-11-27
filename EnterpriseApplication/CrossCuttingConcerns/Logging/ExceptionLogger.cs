using Castle.Core.Logging;
using Castle.DynamicProxy;
using System;

namespace CrossCuttingConcerns.Logging
{
    public class ExceptionLogger : IInterceptor
    {
        ILogger log;

        public ExceptionLogger(ILogger log)
        {
            this.log = log;
        }

        public void Intercept(IInvocation invocation)
        {
            try
            {
                invocation.Proceed();
            }
            catch (Exception e)
            {
                var message = string.Format("Method '{0}' of class '{1}' failed.", 
                                            invocation.Method.Name, invocation.TargetType.Name);
                log.Error(message, e);
                throw;
            }
        }
    }
}
