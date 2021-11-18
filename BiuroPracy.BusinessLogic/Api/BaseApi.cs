using System;
using System.Collections.Generic;
using System.Text;
using BiuroPracy.BusinessLogic.NHibernate;

namespace BiuroPracy.BusinessLogic.Api
{
    public class BaseApi
    {
        public BaseApi()
        {
            NHibernateBase nHibernate = new NHibernateBase();
            nHibernate.Initialize();
        }
    }
}
