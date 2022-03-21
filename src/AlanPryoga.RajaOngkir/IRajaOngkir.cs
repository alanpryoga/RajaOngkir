using AlanPryoga.RajaOngkir.Entities;
using AlanPryoga.RajaOngkir.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlanPryoga.RajaOngkir
{
    public interface IRajaOngkir
    {
        List<Province> GetProvinces();

        List<City> GetCities();

        Cost Calculate(int origin, int destination, int weight, Courier courier);
    }
}
