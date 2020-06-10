using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using Microsoft.Extensions.Configuration;


namespace AlgorithmLibrary
{
    /// <summary>
    /// Dependencies --> 1.)Merchant Accounts 2.)Delegate list or dictionary, 3.)IConfig
    /// </summary>    
    public class Algorithm1 : IAlgorithm// transient
    {
        private readonly IConfiguration _config;
        private IAlgorithm algorithm;
        //private List<MerchantAccountList> list;
        //private List<Func<T, T>> funcList;
        public Algorithm1(IConfiguration config)
        {            
            this._config = config; //direct db access or API acess. Bad practice to put here probably.          
        }

        public IList<T> RunAlgorithm<T, U>(IList<T> list, Dictionary<string, U> dict)
        {
            List<T> merchantAccountPassRateList = new List<T>();
            return merchantAccountPassRateList;
        }

        public IList<T> RunAlgorithm<T>(IList<T> list)
        {
            throw new NotImplementedException();
        }
    }


}
