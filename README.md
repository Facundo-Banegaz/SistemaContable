# Sistema de Liquidación de Expensas  

## Descripción del Proyecto  
Este proyecto tiene como objetivo desarrollar un sistema integral para la gestión de expensas en consorcios de edificios y condominios. Diseñado como un **Producto Mínimo Viable (MVP)**, el sistema busca modernizar la administración de gastos e ingresos mediante herramientas tecnológicas que agilizan los cálculos, la generación de reportes y la organización de información clave.  

El sistema utiliza tecnologías como **C# (.NET)** y **SQL Server**, proporcionando una interfaz intuitiva para administradores encargados de múltiples consorcios.  

---

## Funcionalidades Principales  
### Gestión General  
- **CRUD Completo**:  
  - Administradores.  
  - Propietarios.  
  - Unidades.  
  - Consorcios.  

### Ventanas de Registro  
1. **Agenda de Anotaciones**:  
   - Permite al usuario crear y gestionar notas relacionadas con los consorcios.  
   - Ideal para registrar recordatorios o tareas específicas.  

2. **Envío de Correos Electrónicos**:  
   - Herramienta integrada para enviar correos electrónicos a propietarios o administradores.  
   - Permite comunicación directa desde la plataforma.  

3. **Filtrado de Propietarios**:  
   - Ventana dedicada para buscar y filtrar propietarios según diferentes criterios.  
   - Facilita la localización de información específica.  

4. **Carga de Egresos**:  
   - Permite registrar los gastos asociados a cada consorcio.  
   - Los egresos están clasificados por categorías (mantenimiento, servicios, impuestos, etc.).  

5. **Carga de Ingresos**:  
   - Registro de pagos realizados por propietarios.  
   - Vincula los ingresos al consorcio correspondiente y al propietario que los realizó.  

6. **Distribución de Egresos entre Propietarios**:  
   - Ventana con funcionalidad avanzada para calcular y distribuir los gastos de un consorcio entre sus propietarios:  
     - Filtrado mediante un combo box que selecciona el consorcio.  
     - Muestra los propietarios con su porcentaje (%) de participación en las unidades.  
     - Calcula automáticamente el monto que corresponde a cada propietario según su porcentaje de unidad y los egresos del consorcio.  

7. **Generación de Reportes**:  
   - Genera reportes detallados en formatos **PDF**, **Word** o **Excel**:  
     - Reportes por consorcio.  
     - Reportes de propietarios con sus porcentajes de unidad y montos correspondientes.  

---

## Tecnologías Utilizadas  
- **Lenguaje de Programación**: C# (.NET).  
- **Base de Datos**: SQL Server.  
- **Entorno de Desarrollo**: Visual Studio.  
- **Framework**: ASP.NET (si aplica).  

---

## Modelo de Base de Datos  

El sistema utiliza un modelo de base de datos relacional que organiza la información clave del sistema. A continuación, se describen las principales entidades y relaciones:  

1. **Administradores**  
   - Administran múltiples consorcios.  

2. **Consorcios**  
   - Representan los edificios o condominios gestionados por los administradores.  

3. **Propietarios y Unidades**  
   - Los propietarios están asociados a unidades, con un porcentaje (%) de participación.  

4. **Egresos e Ingresos**  
   - Los egresos corresponden a los gastos comunes de los consorcios.  
   - Los ingresos representan los pagos realizados por los propietarios.  

---
### Diagrama de Clases
![Captura de pantalla 2024-12-06 172739](https://github.com/user-attachments/assets/9fcb6c4d-e975-4cee-9e10-679b3bd9efab)


### Diagrama de Base de Datos  

![Captura de pantalla 2024-12-07 113340](https://github.com/user-attachments/assets/9541f294-57d2-40e5-ae95-bc512b50487b)

---

## Instalación y Configuración  

### Requisitos Previos  
1. Instalar el **.NET SDK** compatible con el proyecto.  
2. Configurar una instancia funcional de **SQL Server**.  
3. Tener instalado un IDE como **Visual Studio**.  

### Pasos de Instalación  
1. Clonar el repositorio:  
   ```bash  
[   git clone https://github.com/tuusuario/sistema-expensas.git  ](https://github.com/Facundo-Banegaz/SistemaContable.git)


## Imágenes del Proyecto
A continuación, se presentan capturas de pantalla del sistema en funcionamiento:
### Pantalla Login
<img width="266" alt="FormLogin" src="https://github.com/user-attachments/assets/735ef506-2221-4c11-9b69-c0c6697d67ae" />

### Pantalla Principal
<img width="287" alt="Captura de pantalla 2024-12-07 234251" src="https://github.com/user-attachments/assets/2375e5b1-c633-4c56-bc99-d363b796b8b1" />
<img width="221" alt="FrmComunicado" src="https://github.com/user-attachments/assets/e8fd7f72-0cb0-4cd3-ab1b-972984600f2d" />
<img width="437" alt="FrmRegistro" src="https://github.com/user-attachments/assets/cc524363-54dc-4ea9-9b0c-00ad99cf2374" />
<img width="342" alt="FormAgenda" src="https://github.com/user-attachments/assets/a2abce8c-cc60-4a70-b816-b9990cf83a8e" />
<img width="405" alt="FrmEgreso" src="https://github.com/user-attachments/assets/7f65fec8-15da-4b41-ab5d-8f2d2c1cd81d" />
<img width="215" alt="FrmIngreso" src="https://github.com/user-attachments/assets/c7184b70-f008-46f4-842e-8ed4f43529f4" />
<img width="382" alt="FrmExpensas" src="https://github.com/user-attachments/assets/0f103c77-04d4-4a2f-ac6c-7f331b0b90d2" />


### Pantalla Registro
<img width="437" alt="FrmRegistro" src="https://github.com/user-attachments/assets/def7e5c6-b0a5-45ec-82ac-77d19eeb020b" />



### Gestión de Consorcios

### Carga de Egresos

### Distribución de Egresos

### Generación de Reportes
