# ContarPalabras

Usuario y contraseña para obtener el token 

{
	"Name":"tata",
	"Pasword": "tata"
}

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

Url de servicio publicado en Azure 

https://ContadordePalabras.azurewebsites.net/

