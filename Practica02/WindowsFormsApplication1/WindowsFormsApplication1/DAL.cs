using System;
using System.Linq;

public class DAL
{
    private EmpresaDB db = new EmpresaDB();

    public void InsertarTrabajador(string nombre, string apellidos, decimal sueldoBruto, string categoria)
    {
        var nuevoTrabajador = new TRABAJADORES
        {
            NOMBRE = nombre,
            APELLIDOS = apellidos,
            SUELDO_BRUTO = sueldoBruto,
            CATEGORIA = categoria
        };

        db.TRABAJADORES.Add(nuevoTrabajador);
        db.SaveChanges();
    }


    public void ActualizarTrabajador(int id, string nombre, string apellidos, decimal sueldoBruto, string categoria)
    {
        var trabajador = db.TRABAJADORES.FirstOrDefault(t => t.ID == id);

        if (trabajador != null)
        {
            trabajador.NOMBRE = nombre;
            trabajador.APELLIDOS = apellidos;
            trabajador.SUELDO_BRUTO = sueldoBruto;
            trabajador.CATEGORIA = categoria;

            db.SaveChanges();
        }
    }


    public IQueryable<TRABAJADORES> ObtenerTrabajadores()
    {
        return db.TRABAJADORES;
    }
}
