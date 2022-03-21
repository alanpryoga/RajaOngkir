using AlanPryoga.RajaOngkir.Entities;
using AlanPryoga.RajaOngkir.Enums;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace AlanPryoga.RajaOngkir
{
    public class RajaOngkir : IRajaOngkir
    {
        /// <summary>
        /// HTTP client
        /// </summary>
        private static readonly HttpClient httpClient = new HttpClient();

        /// <summary>
        /// API key
        /// </summary>
        private string _apikey;

        /// <summary>
        /// API base URL
        /// </summary>
        private string _apiBaseUrl;

        /// <summary>
        /// Create a new RajaOngkir instance.
        /// </summary>
        /// <param name="apiKey">API key</param>
        /// <param name="accountType">An <see cref="AccountType"/> type</param>
        public RajaOngkir(string apiKey, AccountType accountType = AccountType.Starter)
        {
            _apikey = apiKey;

            // Determine of API base URL from which account type.
            switch (accountType)
            {
                case AccountType.Starter:
                    {
                        _apiBaseUrl = "https://api.rajaongkir.com/starter";
                        break;
                    }
                case AccountType.Basic:
                    {
                        _apiBaseUrl = "	https://api.rajaongkir.com/basic";
                        break;
                    }
                case AccountType.Pro:
                    {
                        _apiBaseUrl = "https://pro.rajaongkir.com/api";
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        public List<Province> GetProvinces()
        {
            throw new NotImplementedException();
        }

        public Province GetProvince(int provinceId)
        {
            throw new NotImplementedException();
        }

        public List<City> GetCities()
        {
            throw new NotImplementedException();
        }

        public List<City> GetCities(int provinceId)
        {
            throw new NotImplementedException();
        }

        public City GetCity(int cityId)
        {
            throw new NotImplementedException();
        }

        public Cost Calculate(int origin, int destination, int weight, Courier courier)
        {
            throw new NotImplementedException();
        }
    }
}
