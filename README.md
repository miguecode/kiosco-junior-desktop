# Primer Parcial - Laboratorio II

## Datos
- Nombre: Gil Miguel Ángel
- Correo: junmigue7@gmail.com
- División 1C

### Proyecto Kiosco Junior
Mi aplicación simula la gestión de un kiosco. Tiene usuarios con distintos roles, cada uno con su función.  
Maneja tres listas principales: usuarios, productos y ventas. Los usuarios manejadores (SuperUsuarios y Empleados)  
controlan estas tres colecciones. Los clientes utilizan un sistema de compras.

### Detalles técnicos
La aplicación inicia con un Login, tiene un botón 'Auto.' el cual autocompleta los TextBox con los datos de algún  
usuario aleatorio del sistema. También tiene botones de ingresos rápidos, para agilizar la corrección.  
Los SuperUsuarios y los Empleados tienen acceso a la ventana 'Productos', en la que pueden usar un ABM.  
También tienen la ventana de 'Ventas', en la cual verán el historial de ventas del sistema, con algunos datos extra.  

La diferencia entre el SuperUsuario y el Empleado es que el primero tiene acceso a la Gestión de Usuarios, donde  
dispone de un ABM de usuarios.  

Los clientes no tienen ninguna de esas funciones, estos solo podrán realizar compras en la ventana 'Compras'.  
Cada cliente tiene una lista de productos (Carrito), la cual va a crear agregándole los productos del sistema  
que seleccione. Cabe destacar que los productos tienen un atributo Stock, por lo tanto, pueden agotarse.  
