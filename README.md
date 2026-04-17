# Gestión de Estados de un Sistema

## Descripción

En esta práctica hice un programa en C# para gestionar solicitudes de clientes.
El problema era que los estados se escribían como texto libre, lo que causaba errores (por ejemplo: pendient, done, etc.).

Para solucionarlo, usé un enum, así los estados son fijos y no se pueden escribir mal.


## ¿Por qué usar enum?

* Evita errores de escritura
* Hace el código más organizado
* Facilita la validación


## Implementación

* Creé el enum EstadoSolicitud
* Hice una clase Solicitud
* Usé una lista para guardar los datos
* Hice un menú en consola
* Agregué validaciones básicas


## Funcionalidades

* Registrar solicitudes
* Mostrar solicitudes
* Cambiar estado
* Buscar por ID



## Capturas

Aquí van las capturas del programa funcionando:

* Menú

<img width="315" height="195" alt="menu" src="https://github.com/user-attachments/assets/f1e3c0ac-d919-4cec-ba64-0c8366b80191" />


* Registro

<img width="340" height="142" alt="Screenshot_2" src="https://github.com/user-attachments/assets/382b9783-5620-46da-85b1-fc8f70dffdac" />


* Listado

<img width="323" height="234" alt="Screenshot_3" src="https://github.com/user-attachments/assets/13149ad7-4111-4687-b2c5-33d4d1bc6240" />


* Cambio de estado

<img width="313" height="191" alt="cambio de estado" src="https://github.com/user-attachments/assets/17475fdc-bfa0-4648-b9d7-120a2bac8f99" />


## Conclusión

Con esta práctica entendí mejor cómo usar enum y para qué sirve.
Me ayudó a evitar errores y a organizar mejor el código.
