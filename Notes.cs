/* al configurar este Eskeleton tener encuenta los siguientes pasos
1. restaurar los paquetes de las librerias con dotnet restore
2. revisar la cadena de conexion en appsettings.json
3. modificar el dbContex que se encuentra en data
4. inyectar el dbContext a la Api para la conexcion con la DB en program.cs y modificar
5. entidades Y DEFINIR LA CARDINALIDAD ENTRE ELLAS
6. configurar los DbSet en Context de Data
7. configurations
8. MIGRACION 
    ver si esta instalado = dotnet tool list -g  

    Instalar =dotnet tool install --global dotnet-ef  

    Crear la migracion = dotnet ef migrations add InitialCreateMig --project ./Persistencia/ --startup-project ./Api/ --output ./Data/Migrations/

    aplicar la migracion = dotnet ef database update --project ./Persistencia/ --startup-project ./Api/

9. unidad de trabajo
10. 



