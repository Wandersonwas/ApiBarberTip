using BarberTip.Entities;
namespace BarberTip.ViewModels;
public class AtualizarAgendamentoViewModel{
    public AtualizarAgendamentoViewModel(int id,DateOnly data, TimeOnly hora, int idCliente)
    {
        Id = id;    
        Data = data;
        Hora = hora;
        IdCliente = idCliente;
    }
    public int Id { get; set; }
    public DateOnly Data { get; set; }
    public TimeOnly Hora { get; set; }
    public int IdCliente { get; set; }
       
}