# Fidesol-IA

## Descripción
Fidesol-IA es una API desarrollada con ASP.NET Core 10 que proporciona funcionalidades de pronóstico del clima y más.

## Requisitos
- .NET 10 SDK o superior
- Visual Studio Community 2026 (recomendado)

## Instalación

1. Clonar el repositorio:
```bash
git clone https://github.com/ifernandez-github/Fidesol-IA.git
cd Fidesol-IA
```

2. Restaurar las dependencias de NuGet:
```bash
dotnet restore
```

3. Ejecutar la aplicación:
```bash
dotnet run
```

## Swagger UI

Esta API incluye **Swagger UI** para facilitar el testing y exploración de los endpoints.

### Acceder a Swagger UI

En modo desarrollo, accede a Swagger UI en:
```
https://localhost:7123
```

O también en:
```
https://localhost:7123/swagger
```

### Características de Swagger UI

- **Exploración de endpoints**: Visualiza todos los endpoints disponibles
- **Testing interactivo**: Prueba los endpoints directamente desde el navegador
- **Documentación automática**: Ver descripciones de parámetros y respuestas
- **Modelos de datos**: Inspecciona las estructuras de datos utilizadas

## Endpoints Disponibles

### Pronóstico del Clima

#### GET /WeatherForecast
Obtiene una lista de pronósticos del clima para los próximos 5 días.

**Respuesta (200 OK):**
```json
[
  {
    "date": "2024-01-15",
    "temperatureC": 25,
    "temperatureF": 77,
    "summary": "Warm"
  }
]
```

## Estructura del Proyecto

```
Fidesol-IA/
├── Controllers/          # Controladores de la API
├── Properties/           # Propiedades del proyecto
├── Program.cs           # Configuración principal
├── WeatherForecast.cs   # Modelo de datos
├── appsettings.json     # Configuración
└── Fidesol-IA.csproj   # Archivo de proyecto
```

## Configuración de Desarrollo

El archivo `appsettings.Development.json` contiene la configuración específica para el entorno de desarrollo.

## Tecnologías Utilizadas

- **ASP.NET Core 10**: Framework web
- **Swagger/OpenAPI**: Documentación de API
- **Swashbuckle**: Generador de Swagger para ASP.NET Core

## Contribuir

1. Crear una rama para tu feature (`git checkout -b feature/AmazingFeature`)
2. Commit de tus cambios (`git commit -m 'Add some AmazingFeature'`)
3. Push a la rama (`git push origin feature/AmazingFeature`)
4. Abrir un Pull Request

## Licencia

Este proyecto está bajo la Licencia MIT.
