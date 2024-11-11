namespace ItemsDeTrabajo.Servicios.Interfaces
{
    using Entidad.Dto;

    public interface IUsuarioServicio
    {
        List<DtoUsuarioVista> ObtenerUsuarios();

        Task<List<DtoUsuarioItemTrabajo>> ObtenerItemsTrabajo();
    }
}
