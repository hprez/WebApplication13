using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace WebApplication13
{
    public class StackTraceHandler : IHttpHandler
    {
        public bool IsReusable => throw new NotImplementedException();

        public void ProcessRequest(HttpContext context)
        {
            try
            {
                Debug.WriteLine("Processing request");
            }
            catch (Exception ex)
            {
                // BAD: printing a stack trace back to the response
                context.Response.Write(ex.ToString());
                return;
            }
            //try
            //{
            //    Debug.WriteLine("Processing request");
            //}
            //catch (Exception ex)
            //{
            //    // GOOD: log the stack trace, and send back a non-revealing response
            //    Debug.WriteLine("Exception occurred", ex);
            //    context.Response.Write("Exception occurred");
            //    return;
            //}
        }
    }
}