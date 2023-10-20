# PracticaISI602
## Mantenedor de refugio de animales

## Ventana inicio de sesión

  En esta ventana el usuario deberá ingresar con su nombre de usuario y su contraseña, estas credenciales deberan ser asignadas por el administrador del software.

  En el campo de nombre de usuario, el usuario deberá ingresar su nombre de usuario asignado previamente por el administrador de la base de datos que creó sus credenciales.
  
  Por otro lado, en el campo de contraseña, el usuario deberá ingresar la contraseña asociada con su nombre de usuario.

    Si los datos son incorrectos, ya sea porque el nombre de usuario no exista en la base de datos, o porque la contraseña proporcionada no es la que se le asignó al nombre de usuario, una ventana emergente aparecerá para indicarle al          usuario   que el inicio de sesión no fue exitoso, en seguida, los campos de datos ingresados se limpiarán.
    Por el contrario, si los datos son correctos, el usuario será redirigido a la ventana llamada "Control de animales".

## Ventana control de animales

  En esta ventana, se visualizarán todos los animales que se poseen en el refugio de animales. 

  Para comenzar, se puede observar en el medio de la pantalla un listado de los animales, este listado es de solo vista, no se pueden modificar los datos del listado en esta pantalla, aunque se puede seleccionar un registro para poder         usarlo en otros de los elementos de esta pantalla.
  Em la parte de arriba se puede observar un campo de texto donde se podrá ingresar una ID, este es el identificador único de cada animal, y al digitar un identificador en este campo y darle al botón "Buscar" que se encuentra a su derecha     el sistema intentará buscar en la base de datos si es que existe una animal con dicho identificador.

    En el caso de que no se encuentre un animal con el identificador ingresado, aparecerá una ventana emergente la cuál indicará al usuario que no existe un animal con el inidcador ingresado, para después volver a cargar la lista con todos      los animales.
    En el caso de que se encuentre un animal con el identificador ingresado, la lista quitará todos los animales a excepción del animal con el identificador ingresado.
    
  Abajo del listado de animales se pueden observar tres botones, estos son: Ingresar, Editar y ELiminar.

    El botón de ingresar, redigirá al usuario a la pantalla de ingreso de animal.
    El botón de editar, redigirá al usuario a la pantalla de edición de animal.
    El botón de eliminar, eliminará el registro de la lista que el usuario tenga seleccionado, esto se verá reflejado inmediatamente en la lista. 

  Finalmente, en la esquina inferior izquierda se encuentra un botón el cual dice "Volver", este botón, al ser accionado, devolverá al usuario a la pantalla de inicio de sesión.

## Ventana de ingreso de animal
  
  En esta ventana, se trata el registro de un animal, a continuación se detallan los elementos de esta tabla.








