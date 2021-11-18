using System;
using System.Collections;
using System.Linq;
using BiuroPracy.BusinessLogic.Api.Interface;
using BiuroPracy.BusinessLogic.Communication;
using BiuroPracy.BusinessLogic.ModelDTO;
using BiuroPracy.BusinessLogic.NHibernate;
using BiuroPracy.Domain;
using NHibernate;
using NHibernate.Linq;
using NHibernate.Transform;

namespace BiuroPracy.BusinessLogic.Api
{
    public class BiuroPracyApi : BaseApi, IBiuroPracyApi

    {
        public void TestNHibernate()
        {
            try
            {
                using (var session = NHibernateBase.Session) // tworzymy obiekt połączenie do bazy danych
                {
                    using (var transaction = session.BeginTransaction()) //tworzymy obiekt tranzakcji
                    {
                        var profession = session.Get<Profession>(1); //pobieramy z bazy danych z tabeli Profession rekord o iD1
                    }
                }
            }
            catch (Exception e)
            {
            }
        }

        public ListIdNamePairServiceResponse GetProfessionals()
        {
            try
            {
                using (var session = NHibernateBase.Session) //tworzymy obiekt połączenie do bazy danych
                {
                    var proffesions = session.Query<Profession>()
                        .Select(x =>
                            new IdNamePair
                            {
                                Id = x.Id,
                                Name = x.Name
                            }).ToList();
                    return new ListIdNamePairServiceResponse()
                    {
                        Data = proffesions
                    };
                }
            }
            catch (Exception e)
            {
                return new ListIdNamePairServiceResponse()
                {
                    Errors = e.StackTrace + " " + e.Message,
                    Success = false
                };
            }
        }

        public ListIdNamePairServiceResponse GetContract()
        {
            try
            {
                using (var session = NHibernateBase.Session) //tworzymy obiekt połączenie do bazy danych
                {
                    var contracts = session.Query<Contract>()
                        .Select(x =>
                            new IdNamePair
                            {
                                Id = x.Id,
                                Name = x.Name
                            }).ToList();
                    return new ListIdNamePairServiceResponse()
                    {
                        Data = contracts
                    };
                }
            }
            catch (Exception e)
            {
                return new ListIdNamePairServiceResponse()
                {
                    Errors = e.StackTrace + " " + e.Message,
                    Success = false
                };
            }
        }

        public ListIdNamePairServiceResponse GetCity()
        {
            try
            {
                using (var session = NHibernateBase.Session) //tworzymy obiekt połączenie do bazy danych
                {
                    var citys = session.Query<City>()
                        .Select(x =>
                            new IdNamePair
                            {
                                Id = x.Id,
                                Name = x.Name
                            }).ToList();
                    return new ListIdNamePairServiceResponse()
                    {
                        Data = citys
                }
            }
            catch (Exception e)
            {
                return new ListIdNamePairServiceResponse()
                {
                    Errors = e.StackTrace + " " + e.Message,
                    Success = false
                };
            }
        }

        public ListIdNamePairServiceResponse GetCountry()
        {
            try
            {
                using (var session = NHibernateBase.Session) //tworzymy obiekt połączenie do bazy danych
                {
                    var countrys = session.Query<Country>()
                        .Select(x =>
                            new IdNamePair
                            {
                                Id = x.Id,
                                Name = x.Name
                            }).ToList();
                    return new ListIdNamePairServiceResponse()
                    {
                        Data = countrys
                    };
                }
            }
            catch (Exception e)
            {
                return new ListIdNamePairServiceResponse()
                {
                    Errors = e.StackTrace + " " + e.Message,
                    Success = false
                };
            }
        }
    }
}
