# Introducción

En este repostiorio se encuentra una prueba de concepto para mostrar la forma de cambiar la configuración de una aplicación en tiempo de ejecución.

El proyecto consiste en una aplicación de Windows Forms construido con .NET Framework 4.8 usando el lenguaje de Visual Basic.

# Ejecución

Abrir con Visual Studio la solución [ConfigureExecution.sln](src/ConfigureExecution.sln) ubicada en la carpeta *src*.

Ejecutar presionando F5, por defecto tomará la condifuración de *Debug*.

1. La configuración actual de la aplicación se encuentra en [src/bin/Debug/ConfiguracionEjecucion.exe.Config](src/bin/Debug/ConfiguracionEjecucion.exe.Config) y debería verse así:

   ![1](images/Captura_0.JPG)
2. En el formulario se muestra el valor actual del parámetro *"Name"*.

   ![2](images/Captura_1.JPG)
3. Modifique el nombre por el valor deseado.

   ![3](images/Captura_2.JPG)
4. Presione el botón de *"Guardar"*.

   ![4](images/Captura_3.JPG)
5. Si revisa de nuevo la configuración en [src/bin/Debug/ConfiguracionEjecucion.exe.Config](src/bin/Debug/ConfiguracionEjecucion.exe.Config) podrá ver que el valor del parámetro *"Name"* cambió.

   ![5](images/Captura_4.JPG)
