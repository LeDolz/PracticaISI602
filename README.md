# Mantenedor de refugio de animales

## Ventana inicio de sesión

En esta ventana el usuario deberá ingresar con su nombre de usuario y su contraseña, estas credenciales deberan ser asignadas por el administrador del software.

En el campo de nombre de usuario, el usuario deberá ingresar su nombre de usuario asignado previamente por el administrador de la base de datos que creó sus credenciales.
  
Por otro lado, en el campo de contraseña, el usuario deberá ingresar la contraseña asociada con su nombre de usuario.

* Si los datos son incorrectos, ya sea porque el nombre de usuario no exista en la base de datos, o porque la contraseña proporcionada no es la que se le asignó al nombre de usuario, una ventana emergente aparecerá para indicarle al usuario que el inicio de sesión no fue exitoso, en seguida, los campos de datos ingresados se limpiarán.

* Por el contrario, si los datos son correctos, el usuario será redirigido a la ventana llamada "Control de animales".

## Ventana control de animales

En esta ventana, se visualizarán todos los animales que se poseen en el refugio de animales. 

Para comenzar, se puede observar en el medio de la pantalla un listado de los animales, este listado es de solo vista, no se pueden modificar los datos del listado en esta pantalla, aunque se puede seleccionar un registro para poder usarlo en otros de los elementos de esta pantalla.
  
En la parte de arriba se puede observar un campo de texto donde se podrá ingresar una ID, este es el identificador único de cada animal, y al digitar un identificador en este campo y darle al botón "Buscar" que se encuentra a su derecha     el sistema intentará buscar en la base de datos   si es que existe una animal con dicho identificador.

* En el caso de que no se encuentre un animal con el identificador ingresado, aparecerá una ventana emergente la cuál indicará al usuario que no existe un animal con el inidcador ingresado, para después volver a cargar la lista con todos      los animales.

* En el caso de que se encuentre un animal con el identificador ingresado, la lista quitará todos los animales a excepción del animal con el identificador ingresado.

    
Abajo del listado de animales se pueden observar tres botones, estos son: Ingresar, Editar y ELiminar.

* El botón de ingresar, redigirá al usuario a la pantalla de ingreso de animal.
* El botón de editar, redigirá al usuario a la pantalla de edición de animal.
* El botón de eliminar, eliminará el registro de la lista que el usuario tenga seleccionado, esto se verá reflejado inmediatamente en la lista. 

Finalmente, en la esquina inferior izquierda se encuentra un botón el cual dice "Volver", este botón, al ser accionado, devolverá al usuario a la pantalla de inicio de sesión.

## Ventana de ingreso de animal
  
En esta ventana, se trata el registro de un animal, a continuación se detallan los elementos de esta tabla.
  
1. Ingreso de especie del animal -> En este campo, el usuario indicará la especie del animal. 
2. Fecha de ingreso del animal -> En este campo, el usuario deberá indicar la fecha en la cual el animal se Ingresó o ingresará al animal. Por defecto este campo tendrá la fecha del dia en el cual se esté operando.
3. Género del animal -> Aquí el usuario indicará si el animal es de género masculino o femenino. Si el usuario no indica un género, aparecerá una ventana emergente avisando que se debe escoger un género. 
4. Estado de vacunación del animal -> Es aquí en donde el usuario indica si es que el animal está o no vacunado. De igual manera que con el otro campo, si no se elige ninguna opción, aparecerá una ventana emergente indicandole al usuario que elija una de las opciones.
5. Ingreso de la celda del animal -> En este campo, el usuario digitará la celda en la que será alojado el animal.

Si es que cualquiera de estos campos está incompleto, aparecerá una ventana emergente indicandole al usuario este caso.

El botón que se encuentra abajo, al centro de la página el cual dice "Ingresar", verificará que los datos ingresados estén correctos con el formato de la base de datos, su esto falla, se mostrará una ventana emergente avisandole al usuario de esto.

En el caso de que todo esté en orden, el animal se registrará exitosamente.

Finalmente, en la esquina inferior izquierda se encuentra un botón el cual dice "Volver", este botón, al ser accionado, devolverá al usuario a la pantalla del control de animales.

## Ventana de edición de animales

En esta ventana, se puede editar un animal seleccionado. Igualmente, se detallarán los elementos presentes en la misma.

Al momento de cargar esta ventana, todos los siguientes campos se cargarán con la información del animal seleccionado.

1. Editar la especie del animal -> En este campo, el usuario tendrá la disponibilidad de cambiar la especie del animal. 
2. Editar fecha de ingreso del animal -> En este campo, el usuario puede indicar otra fecha de ingreso del animal.
3. Editar género del animal -> Aquí el usuario puede cambiar el género del animal por si es que ocurrió un error. 
4. Editar el estado de vacunación del animal -> Aquí el usuario puede cambiar el estado de vacunación del animal de manera manual.
5. Editar la celda del animal -> El usuario puede cambiar la celda del animal si es que se requiere.


El botón del centro, abajo, es para confirmar los cambios, si es que se deja un campo intacto a como se cargó, no se aplicarán los cambios a ese campo.

Finalmente, en la esquina inferior izquierda se encuentra un botón el cual dice "Volver", este botón, al ser accionado, devolverá al usuario a la pantalla del control de animales.
