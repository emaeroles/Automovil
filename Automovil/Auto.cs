using System;

namespace Automovil
{
    class Auto
    {
        private float kilometros;
        private float combustible;
        private float tanque;
        private readonly byte km_l;
        private bool reserva;
        public Auto()
        {
            kilometros = 1f;
            combustible = 1f;
            tanque = 0f;
            km_l = 11;
            reserva = false;
        }
        public float Kilometros
        {
            set
            {
                kilometros = value;
            }
            get
            {
                return kilometros;
            }
        }
        public float Combustible
        {
            set
            {
                combustible = value;
            }
            get
            {
                return combustible;
            }
        }
        public string Conducir()  // Método para disminuir el valor de la variable tanque 
        {                         // si kilometros no supera 594 y si kmPuede es >= que kilometros
            float kmPuede = km_l * tanque;

            kmPuede = (float)Math.Round(kmPuede * 1000f) / 1000f;

            if (tanque - kilometros / km_l <= 5)
            {
                reserva = true;
            }

            if (kilometros > 594 && tanque > 0)
            {
                return "No puede recorre " + kilometros + "km, excede las capacidades del vehículo, usted solo puede recorrer " + kmPuede + "km";
            }
            else if (tanque == 0)
            {
                return "No hay combustible en el tanque, no puede conducir";
            }
            else if (tanque > 0 && tanque <= 5)
            {
                if (kmPuede >= kilometros)
                {
                    tanque -= kilometros / km_l;
                    tanque = (float)Math.Round(tanque * 1000f) / 1000f;
                    return "Puede recorrer " + kilometros + "km, pero cuidado que esta en la reserva";
                }
                else
                {
                    return "No puede recorre " + kilometros + " km, usted solo puede recorrer " + kmPuede + "km";
                }
            }
            else
            {
                if (kmPuede >= kilometros)
                {
                    if (reserva == true)
                    {
                        tanque -= kilometros / km_l;
                        tanque = (float)Math.Round(tanque * 1000f) / 1000f;
                        return "Puede recorrer " + kilometros + "km, pero cuidado que quedo en la reserva";
                    }
                    else
                    {
                        tanque -= kilometros / km_l;
                        tanque = (float)Math.Round(tanque * 1000f) / 1000f;
                        return "Puede recorrer " + kilometros + "km, sin problemas";
                    }
                }
                else
                {
                    return "No puede recorre " + kilometros + "km, usted solo puede recorrer " + kmPuede + "km";
                }
            }
        }

        public string Cargar()  // Método para aumentar el valor de la variable tanque
        {                       // si el tanque no esta lleno
            string salida;
            float derrame;

            if (tanque < 54)
            {
                if (54 - tanque >= combustible)
                {
                    tanque += combustible;
                    salida = "Se ha cargado combustible";
                }
                else
                {
                    derrame = combustible - (54 - tanque);
                    derrame = (float)Math.Round(derrame * 100f) / 100f;
                    tanque = 54;
                    salida = "El tanque se lleno y se derramaron " + derrame + " litros de combustible";
                }
            }
            else
            {
                salida = "El tanque esta lleno";
            }

            if (tanque > 5)
            {
                reserva = false;
            }
            return salida;
        }
    }
}