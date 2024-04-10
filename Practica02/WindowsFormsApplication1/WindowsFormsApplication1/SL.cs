using System;
using System.Collections.Generic;
using System.Linq;

public class SL
{
    private DAL _dal;
    private BLL _bll;

    public SL()
    {
        _dal = new DAL();
        _bll = new BLL();
    }

    public void AgregarTrabajador(string nombre, string apellidos, decimal sueldoBruto, string categoria)
    {
        _dal.InsertarTrabajador(nombre, apellidos, sueldoBruto, categoria);
    }

    public List<TRABAJADORES> RecuperarTrabajadores()
    {
        return _dal.ObtenerTrabajadores().ToList();
    }

    public decimal CalcularAumentoPorcentual(decimal salarioActual, decimal porcentajeAumento)
    {
        return _bll.CalcularAumentoPorcentual(salarioActual, porcentajeAumento);
    }

    public decimal CalcularAumentoMonto(decimal salarioActual, decimal montoAumento)
    {
        return _bll.CalcularAumentoMonto(salarioActual, montoAumento);
    }

    public decimal CalcularSalarioNeto(decimal salarioBruto, decimal deducciones)
    {
        return _bll.CalcularSalarioNeto(salarioBruto, deducciones);
    }
}

