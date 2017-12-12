using System;

namespace TA
{
    public class BlackSholes
    {
        public string Greeting(string name)
        {
            return $"Hello {name}";
        }
        public double GetFairPrice(double Spot, double Strik, double TDays, double Rate, double Volatility, EnumOptionType OptionType)
        {
            double _FairPrice = 0, _PHI = 1;
            if (OptionType == EnumOptionType.Put)
            {
                _PHI = -1;
            }

            if (TDays > 0)
            {
                double _VT = Volatility * Math.Sqrt(TDays);
                double _R = Math.Log(1 + Rate);
                double _D1 = GetD1(Spot, Strik, TDays, Rate, Volatility);
                double _D2 = GetD2(_D1, TDays, Volatility);
                _FairPrice = _PHI * Spot * GetCND(_PHI * _D1) - _PHI * Strik * Math.Exp((0 - _R) * TDays) * GetCND(_PHI * _D2);
            }
            else
            {
                _FairPrice = Math.Max(_PHI * (Spot - Strik), 0);
            }
            return _FairPrice ;
        }
        private double GetD1(double Spot, double Strik, double TDays, double Rate, double Volatility)
        {
            double _R = Math.Log(1 + Rate);
            double _VT = Volatility * Math.Sqrt(TDays);
            double _D1 = (Math.Log(Spot / Strik) + _R * TDays) / _VT + 0.5 * _VT;
            return _D1;
        }
        private double GetD2(double D1, double TDays, double Volatility)
        {
            return D1 - (Volatility * Math.Sqrt(TDays));
        }
        private double GetCND(double X)
        {
            double _L, _K, _CND;

            double _A1 = 0.31938153, _A2 = -0.356563782, _A3 = 1.781477937, _A4 = -1.821255978, _A5 = 1.330274429;
            _L = Math.Abs(X);
            _K = 1 / (1 + 0.2316419 * _L);
            _CND = 1 - 1 / Math.Sqrt(2 * 3.14159265358979/*Pi*/) * Math.Exp(0 - Math.Pow((_L), 2) / 2) * (_A1 * _K + (_A2 * Math.Pow(_K, 2)) + (_A3 * Math.Pow(_K, 3)) + (_A4 * Math.Pow(_K, 4)) + (_A5 * Math.Pow(_K, 5)));
            
            if (X < 0)
            {
                _CND = 1 - _CND;    
            }
            return _CND;
        }
    }
    public enum EnumOptionType
    {
        Call = 0,
        Put = 1
    }
}
