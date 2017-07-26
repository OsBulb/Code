# Scaffolding

## Intro

Proyecto base para ejemplificar la funcionalidad de EntityFramework(de ahora en adelante "EF") orientado a MVC (razor) basado en EDM.

## Entity Data Model

EDM: El análisis de requerimientos es el punto inicial de las principales metodologías de desarrollo de software. El correcto análisis de requerimientos y la elaboración de una arquitectura robusta, son etapas claves para que el EF sea una herramienta muy útil (y satisfactoria).

El EF es capaz de interpretar las claves primarias y foráneas directamente desde el modelo relacional y traducirlas automáticamente en una vista, transformando una relación de entidades en una vista que identifica de forma automática la relación entre entidades.


## Scaffolding

Palabra que está presente en múltiples frameworks y que hace referencia a la capacidad de generar código a partir de una base de datos. Muy útil para evitar reinventar la rueda ganando una cantidad importante de tiempo pero por ningún motivo va a realizar todo el trabajo por nosotros.

En MVC .Net, es preciso generar el modelo de datos, basados (idealmente) en el diagrama de clases y utilizando el modelo generado previamente por el EDM. De lo contrario nuestro MVC sería solo un triste MC, que funciona, pero es triste.

