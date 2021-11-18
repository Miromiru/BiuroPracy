using System;
using System.Collections.Generic;
using System.Text;
using BiuroPracy.BusinessLogic.ModelDTO;

namespace BiuroPracy.BusinessLogic.Communication
{
    public class ListIdNamePairServiceResponse : ServiceResponse
    {
        public List<IdNamePair> Data { get; set; }
    }
}
