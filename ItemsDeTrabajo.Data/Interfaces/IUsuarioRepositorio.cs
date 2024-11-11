namespace ItemsDeTrabajo.Data.Interfaces
{
    using Entidad.Dto;

    public interface IUsuarioRepositorio
    {
        List<DtoUsuarioVista> ObtenerUsuarios();
    }
}
