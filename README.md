# Proyecto Kiosco Junior

## Introducción
Este repositorio contiene un proyecto que corresponde los dos parciales de las materias Programacion II y Laboratorio II, pertenecientes a la carrera Tecnicatura Universitaria en Programación.


## Aplicación
La aplicación es un Windows Form, hecho en .NET con C#.

Simula la gestión de un kiosco. Tiene usuarios con distintos roles, cada uno con su función.  
Maneja tres listas principales: usuarios, productos y ventas. Los usuarios manejadores (SuperUsuarios y Empleados)  
controlan estas tres colecciones. Los clientes utilizan un sistema de compras.

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
  
