# Práctica Formativa 2 – Metodología de Pruebas de Sistemas

## Descripción

Este proyecto implementa un sistema simple de gestión de productos con el objetivo de aplicar pruebas unitarias utilizando NUnit. Las funcionalidades incluidas son:

- Agregar productos
- Calcular el precio total con impuestos
- Buscar productos por nombre

---

## Estructura del proyecto

```
MPS_TP2/
│
└── src/
    ├── Product.cs               // Clase que representa un producto
    ├── ProductManager.cs        // Clase que gestiona los productos
│
└── tests/
    └── ProductManagementTests.cs   // Pruebas unitarias con NUnit
```

---

## Pruebas

- Verificar que un producto se crea correctamente con un id, name, price y category válidos.
- Verificar que addProduct agrega correctamente un producto a la lista interna.
- Agregar varios productos y verificar que findProductByName los encuentre correctamente por nombre.
- Verificar que calculateTotalPrice calcule correctamente el precio total con impuestos para productos de la categoría "Electrónica".
- Verificar que calculateTotalPrice calcule correctamente el precio total con impuestos para productos de la categoría "Alimentos".


---

## Reglas del negocio

- El precio de un producto no puede ser negativo.
- La categoría debe ser `"Electrónica"` o `"Alimentos"`.
- El impuesto aplicado al precio base es:
  - 10% para productos de electrónica
  - 5% para productos de alimentos

---

## Requisitos

- .NET SDK instalado  
- Extensiones de Visual Studio Code:
  - .NET Core Test Explorer  
  - C#  
  - C# Dev Kit  

---

## Cómo ejecutar las pruebas

1. Abrir una terminal en la raíz del proyecto.
2. Ejecutar el siguiente comando:

```bash
dotnet test
```

Esto compilará el proyecto y correrá todas las pruebas definidas en la clase `ProductManagementTests`.

---

## Autor

🧑‍💻 Román Ríos

Instituto Superior de Formación Técnica N° 29

Tecnicatura Superior de Desarrollo en Software

Metodología de Pruebas de Sistemas - Comisión A

Año 2025
