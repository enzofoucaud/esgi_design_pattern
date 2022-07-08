using System;
using System.Collections.Generic;

namespace esgi_design_pattern
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        object Handle(object request);
    }

    abstract class Handler : IHandler
    {
        private IHandler _nextHandler;
        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;
            return handler;
        }
        public virtual object Handle(object request)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }
    }

    class SellerHandler : Handler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "seller")
            {
                return "Call to seller service"; 
            }
            else
            {
                return base.Handle(request);
            }
        }
    }

    class MechanicHandler : Handler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "mechanic")
            {
                return "Call mechanic service";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }

    class TechnicalAssistanceHandler : Handler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "technical assistance")
            {
                return "Call the technical assistance service";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }

    class Client
    {
        public static void ClientCode(Handler handler)
        {
            foreach (var call in new List<string> {"seller", "mechanic", "director"})
            {
                Console.WriteLine("Calling " + call);

                var result = handler.Handle(call);
                
                if (result != null)
                {
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("The client is not able to handle the call");
                }
            }
        }
    }
}