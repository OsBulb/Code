# MVC

## Intro

Proyecto base para ejemplificar la funcionalidad de EntityFramework(de ahora en adelante "EF") orientado a MVC (razor) basado en EDM.

## Entity Data Model

EDM: El analisis de requerimientos es el punto inicial de las principales metodologias de desarrollo de software. El correcto analisis de requerimientos y la elaboracion de una arquitectura robusta, son etapas claves para que el EF sea una herramienta muy util (y satisfactoria).

El EF es capaz de interpretar las claves primarias y foraneas directamente desde el modelo relacional y traducirlas automaticamente en una vista, transformando una relacion de entidades en una vista que identifica de forma automatica la relacion entre entidades.

## Scaffolding

Palabra que esta presente en multiples frameworks y que hace referencia a la capacidad de generar codigo a partir de una base de datos. Muy util para evitar reinventar la rueda ganando una cantidad importante de tiempo pero por ningun motivo va a realizar todo el trabajo por nosotros.

En MVC .Net, es preciso generar el modelo de datos, basados (idealmente) en el diagrama de clases y utilizando el modelo generado previamente por el EDM. De lo contrario nuestro MVC seria solo un triste MC, que funciona, pero es triste.
