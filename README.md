# Peluquería El Cojo - Sistema de Gestión

## Información del Estudiante
- **Nombre:** Luis Aquino Mejia
- **Matrícula:** 2023-0685
- **Asignatura:** ISW-123 Programación Media
- **Profesor:** Ing. Ivan Zorrilla

## Descripción
Sistema de gestión desarrollado en C# con Windows Forms para la Peluquería "El Cojo", permitiendo administrar de manera eficiente los clientes, empleados, servicios, inventario y facturación del negocio.

El sistema incluye autenticación de usuarios con control de roles, donde el Administrador tiene acceso completo al sistema y puede registrar nuevos usuarios, mientras que los demás roles tienen acceso limitado según sus permisos.

Además, el sistema permite generar facturas con cálculo automático de ITBIS, aplicar descuentos según el tipo de cliente, registrar ventas por empleado y almacenar un historial mediante funcionalidad de backup.

## Funcionalidades Principales
- Gestión de clientes con tipos (Nuevo, Regular, VIP) y descuentos automáticos
- Gestión de empleados con cálculo de salario basado en comisiones
- Catálogo de servicios con precios variables
- Control de inventario con validación de productos duplicados
- Sistema de facturación con múltiples servicios e ITBIS (18%)
- Generación de recibos en formato texto
- Registro de ventas por empleado
- Sistema de login conectado a base de datos SQL Server
- Control de acceso por roles (Administrador / Barbero)
- Funcionalidad de backup de facturas

## Conceptos Implementados
- ✅ Encapsulación (uso de campos privados y propiedades con validación)
- ✅ Herencia (clase base Servicio y clases derivadas como CorteNormal, Degradado, Afeitado, CorteCejas)
- ✅ Polimorfismo (uso de List<Servicio> con métodos sobrescritos)
- ✅ Interfaces (implementación de interfaz IFacturable)
- ✅ IComparable<T> (ordenamiento de empleados por ventas)
- ✅ ICloneable (clonado de objetos)
- ✅ IEquatable<T> (detección de productos duplicados)
- ✅ Atributos personalizados (validaciones como Requerido, Rango, TelefonoDominicano)
- ✅ Reflection (validación automática de objetos mediante atributos)
- ✅ Genéricos (uso de List<T> y métodos genéricos)
- ✅ Manejo de Strings y StringBuilder (generación de recibos y reportes)

## Tecnologías Utilizadas
- C#
- Windows Forms
- SQL Server
- .NET Framework

## Repositorio
Proyecto desarrollado con control de versiones en GitHub, cumpliendo con commits progresivos y descriptivos durante el desarrollo.
