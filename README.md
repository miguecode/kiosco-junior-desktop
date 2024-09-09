# 🏪 Maxikiosco Junior - Aplicación de escritorio

Este proyecto es una aplicación de escritorio realizada con .NET (Windows Forms), y C#. Fue hecho en 2023 y se trata de un sistema de gestión e interacción en un kiosco. Para funcionar, requiere la creación y la estructura de una base de datos específica.

## 📘 Descripción

Maxikiosco Junior es una aplicación de escritorio hecha en .NET con C#. Para acceder a las funcionalidades del sistema, es necesario iniciar sesión. El login tiene opciones de ingreso rápido para no tener que hacerlo manualmente. Hay 3 tipos de usuario: los administradores, los empleados, y los clientes. Los primeros van a acceder a las opciones de gestión del kiosco (productos, ventas, informes), mientras que los clientes van a poder comprar productos en la sección de compras. Todos los datos del sistema persisten en una base de datos SQL la cual es necesario crearla antes de usar la aplicación (se explica más adelante).

## 👨‍💼 Funcionalidades del Administrador

- **Gestión de Productos**: Muestra la lista de productos del sistema con sus detalles. También permite agregar, modificar o eliminar los que quiera.
- **Gestión de Usuarios**: Muestra la lista de usuarios del sistema con sus datos. También permite crear nuevos, eliminarlos, o modificar sus datos.
- **Ver estadísticas**: Muestra el historial de ventas (el cual puede vaciar), y ver estadísticas como la cantidad de ventas o de ingresos totales.
- **Exportación e importación**: Permite exportar o importar datos de usuarios productos y ventas, desde archivos de tipo CSV o JSON.
- **Ver registros**: Muestra el historial de acciones realizadas por los distintos usuarios del sistema, con su fecha y hora específica.

## 🧑 Funcionalidades de Empleados o Clientes

- **Los empleados** son como administradores pero con funcionalidades limitadas. Estos sólo van a tener acceso a la gestión de productos, y a ver las estadísticas de ventas.
- **Los clientes** no tendrán acceso a ninguna de las funcionalidades anteriores. Lo único que puede hacer un cliente es acceder al menú de compras, y realizar las compras que guste.

## 🖥️ Pantallas

- **Login**

  En esta pantalla, el usuario debe ingresar sesión. Con el boton "Auto.", se autocompleta con datos aleatorios (funcionales), y con los ingresos rápidos se ingresa automáticamente.

  <img src="https://github.com/user-attachments/assets/4f8a2399-d031-4021-9092-815cb39892d2" width="600"/>

- **Menú Principal**
  
  Esta es la pantalla principal que ve cualquier usuario, con la diferencia de las opciones del menú. En este caso, estamos viendo la vista de un administrador, el cual tiene acceso a       todas las secciones. La del empleado es igual pero sin "Gestión Usuarios", "Informes", ni "Registros". 

  <img src="https://github.com/user-attachments/assets/b76aaa67-d958-4d25-8870-dc111b34bb37" width="600"/>

- **Gestión de Productos**

  - En esta pantalla es donde los administradores y empleados van a poder ver la lista entera de productos, tengan o no stock. Pueden ver sus datos, y seleccionar alguno de toda la lista. Al seleccionar alguno (en este caso el primer elemento de ID 1001), el usuario podrá pulsar en **Detalles** para ver la descripción del producto, o también puede **modificarlo o eliminarlo**.
  - La lista puede ordenarse según el criterio que se elija (puede ser por cualquier dato).
  - El botón **Agregar** es para hacer un alta de un producto.
  - El botón **Stockear** aumentará el stock de todos los productos de la lista en la cantidad que se le indique. Por defecto, son 10.
  
    <img src="https://github.com/user-attachments/assets/2f30e1f3-4174-41fc-893b-b8385ba41b78" width="600"/>
 
- **Formulario para Productos**

  En esta pantalla, el administrador o empleado podrá crear un nuevo producto, o modificar el producto existente que haya seleccionado. Para confirmar el ingreso, debe completar todos los campos correspondientes sin excepción. 
    
  <img src="https://github.com/user-attachments/assets/eab15816-8dfb-4b52-b3d8-174e9947248a" width="600"/>

- **Gestión de Ventas**

  En esta pantalla, el administrador o empleado pueden ver el historial de ventas realizadas, y estadísticas varias. El historial se puede borrar, y también se puede seleccionar alguna venta de la lista para ver su información más específica.

  <img src="https://github.com/user-attachments/assets/1bce28fc-4aac-45d4-b530-0e6d35fac538" width="600"/>

- **Gestión de Usuarios**

  En esta pantalla, a la que sólo puede acceder un administrador, podrá ver la lista entera de usuarios. Al seleccionar alguno, podrá decidir **eliminarlo o modificarlo**. Con el botón **Agregar**, puede crear un nuevo usuario. La lista se puede ordenar por el criterio seleccionado.

  <img src="https://github.com/user-attachments/assets/8aee34b9-e952-4443-aa6a-8717f6bf6656" width="600"/>

- **Formulario para Usuarios**

  En esta pantalla, el administrador podrá crear un nuevo usuario, o modificar los datos de algún usuario existente que haya seleccionado. Para confirmar el ingreso, debe completar todos los campos correspondientes sin excepción. 

  <img src="https://github.com/user-attachments/assets/08eb8dab-892a-45cb-a258-cdba3c234cb1" width="600"/>

- **Importación/Exportación**

  En esta pantalla, el administrador tiene la posibilidad de exportar o importar datos, ya sea con archivos CSV o JSON.

  <img src="https://github.com/user-attachments/assets/903adff7-e1e9-415f-b17d-977d336ed052" width="600"/>

- **Registros**

  En esta pantalla, el administrador puede ver el historial de acciones realizadas por los distintos usuarios del sistema. También puede vaciar el historial si lo desea.

  <img src="https://github.com/user-attachments/assets/4c405be6-bbcf-4926-938f-8915ef0f075d" width="600"/>

- **Ver datos propios**

  Cada usuario, sea administrador, empleado o cliente, tendrá la posibilidad de ver y modificar sus propios datos.

  <img src="https://github.com/user-attachments/assets/b9e1f8d9-6331-4ed1-a3d8-fa7c4f9ee1eb" width="600"/>

- **Sección de Compras**

  Cada cliente puede acceder a esta pantalla, en la cual tiene 2 listas: una con todos los productos, de los cuales sólo se muestran los que tengan stock disponibles. Y la lista de productos que haya seleccionado, es decir, su carrito. El usuario puede quitar individualmente los productos que se haya arrepentido de seleccionar, o también puede vaciar el carrito entero. A la hora de pagar, puede elegir hacerlo en efectivo o por Mercado Pago (con un 5% de aumento).

  <img src="https://github.com/user-attachments/assets/14921b15-c7bf-4304-956d-4a69d4842eac" width="600"/>

- **Compra realizada**

  Cuando el cliente realiza el pago, se muestra esta pantalla con el detalle de los productos seleccionados.

  <img src="https://github.com/user-attachments/assets/269cdc3c-f8ed-4345-91e3-486ecbc6443c" width="600"/>


-- --


## 🚀 Cómo hacer funcionar la aplicación

Para que la aplicación se pueda usar, el usuario debe cumplir estos requisitos obligatoriamente:

- Tener instalado [SQL Server](https://www.microsoft.com/es-ar/sql-server/sql-server-downloads) de forma local en su máquina.
- Tener una base de datos llamada **MAXIKIOSCO_JUNIOR**, con una estructura específica acorde a lo que necesita el sistema.

Para hacer este último punto, dentro de este proyecto (dentro de la carpeta ***'db'***) hay 2 archivos .SQL, que son los siguientes:

- script.sql
- inserciones.sql

Estos archivos son consultas SQL, y tenemos que ejecutarlos. Primero ejecutamos **script.sql**, el cual se encarga de crear la base de datos, y establecer toda su esctructura (tablas y relaciones). Una vez hecho esto, hay que ejecutar **inserciones.sql**, el cual le carga datos básicos a la base de datos (como usuarios, roles, productos, tipos de productos). 

Una vez que se creó la base de datos y se le cargaron datos para inicializarla, ya se puede usar la aplicación correctamente (después de cerrarla y volverla a abrir si es necesario).

### Usando Visual Studio (Recomendado)

1. **Clonar el repositorio**: Primero que nada hay que clonar el repositorio o en su defecto descargar el ZIP.
   
2. **Abrir el proyecto en Visual Studio**: Abrir Visual Studio y seleccionar "Abrir un proyecto o solución". Después, ir hasta la carpeta del proyecto y elegir el archivo `Buffet-Consola.sln`. O más rápido, simplemente hacer doble clic en `Buffet-Consola.sln`.

3. **Compilar y ejecutar**: Con el proyecto cargado, ya se puede compilar y ejecutar normalmente. Esto abrirá la aplicación de consola.

### Usando Visual Studio Code

1. **Instalar .NET SDK**: Antes que nada, hay que tener instalado [SDK de .NET 6.0](https://dotnet.microsoft.com/download/dotnet/6.0) en tu máquina.

2. **Clonar el repositorio**: Después, clonar el repositorio o en su defecto descargar el ZIP.

3. **Abrir el proyecto en Visual Studio Code**: Abrir Visual Studio Code y abrir la carpeta del proyecto.

4. **Compilar y ejecutar**: Ya en el VSC, abrir la terminal integrada (`Ctrl + ñ`) y navegar hasta la carpeta del proyecto. Por último, usar el comando `dotnet run` para compilar y ejecutar la aplicación.

## 📌 Aclaraciones
- Como se vio en el punto anterior, la aplicación requiere un proceso previo de creación e inicialización de una base de datos SQL Server.
- En caso de fallar ese proceso, la aplicación no se rompe, sino que te muestra un cartel informando el problema.
- Fue creado en 2023, mientras cursaba la carrera de Tecnicatura Universitaria en Programación, en la Universidad Tecnológica Nacional.
- El proyecto está bajo la licencia MIT.

## 🗃️ Otros proyectos similares
- [Juego de Ahorcado - Aplicación de consola en C#](https://github.com/Leumig/CSharp-Ahorcado-Consola)
- [Buffet - Aplicación de consola en C#](https://github.com/Leumig/CSharp-Buffet-Consola)
