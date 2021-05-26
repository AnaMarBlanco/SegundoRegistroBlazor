using Microsoft.EntityFrameworkCore;
using SegundoRegistroBlazor.Data;
using SegundoRegistroBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SegundoRegistroBlazor.Controller
{
    public class PrestamosController
    {
       
        public static bool Guardar(Prestamos prestamos)
        {
            if (!Existe(prestamos.PrestamoId))
                return Insertar(prestamos);
            else
                return Modificar(prestamos);
        }
       
        public static bool Insertar(Prestamos prestamos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Prestamos.Add(prestamos);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }
        
        public static bool Modificar(Prestamos prestamos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(prestamos).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }
        
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var prestamos = contexto.Prestamos.Find(id);
                if (prestamos != null)
                {
                    contexto.Prestamos.Remove(prestamos);//Visibilidad en el Sistema.
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }
       
        public static Prestamos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Prestamos prestamos;

            try
            {
                prestamos = contexto.Prestamos.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }


            return prestamos;
        }
       
        public static List<Prestamos> GetList(Expression<Func<Prestamos, bool>> criterio)
        {
            List<Prestamos> lista = new List<Prestamos>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Prestamos.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }
       
        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Prestamos.Any(e => e.PrestamoId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }
        
        public static List<Prestamos> GetList()
        {
            List<Prestamos> list = new List<Prestamos>();
            Contexto contexto = new Contexto();

            try
            {
                list = contexto.Prestamos.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return list;
        }
    }
}
