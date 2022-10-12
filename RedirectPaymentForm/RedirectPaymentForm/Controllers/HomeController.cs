using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RedirectPaymentForm.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.vads_action_mode = "INTERACTIVE"; 
            //MONTO
            ViewBag.vads_amount = "5000";
            //MODO TEST O PRODUCCION
            ViewBag.vads_ctx_mode = "TEST";
            //CODIGO SOLES=604 DOLARES=840
            ViewBag.vads_currency = "604";
            //NÚMERO DE CELULAR
            ViewBag.vads_cust_cell_phone = "XXXXXXXXXXXXXX";
            //CORREO
            ViewBag.vads_cust_email = "XXXXXXXXXXXXXXXXXXXXXXXX";
            //NOMBRES
            ViewBag.vads_cust_first_name = "XXXXXXXXXXXXXX";
            //APELLIDOS
            ViewBag.vads_cust_last_name = "XXXXXXXXXXXXX";
            //NÚMERO DE TELEFONO 
            ViewBag.vads_cust_phone = "XXXXXXXX";
            ViewBag.vads_page_action = "PAYMENT";
            ViewBag.vads_payment_config = "SINGLE";
            //USUARIO DE BACK OFFICE VENDEDOR
            ViewBag.vads_site_id = "46899889";
            //CAMBIAR DÍA ACTUAL CON 5 HORAS DE DIFERENCIA CON EL FORMATO  aaaammddhhmmss
            ViewBag.vads_trans_date = "aaaammddhhmmss";
            ViewBag.vads_trans_id = "rf54hY";
            ViewBag.vads_version = "V2";
            //CONSEGUIR FIRMA DESDE LA WEB https://herramientas-online.com/generador-hmac-online.html 
            ViewBag.signature = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";

            return View();
        }  
    }   
}

