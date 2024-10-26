# Practica 11
Realizar un programa con interface grafica que simule la manipulación de un archivo por tres procesos diferentes como se mencionó en clase.

El programa debe de tener 3 ventanas (textbox), que funcionen de forma independiente con hilos o procesos, cada ventana deberá mostrar las siguientes opciones:
- Leer
- Editar
- Guardar

Se debe de implementar el algoritmo de lector-escritor (Semáforos) siguiendo las siguientes indicaciones:
- No debe permitir que dos escritores accedan al fichero al mismo tiempo.
- No debe permitir que un lector acceda al fichero si un escritor se encuentra escribiendo en él.
- Ambos lectores pueden acceder al fichero al mismo tiempo.

Al momento de leer se debe de simular una escritura en tiempo real, dicho de otra manera, debe de tener un pequeño delay por palabra o carácter donde se pueda apreciar que va apareciendo la información, y hasta que no deje de leer deberá de liberarse los damos procesos para editar.
