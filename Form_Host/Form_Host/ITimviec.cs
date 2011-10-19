using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Form_Host
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITimviec" in both code and config file together.
    [ServiceContract]
    public interface ITimviec
    {
        [OperationContract]
        string GetAuthors();
        [OperationContract]
        string Detai();
    }
}
