using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

class Homework2c
{

    enum HTTPError
    {
            Bad_Request                        = 400,
            Unauthorized                       = 401,
            Forbidden                          = 403,
            Not_found                          = 404,
            Method_Not_Allowed                 = 405,
            Not_Acceptable                     = 406,
            Proxy_Authentication_Required      = 407,
            Request_Timeout                    = 408,
            Conflict                           = 409,
            Gone                               = 410,
            Length_Required                    = 411,
            Precondition_Failed                = 412,
            Content_Too_Large                  = 413,
            URI_Too_Long                       = 414,
            Unsupported_Media_Type             = 415,
            Range_Not_Satisfiable              = 416,
            Expectation_Failed                 = 417,
            Misdirected_Request                = 421,
            Upgrade_Required                   = 426,
            Too_Many_Requests                  = 429,
            Request_Header_Fields_Too_Large    = 431,
            Unavailable_For_Legal_Reasons      = 451
    }

    static void Main()
    {
        int CodeNumber;

        try
        {
            Console.WriteLine("Ingrese un Código del error");
            CodeNumber = Convert.ToInt32(Console.ReadLine());
            HTTPError Error = (HTTPError)CodeNumber;
            Console.WriteLine(Error.ToString() == CodeNumber.ToString() ? "Error no definido" : "Nombre del error : {0}",Error );
            
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }

   
    }

}

