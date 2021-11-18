using BiuroPracy.BusinessLogic.Communication;
using System;
using System.Collections.Generic;
using System.Text;

namespace BiuroPracy.BusinessLogic.Api.Interface
{
    public interface IBiuroPracyApi
    {
        void TestNHibernate();

        ListIdNamePairServiceResponse GetProfessionals();
        ListIdNamePairServiceResponse GetContract();
        ListIdNamePairServiceResponse GetCity();
        ListIdNamePairServiceResponse GetCountry();

    }
}