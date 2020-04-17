namespace Cotizador.Core.Entities.Common
{
    public class RespuestaCambioToday
    {
        public Result Result { get; set; }
        public string status { get; set; }
    }

    public class Result
    {
        public string Source { get; set; }
        public string Target { get; set; }
        public double Value { get; set; } 
    }
}
