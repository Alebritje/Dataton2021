# Sistema de verificación patrimonial

El sistema de verificación patrimonial, permite la revisón de la evolución patrimonial de los servidores públicos obligados, obteniendo datos de los sistemas integrados en la
Plataforma Diginal Nacional, dicho sistema, evaluado de acuerdo a varios parámetros, el riesgo de posible enriquecimiento ilícito por parte de los servidores públicos 
y da pauta a que los Órganos Internos de Control puedan llevar a cabo una revisón a fondo de patrimonio de estos.

## Descripción

El sistema evaluado basado en el nivel de cargo, los ingresos, si es un servidor público anteriormente sancionado y si se encuentra registrado como servidor público que participa
en contrataciones, con estos parámetros, el sistema determina un rango de riesgo de posible enriquecimiento ilícito, brindando a los OIC una vista general de como ha sido la evolución
del patrimonio del servidor público, así mismo muestra una gráficamente la relación de ingresos contra egresos para un analisis rápido del flujo de dinero por parte del servidor público.

## Getting Started

### Dependencias

* El sistema cuenta de dos partes, la API de consulta a los servicios API Rest de la Plataforma Digital Nacional y el Cliente.
* Ambos se encuentran desarrollados en el framework Net 5 y Net 6 ambos frameworks son libres, asimismo el lenguaje de programación es C#, y en el cado del cliente, la tecnología
utilizada es WebAssembly para hacer funcionar como una SPA.
* Los requitos ppor parte de la API, es un servidor web capáz de ejecutar Net Core, Net 5 o Net 6, como sistemas operativos puede ser Windows, Mac Os o Linux.
*Respecto a los requisitos de harwdware, dependerá del número de peticiones que se realice.

### Instalación

* Es necesario compilar y publicar ambos projectos para que de esa forma se generen las librerías y ensamblados requeridos.
* La API, se deberá de publicar en un servidor web con capacidad de ejecutar Net.
* El cliente, puede ser publicado en cualquier servidor web sin algún requisito especial, incluso un servidor web estático, ya que el navegador web descargará la aplicación
y será en este en la cual se ejecute y sólo hará llamadas a la API.


## Ayuda

Cualquier ayuda que requiera o sugerencia, favor de ponerse en contacto al correo electrónico.
```
omar.rdz.mqz@gmail.com
```

## Autor

 Omar Alejandro Rodríguez Márquez  
 omar.rdz.mqz@gmail.com

## Control de versiones
* 0.1
    * Initial Release

## Licencia

Este proyecto se encuentra bajo una licencia tipo Creative Commons
