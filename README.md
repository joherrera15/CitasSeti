# PruebaSeti

Proyecto REST Api en .NET Core que permite a la organización determinar que Bróker tiene los proyectos menor tiempo de recuperación de la inversión
y proyectos con mayor beneficio generado por la inversión.

### Pre-requisitos 📋

Programas que se necesita para ejecutar el proyecto

```

.Net core 7.0
Visual Code

```

## Ejecutando las pruebas ⚙️

se debe buscar appsettings.json dentro de ella se busca una etiqueta con el nombre ConnectionStrings

"ConnectionStrings": {
    "SqlConnection": "Data Source=?;Initial Catalog=?;Persist Security Info=True;User ID=?;Password=?"
  },
  
 se  debe cambiar 
 Data Source: datos del Host
Initial Catalog: setitechtest
User ID=Usuario de conexion de la base de datos
Password=Contraseña

para poder consumir el servicio que genera un listado de Bróker con proyectos con menor tiempo de recuperación de la inversión
se debe utilizar la siguiente direccion url

https://localhost:5001/api/Payback

genera un listado con los siguientes campos

* BrokerId
* BrokerName
* ProjectId
* InversionInicial
* SumaFlujos
* CantidadPeridos
* FlujoCajaAñosAntesRecuperar
* payback indicador Proyectos con menor tiempo de recuperación de la inversión


para poder consumir el servicio que genera un listado de Bróker con proyectos  de mayor beneficio generado por la inversión.
se debe utilizar la siguiente direccion url

https://localhost:5001/api/Van

genera un listado con los siguientes campos

* BrokerId
* BrokerName
* ProjectId
* InversionInicial
* Van  indicador proyectos  de mayor beneficio generado por la inversión.








