using System;

namespace GestaoDeGastoDefinido
{
    class  GestaoDeGastoDefinido
    {
        public double Dias, Horas, GanhosDefinido, Alimentacao, Combustivel;
        public double CalcularMetaDiarias()
        {
            double MetaDoDia = (GanhosDefinido / Dias) + Alimentacao + Combustivel;
            return MetaDoDia;
        }
        public double CalcularMetaHora()
        {
            double MetaHora = CalcularMetaDiarias() / Horas;
            return MetaHora;
        }
        public override string ToString()
        {
            return $"Dias a trabalhar:{Dias:f0} | Horas a trabalhar por dia:{Horas:f0} | Meta por dia: R${CalcularMetaDiarias():f2} | Meta por hora: R${CalcularMetaHora():f2}";
                
        }
    }

}
