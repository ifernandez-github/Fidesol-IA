namespace Fidesol_IA
{
    /// <summary>
    /// Representa un pronóstico del clima para una fecha específica.
    /// </summary>
    public class WeatherForecast
    {
        /// <summary>
        /// Obtiene o establece la fecha del pronóstico.
        /// </summary>
        public DateOnly Date { get; set; }

        /// <summary>
        /// Obtiene o establece la temperatura en grados Celsius.
        /// </summary>
        public int TemperatureC { get; set; }

        /// <summary>
        /// Obtiene la temperatura en grados Fahrenheit.
        /// </summary>
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        /// <summary>
        /// Obtiene o establece un resumen del clima.
        /// </summary>
        public string? Summary { get; set; }
    }
}
