using System;

public class BLL
{
    public decimal CalcularAumentoPorcentual(decimal salarioActual, decimal porcentajeAumento)
    {
        decimal aumento = salarioActual * (porcentajeAumento / 100);
        return aumento;
    }

    public decimal CalcularAumentoMonto(decimal salarioActual, decimal montoAumento)
    {
        decimal nuevoSalario = salarioActual + montoAumento;
        return nuevoSalario;
    }

    public decimal CalcularSalarioNeto(decimal salarioBruto, decimal deducciones)
    {
        decimal salarioNeto = salarioBruto - deducciones;
        return salarioNeto;
    }
}
