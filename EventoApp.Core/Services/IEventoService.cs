using EventoApp.Core.Models;
using Refit;

namespace EventoApp.Core.Services
{
    public interface IEventoService
    {
        [Get("/eventos")]
        Task<List<Evento>> GetEventos();

        [Get("/eventos/{id}")]
        Task<Evento> GetEvento(int id);

        [Post("/eventos")]
        Task<Evento> PostEvento([Body] Evento evento);

        [Put("/eventos/{id}")]
        Task PutEvento(int id, [Body] Evento evento);

        [Delete("/eventos/{id}")]
        Task DeleteEvento(int id);
    }
}
