# Skeleton NetCore :gem:

_Paso a paso para la reacion de un proyecto en .NetCore_

## Comenzando 🚀

_Estas instrucciones te permitirán obtener una copia del proyecto en funcionamiento en tu máquina local para propósitos de desarrollo y pruebas._

Mira **Deployment** para conocer como desplegar el proyecto.
---

### Paso a paso 📋
antes de iniciar deberias tener un repo y clonarlo en una carpeta de tu servidor, una vez realizado esto ingresamos a la carpeta desde la  terminal y ejecutamos los siguientes comandos.

_1.Crear solucion_
```bash
dotnet new sln
```
_2.Crear el proyecto Domain_
```bash
dotnet new classlib -o Domain
```
_3.Crear el proyecto Persistence_
```bash
dotnet new classlib -o Persistence
```
_4.Crear el proyecto Aplication_
```bash
dotnet new classlib -o Aplication
```
_5.Crear el proyecto Secutiry_
```bash
dotnet new classlib -o Security
```
_6.Crear la carpeta de Api_
```bash
dotnet new webapi -o Api
```
_7.Agregar los proyectos a la solucion_
```bash
dotnet sln add ./Domain/
```
```bash
dotnet sln add ./Persistence/
```
```bash
dotnet sln add ./Aplication/
```
```bash
dotnet sln add ./Security/
```
```bash
dotnet sln add ./Api/
```
_8.Establecer referencia entre proyectos_

Ingresa a la carpeta Aplication
```bash
dotnet add reference ../Domain/
```
```bash
dotnet add reference ../Persistence/
```
Ingresa a Api
```bash
dotnet add reference ../Aplication/
```
```bash
dotnet add reference ../Security/
```
Ingresa a Persistence
```bash
dotnet add reference ../Domain/
```
Ingresa a Security
```bash
dotnet add reference ../Aplication/
```