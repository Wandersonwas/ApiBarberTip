using BarberTip.Contexts;
namespace BarberTip.Entities;
public class Agendamento{
    public Agendamento(DateOnly data, TimeOnly hora, int idCliente)
    {
        Data = data;
        Hora = hora;
        IdCliente = idCliente;
    }
    public int Id { get; set; }  
    public DateOnly Data { get; set; }
    public TimeOnly Hora { get; set; }
    public int IdCliente { get; set; }
    public Cliente Cliente { get; set; } = null!;    
}