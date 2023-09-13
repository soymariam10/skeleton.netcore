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
  docker image ls
  ```
_2.Crear el proyecto Domain_
    ```
    dotnet new classlib -o Domain
    ```
_3.Crear el proyecto Persistence_
    ```
    dotnet new classlib -o Persistence
    ```
_4.Crear el proyecto Aplication_
    ```
    dotnet new classlib -o Aplication
    ```
_5.Crear la carpeta de Api_
    ```
    dotnet new webapi -o Api
    ```