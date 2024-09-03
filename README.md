# 🏪 Maxikiosco Junior - Aplicación de escritorio en .NET con C#

Este proyecto es una aplicación de escritorio en .NET (Windows Forms), con C#. Fue hecho en 2023 y se trata de un sistema de gestión e interacción en un kiosco. Trabaja con una base de datos SQL y usuarios predeterminados.

## 📘 Descripción

Maxikiosco Junior es una aplicación de escritorio hecha en .NET con C#. Para acceder a las funcionalidades del sistema, es necesario iniciar sesión. El login tiene opciones de ingreso rápido para no tener que hacerlo manualmente. Hay 3 tipos de usuario: los administradores, los empleados, y los clientes. Los primeros van a acceder a las opciones de gestión del kiosco (productos, ventas, informes), mientras que los clientes van a poder comprar productos en la sección de compras.


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
  
  Esta es la pantalla principal que ve cualquier usuario, con la diferencia de las opciones del menú. En este caso, estamos viendo la vista de un administrador, el cual tiene acceso a todas las secciones. La del empleado es igual pero sin "Gestión Usuarios", "Informes", ni "Registros". 

  <img src="" width="600"/>

-- --



### Detalles generales
La aplicación inicia con un Login, tiene un botón 'Auto.' el cual autocompleta los datos de algún  
usuario aleatorio del sistema. También tiene botones de ingresos rápidos, para agilizar la corrección.  
Los SuperUsuarios y los Empleados tienen acceso a la ventana 'Productos', en la que pueden usar un ABM.  
También tienen la ventana de 'Ventas', en la cual verán el historial de ventas del sistema, con algunos datos extra.  

La diferencia entre el SuperUsuario y el Empleado es que el primero tiene acceso a la Gestión de Usuarios, a la  
sección de Informes, y al historial de Registros.  

Los clientes no tienen ninguna de esas funciones, estos solo podrán realizar compras en la ventana 'Compras'.  
Cada cliente tiene una lista de productos (Carrito), la cual va a crear agregándole los productos del sistema  
que seleccione. Cabe destacar que los productos tienen su propio Stock, por lo tanto, pueden agotarse.  

#### - Base de datos SQL
Ahora, los datos del programa persisten en una base de datos SQL Server. Tiene 3 tablas principales,  
para usuarios, productos y ventas. También contiene una tabla para los registros del programa.  

#### - Informes (CSV y JSON)
El SuperUsuario tiene acceso a la sección Informes. En ella, tiene la opción de importar y exportar datos,  
ya sea en formato CSV o JSON.  

#### - Archivos (Inactivo)
Se utilizan 3 archivos .txt para cargar las listas principales del proyecto. Estas 3 listas son manejadas por  
una clase estática llamada Sistema. Al clonar el repositorio estos archivos no existen, por lo tanto, el programa  
se encarga de crearlos por default (con un SuperUsuario).  

> [!NOTE]
> Universidad Tecnológica Nacional, 2023.
