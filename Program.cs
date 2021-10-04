using System;

namespace converter
{
    class Converter{
        public Converter(double eur, double usd){
            _eur = eur;
            _usd = usd;
        }
        public double HryvnaToEur(double hrn){
            if(_eur != 0){
            return hrn/_eur;}
            else{Console.WriteLine("Zero Divide!");
            return 0;}
        }
          public double HryvnaToUsd(double hrn){
            if(_usd != 0){
            return hrn/_usd;}
            else{Console.WriteLine("Zero Divide!");
            return 0;}
        }
          public double EurToHrn(double eur){
            if(_eur != 0){
            return eur*_eur;}
            else{Console.WriteLine("Zero!");
            return 0;}
        }
         public double UsdToHrn(double usd){
            if(_usd != 0){
            return usd*_usd;}
            else{Console.WriteLine("Zero!");
            return 0;}
        }
        
        private double _eur = 0.0;
        private double _usd = 0.0;
            
    }
    class Program
    {
        static void Main(string[] args)
        {
            Converter c = new Converter(30.3, 26.5);
            Console.WriteLine(c.HryvnaToEur(100.5));
            Console.WriteLine(c.HryvnaToUsd(100.5));
            
        }
    }
}
