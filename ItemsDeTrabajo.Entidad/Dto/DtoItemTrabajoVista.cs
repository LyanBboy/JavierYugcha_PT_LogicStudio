namespace ItemsDeTrabajo.Entidad.Dto
{
    public class DtoItemTrabajoVista
    {
        public string Descripcion { get; set; } = "";

        public DateTime FechaCreacion { get; set; }

        public DateTime FechaEntrega { get; set; }

        /// <summary>alta; baja// </summary>
        public string Relevancia { get; set; } = "baja";

        /// <summary>PENDIENTE, COMPLETADO// </summary>
        public string Estado { get; set; } = "PENDIENTE";

        public string? UserName { get; set; }
    }
}
