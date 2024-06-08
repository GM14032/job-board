namespace job_board.Dto
{
    public class OfertaLaboralDto
    {
        public int? Id { get; set; }
        public required int IdModoTrabajo { get; set; }

        public required int IdEmpresa { get; set; }

        public required string Nombre { get; set; }

        public required string Descripcion { get; set; }

        public required double SalarioMin { get; set; }

        public required double SalarioMax { get; set; }

        public required string PerfilAcademico { get; set; }

        public required string Experiencia { get; set; }

        public required List<ConocimientoDto> Conocimientos { get; set; } = new List<ConocimientoDto>();

        public required List<HabilidadDto> Habilidades { get; set; } = new List<HabilidadDto>();

    }
}
