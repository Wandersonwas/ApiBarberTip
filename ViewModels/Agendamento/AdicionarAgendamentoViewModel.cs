using BarberTip.Entities;
namespace BarberTip.ViewModels;
public class AdicionarAgendamentoViewModel{
    public AdicionarAgendamentoViewModel(DateOnly data, TimeOnly hora, int idCliente)
    {
          
        Data = data;
        Hora = hora;
        IdCliente = idCliente;
    }
  
    public DateOnly Data { get; set; }
    public TimeOnly Hora { get; set; }
    public int IdCliente { get; set; }
}