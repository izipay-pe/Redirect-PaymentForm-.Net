# Redirect-PaymentForm-.Net

<p></p>

<p align="justify">
Ejemplo del formulario en Redirección, para utilizar el Lenguaje de Programación C# con el Framework .NET de Microsoft dentro de tu proyecto. C# es un lenguaje de programación multiparadigma y muy sofisticado que ha evolucionado en conjunto con el framework de Microsoft .NET. Tiene nuevas características, como tipos por referencia nullables, rangos, índices, streams asíncronos.
</p> 

![pagar](images/formulario-redireccion.png)

## Este ejemplo es solo una guía para poder realizar la integración de la pasarela de pagos, puede realizar las modificaciones necesarias para su proyecto.   

<a name="Requisitos_Previos"></a>

## Requisitos Previos

* Acceso al Back Office Vendedor (BOV) y Claves de autenticación. [Guía Aquí](https://github.com/izipay-pe/obtener-credenciales-de-conexion)
* Descargar el manual desde [Manual Izipay - implementación en REDIRECCIÓN](https://secure.micuentaweb.pe/doc/es-PE/form-payment/quick-start-guide/sitemap.html).
* Instalar Visual Studio [Aquí](https://visualstudio.microsoft.com/es/)
* Version de .NET CORE de 3 en adelante

## 1.- Crear el proyecto
Descargar el proyecto .zip haciendo click [Aquí](https://github.com/izipay-pe/Redirect-PaymentForm-.Net/archive/refs/heads/main.zip) o clonarlo desde Git.
```sh
git clone https://github.com/izipay-pe/Redirect-PaymentForm-.Net.git
``` 
* Correr con IIS Express de manera Local 
* Ejecútelo y pruébelo con el siguiente comando: `F5` desde la Vista `Home` `Index.cshtml` y abrira con su navegador web predeterminado

  ver el resultado en: "https://localhost:44345/"

## 2.- Configurar datos de conexión

**Nota**: Reemplace **[CHANGE_ME]** con su credencial de `Claves` extraída desde el Back Office Vendedor, ver [Requisitos Previos](#Requisitos_Previos).

* Editar el archivo en la siguiente ruta `RedirectPaymentForm -> Controllers -> HomeController.cs` con las claves de su Back Office Vendedor

     ![controlador](images/controlador2.png)

  ```c#   
  public IActionResult Index()
        {
            PaymentModel pago = new PaymentModel();
            pago.vads_action_mode = "INTERACTIVE";
            pago.vads_page_action = "PAYMENT";
            pago.vads_payment_config = "SINGLE";
            pago.vads_version = "V2";
            pago.KEY = "~~CHANGE_ME_KEY~~";

            return View(pago);
        }  
  ```
     ![demo2](images/demo2.png)
     
## 3.- Transacción de prueba

El formulario de pago está listo, puede intentar realizar una transacción utilizando una tarjeta de prueba. 

Puede consultar las tarjetas de prueba desde este enlace: [Tarjetas de Prueba](https://secure.micuentaweb.pe/doc/es-PE/rest/V4.0/api/kb/test_cards.html).

   * Tarjeta de prueba Visa:
      - *Número de tarjeta*: 4970100000000055
      - *Fecha de vencimiento*: 12/30   
      - *Código de seguridad*: 123

NOTA: 

1.- Paso de la tienda al modo PRODUCTION 
     
     Modifique su implementación para utilizar redireccion:
     * Complete el campo vads_ctx_mode a PRODUCTION .
     * Cambie el valor de la clave de prueba con el valor de su clave de producción para calcular la firma.
     * Encontrará este valor en el menú Configuración > Tienda > pestaña Claves .
     * Complete la URL de notificación correctamente al final del pago en el modo PRODUCCIÓN en el menú Configuración > Reglas de notificaciones .
 
## 4.- Gestionar la notificacion de fin de pago (IPN)

IPN son las siglas de Instant Payment Notification (URL de notificación instantánea, en inglés). Al crear una transacción o cambiar su estado, nuestros servidores emitirán una IPN que llamará a una URL de notificación en sus servidores. Esto le permitirá estar informado en tiempo real de los cambios realizados en una transacción.

Las IPN son la única manera de recibir notificaciones en los casos siguientes:

* La conexión a Internet del comprador se ha cortado.
* El comprador cierra su navegador durante el pago.
* Se ha rechazado una transacción.
* El comprador no ha terminado su pago antes de la expiración de su sesión de pago.

Por lo tanto, es obligatorio integrar las IPN.

 <p align="center">
     <img src="/images/IPN-imagen.png?raw=true" alt="Formulario"/>
   </p>  

* Ver manual de implementacion de la IPN [Aquí](https://secure.micuentaweb.pe/doc/es-PE/rest/V4.0/kb/payment_done.html)

* Ver el ejemplo de la respuesta IPN con PHP [Aquí](https://github.com/izipay-pe/Redirect-PaymentForm-IpnT1-PHP)

* Ver el ejemplo de la respuesta IPN con NODE.JS [Aquí](https://github.com/izipay-pe/Response-PaymentFormT1-Ipn)

                                      





