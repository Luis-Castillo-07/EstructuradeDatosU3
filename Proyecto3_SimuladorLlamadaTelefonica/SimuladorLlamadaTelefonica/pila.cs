using System;

namespace SimuladorLlamadaTelefonica
{
    public class Pila
    {
        private Nodo tope;

        private class Nodo
        {
            public string Datos;
            public Nodo siguiente;

            public Nodo(string datos)
            {
                Datos = datos;
            }
        }

        public void Apilar(string datos)
        {
            Nodo nuevo = new Nodo(datos);
            nuevo.siguiente = tope;
            tope = nuevo;
        }

        public string? Desapilar()
        {
            if (tope == null)
                return null;

            string llamada = tope.Datos;
            tope = tope.siguiente;

            return llamada;
        }

        public void Mostrar()
        {
            Nodo actual = tope;

            while (actual != null)
            {
                Console.WriteLine(actual.Datos);
                actual = actual.siguiente;
            }
        }
    }
}