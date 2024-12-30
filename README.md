# Sistema de Liquidación de Expensas  

## Descripción del Proyecto  
Este proyecto fue desarrollado en colaboración con mi compañera, y tiene como objetivo crear un sistema integral para la gestión de expensas en consorcios de edificios y condominios. Diseñado como un Producto Mínimo Viable (MVP), el sistema busca modernizar la administración de gastos e ingresos mediante herramientas tecnológicas que agilizan los cálculos, la generación de reportes y la organización de información clave.

El sistema fue implementado utilizando tecnologías como C# (.NET) y SQL Server, proporcionando una interfaz intuitiva y funcional para que los administradores puedan gestionar múltiples consorcios de manera eficiente. Esta colaboración permitió complementar habilidades y abordar los desafíos del desarrollo con una visión conjunta, logrando un producto que satisface las necesidades de los usuarios.

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
![FormLogin](https://github.com/user-attachments/assets/52bddca6-9aad-49aa-b5f9-af83f12909a0)


### Pantalla Principal
<img width="424" alt="FrmMenu" src="https://github.com/user-attachments/assets/ae863f1b-a48c-4997-a831-e76af5a28b10" />


### Pantalla Registro
<img width="437" alt="FrmRegistro" src="https://github.com/user-attachments/assets/def7e5c6-b0a5-45ec-82ac-77d19eeb020b" />

#### Filtros De Propietarios
<img width="425" alt="FrmPropietarioRegistro" src="https://github.com/user-attachments/assets/338deb0a-445f-4f7f-890c-15deb0bd5c98" />

#### Carga de Egresos
<img width="405" alt="FrmEgreso" src="https://github.com/user-attachments/assets/ce2c2a80-cc0c-416f-b75d-996494789bab" />

### Carga de Ingresos
<img width="215" alt="FrmIngreso" src="https://github.com/user-attachments/assets/6bb82332-8a1d-4afb-9799-c7b64263f4ad" />

### Gestion De Expensas
<img width="437" alt="FrmRegistro" src="https://github.com/user-attachments/assets/5da10ba2-10ff-4bf3-b435-493728878961" />

#### Reporte de Expensas
![repor](https://github.com/user-attachments/assets/ad5801d6-f187-441d-9a7a-c3766f9fc868)
![eg](https://github.com/user-attachments/assets/6791c594-b33e-435e-8519-51426752adb6)



#### Gestion De Agenda
<img width="342" alt="FormAgenda" src="https://github.com/user-attachments/assets/2cadda48-d931-48d7-9d9c-e36ecaa50f9d" />

#### Gestion de Comunicado
<img width="221" alt="FrmComunicado" src="https://github.com/user-attachments/assets/c69181cf-fc5e-4fd0-9ea2-4ecf21481046" />

### Pantalla Consorcios
<img width="406" alt="FrmConsorcio" src="https://github.com/user-attachments/assets/28076f8d-d4e4-4896-951f-b953bbe0725d" />
<img width="262" alt="FrmAgregarEditarConsorcio" src="https://github.com/user-attachments/assets/60e29891-6190-4040-a7fb-deda50151c05" />

### Pantalla Unidades
<img width="404" alt="FrmUnidad" src="https://github.com/user-attachments/assets/824e7498-b23c-489b-85f2-ecf7deba4ecb" />
<img width="322" alt="FrmAgregarEditarUnidad" src="https://github.com/user-attachments/assets/a3e1b617-1035-4edc-b065-b560f3515c08" />

### Pantalla Propietarios

<img width="408" alt="FrmPropietario" src="https://github.com/user-attachments/assets/14942f36-7a99-42dd-98f5-467a108d6186" />
<img width="283" alt="FrmAgregarEditarPropietario" src="https://github.com/user-attachments/assets/3d38d2f6-0d0e-45c4-8d81-1abc7939be17" />

### Pantalla Administrador
<img width="405" alt="FrmAdmin" src="https://github.com/user-attachments/assets/117b37b3-8aa8-4551-bc3f-c2bbe75625aa" />
<img width="381" alt="FrmAgregarEditarAdmin" src="https://github.com/user-attachments/assets/f9111ee3-ecdb-4124-9a1f-50172d6d5c6d" />

