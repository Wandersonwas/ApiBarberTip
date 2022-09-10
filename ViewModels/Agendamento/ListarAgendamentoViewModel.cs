using BarberTip.Entities;
namespace BarberTip.ViewModels;
public class ListarAgendamentoViewModel{
    public ListarAgendamentoViewModel(int id,DateOnly data,TimeOnly hora, int idCliente)
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

