# ContarPalabras

Url de servicio publicado en Azure 

https://ContadordePalabras.azurewebsites.net/

Metodo token

https://ContadordePalabras.azurewebsites.net/token

Usuario y contraseña para obtener el token 

{
	"Name":"tata",
	"Pasword": "tata"
}

Respuesta de token

{
   "message": "",
   "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6InRhdGEiLCJuYmYiOjE2NDM1ODE2MDMsImV4cCI6MTY0MzU4MTk2MywiaWF0IjoxNjQzNTgxNjAzfQ.bBduUAW5vHio6UeCy9phrO8btpBkeRrFRINL0g1daco",
   "type": "Bearer",
   "expira": 5
}

Metodo de contar palabras 

https://ContadordePalabras.azurewebsites.net/ContarPalabras

formato json para consumir el servicio:

{
	"textoValidar": "Los archivos JSON son simples archivos de texto con extensión json. Por ejemplo un nombre de archivo podría ser estudiantes. ... Un archivo json se puede crear con cualquier editor de texto plano. Hay que tener cuidado de usar siempre texto plano."
}

Respuesta del Json es un arreglos de palabra y la cantidad que contiene el texto 

{
   "message": null,
   "palabras":    [
            {
         "palabra": "LOS",
         "cantidad": 1
      },
            {
         "palabra": "ARCHIVOS",
         "cantidad": 2
      },
            {
         "palabra": "JSON",
         "cantidad": 1
      },
            {
         "palabra": "SON",
         "cantidad": 1
      },
            {
         "palabra": "SIMPLES",
         "cantidad": 1
      }
   ]
}
