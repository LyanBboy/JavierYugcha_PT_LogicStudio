namespace ItemsDeTrabajo.Data.Interfaces
{
    using Entidad.Dto;
    using Entidad.Models;

    public interface IItemTrabajoRepositorio
    {
        Task<IEnumerable<ItemTrabajo>> ObtenerItemsAsync(string estado = "");
        Task CrearItemAsync(DtoItemTrabajoRegistro item);
        Task ActualizarItemAsync(ItemTrabajo itemDeTrabajo);
    }
}
