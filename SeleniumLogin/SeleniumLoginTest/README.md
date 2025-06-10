# Clase 10/06/2025 - Selenium Login Test

Este proyecto contiene pruebas automatizadas con Selenium para verificar el proceso de inicio de sesión en una aplicación web.

## Cómo correr las pruebas

```
dotnet test
```

## Apuntes

Cómo se creó este proyecto:

```
dotnet new nunit -n SeleniumLoginTest
```

Acceder a subcarpeta:

```
cd SeleniumLoginTest
```

Instalación de dependencias:

```
dotnet add package Selenium.WebDriver
dotnet add package Selenium.WebDriver.ChromeDriver
dotnet add package NUnit3TestAdapter
```