using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Circulares
{
    class Estuctura
    {
        ClaseBase inicio = null, final = null;
        public void agregar(ClaseBase nuevo)
        {
            if(inicio==null)
            {
                inicio = nuevo;
                final = nuevo;
                inicio.Anterior = final;
                final.Siguiente = inicio;
            }else
            {
                nuevo.Anterior = final;
                final.Siguiente = nuevo;
                final = nuevo;
                inicio.Anterior = final;
                final.Siguiente = inicio;
            }

        }

        public ClaseBase Buscar(string nombre_search)
        {
            bool sup= true;
            ClaseBase temp = inicio;
             while(sup)
            {
                if(temp.Nombre == nombre_search)
                {
                    return temp;
                }
                temp = temp.Siguiente;
                if (temp == inicio)
                    sup = false;
            }
            return null;
        }

        public ClaseBase EliminarUltimo()
        {
            ClaseBase temp;
            final.Anterior.Siguiente = inicio;
            temp = final;
            inicio.Anterior = final.Anterior;
            final = final.Anterior;
            return temp;
        }
        public ClaseBase EliminarInicio()
        {
            ClaseBase temp;
            inicio.Siguiente.Anterior = final;
            temp = inicio;
            final.Siguiente = inicio.Siguiente;
            inicio = inicio.Siguiente;
            return temp;
        }
        
        public ClaseBase Eliminar(string nombreBase)
        {
            if (inicio != null)
            {
                ClaseBase temp = inicio, tempoo;
                bool sup = true;
                while (sup)
                {
                    if (temp.Nombre == nombreBase && inicio.Nombre == nombreBase && inicio.Anterior == inicio)
                    {
                        tempoo = inicio;
                        inicio = null;
                        final = null;
                        return tempoo;
                    }else if (inicio.Nombre == nombreBase)
                    {
                        EliminarInicio();
                    }else if (final.Nombre == nombreBase)
                    {
                        EliminarUltimo();
                    }else if (temp.Nombre == nombreBase)
                    {
                        tempoo = temp;
                        temp.Anterior.Siguiente = temp.Siguiente;
                        temp.Siguiente.Anterior = temp.Anterior;
                        return tempoo;
                    }
                    temp = temp.Siguiente;
                    if (temp == final && temp == inicio)
                    {
                        sup = false;
                    }
                }
            }
            return null;
        }

        public string listar()
        {
            string chin="";
            bool sup = true;
            ClaseBase temp = inicio;
            while(sup)
            {
                chin += temp.ToString()+"\r\n"; 
                temp = temp.Siguiente;
                if (temp == inicio)
                {
                    sup = false;
                }
            }
                return chin;
        }

        public void insertar(ClaseBase fufu, int pos)
        {
            int i=1;
            bool sup = true;
            ClaseBase temp = inicio;
            while(sup)
            {
                i++;
                temp = temp.Siguiente;
                if(temp == inicio)
                {
                    if(pos < 2)
                    {
                        temp.Anterior = fufu;
                        fufu.Siguiente = inicio;
                        final = inicio;
                        inicio = fufu;
                        sup = false;
                    }else
                    {
                        temp.Siguiente = fufu;
                        fufu.Anterior = inicio;
                        final = fufu;
                        sup = false;
                    }
                }
                if(i == pos)
                {
                    sup = false;
                }
            }
            temp.Anterior.Siguiente = fufu;
            temp.Anterior = fufu;
            fufu.Siguiente = temp;
            fufu.Anterior = temp.Anterior;
        }

        public string Ruta(string nombreBase, DateTime horainicio,DateTime horafin)
        {
            ClaseBase temp = Buscar(nombreBase);
            string res="";
            if(temp == null)
            {
                res = "object not found";
            }else
            {
                res = "Base " + temp.Nombre + " tiempo " + horainicio.TimeOfDay+"\r\n";
                while(horainicio.TimeOfDay<horafin.TimeOfDay)
                {
                    horainicio = horainicio.AddMinutes(temp.tiempo);
                    temp = temp.Siguiente;
                    
                    res+= "Base " + temp.Nombre + " tiempo " +horainicio.TimeOfDay + "\r\n";
                }
            }
            return res;
        }
    }
}
