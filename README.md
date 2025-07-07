<p align="center">
    <img src="https://raw.githubusercontent.com/PKief/vscode-material-icon-theme/ec559a9f6bfd399b82bb44393651661b08aaf7ba/icons/folder-markdown-open.svg" align="center" width="30%">
</p>
<p align="center"><h1 align="center">TIKTOKVIDEOMAKERFINAL.GIT</h1></p>
<p align="center">
    <img src="https://img.shields.io/github/license/LeonardoVS30/TikTokVideoMakerFinal?style=for-the-badge&logo=opensourceinitiative&logoColor=white&color=blue" alt="license">
    <img src="https://img.shields.io/github/last-commit/LeonardoVS30/TikTokVideoMakerFinal?style=for-the-badge&logo=git&logoColor=white&color=blue" alt="last-commit">
    <img src="https://img.shields.io/github/languages/top/LeonardoVS30/TikTokVideoMakerFinal?style=for-the-badge&color=blue" alt="repo-top-language">
    <img src="https://img.shields.io/github/languages/count/LeonardoVS30/TikTokVideoMakerFinal?style=for-the-badge&color=blue" alt="repo-language-count">
</p>
<p align="center"><!-- default option, no dependency badges. -->
</p>
<p align="center">
	<!-- default option, no dependency badges. -->
</p>
<br>

## 🔗 Table of Contents

- [📍 Overview](#-overview)
- [👾 Features](#-features)
- [📸 Screenshot](#-screenshot)
- [📁 Project Structure](#-project-structure)
  - [📂 Project Index](#-project-index)
- [🚀 Getting Started](#-getting-started)
  - [☑️ Prerequisites](#-prerequisites)
  - [⚙️ Installation](#-installation)
  - [🤖 Usage](#-usage)
- [📌 Project Roadmap](#-project-roadmap)
- [🔰 Contributing](#-contributing)
- [🎗 License](#-license)
- [🙌 Acknowledgments](#-acknowledgments)

---

## 📍 Overview

**TikTok Video Maker** es una herramienta de escritorio para Windows, desarrollada en C# con Windows Forms, diseñada para simplificar la creación de vídeos cortos en formato vertical. El programa permite a los usuarios construir una secuencia de video a partir de múltiples archivos GIF, añadir una banda sonora personalizada y exportar el resultado como un archivo MP4 con la resolución estándar de TikTok (1080x1920).

La aplicación actúa como una interfaz gráfica para el potente motor de video **FFmpeg**, utilizando la librería `FFMpegCore` para gestionar las operaciones de conversión y manipulación de medios de forma robusta y eficiente.

---

## 👾 Features

-   **Secuenciador de GIFs:** Añade múltiples GIFs a una lista para crear una secuencia de video.
-   **Gestión de Secuencia:** Reordena los GIFs (subir/bajar) o elimínalos de la lista.
-   **Control de Repeticiones:** Especifica cuántas veces debe repetirse cada GIF de forma individual.
-   **Audio Personalizado:** Selecciona cualquier archivo de audio (`.mp3`, `.wav`) como banda sonora.
-   **Duración Controlada:** Establece la duración exacta del vídeo final, ideal para crear "hooks" virales (ej. 7, 15, 30 segundos).
-   **Formato TikTok-Ready:** El vídeo se genera automáticamente en resolución 1080x1920 con padding negro para mantener la relación de aspecto de los GIFs.
-   **Interfaz Sencilla:** Un diseño de tema oscuro simple e intuitivo para facilitar el proceso de creación.

---

## 📸 Screenshot

![App Screenshot](https://github.com/LeonardoVS30/TikTokVideoMakerFinal/blob/6e88a102d1b5fa5e97dc36b4da7837694b6943cc/assets/screenshot.png)`

---

## 📁 Project Structure

```sh
└── TikTokVideoMakerFinal.git/
    ├── App.config
    ├── Form1.Designer.cs
    ├── Form1.cs
    ├── Form1.resx
    ├── Program.cs
    ├── Properties
    │   ├── AssemblyInfo.cs
    │   ├── Resources.Designer.cs
    │   ├── Resources.resx
    │   ├── Settings.Designer.cs
    │   └── Settings.settings
    ├── README.md
    ├── TikTokVideoMakerFinal.csproj
    ├── TikTokVideoMakerFinal.sln
    ├── ffmpeg.exe
    ├── ffplay.exe
    ├── ffprobe.exe
    └── packages.config
```


### 📂 Project Index
<details open>
	<summary><b><code>TikTokVideoMakerFinal/</code></b></summary>
	<details> <!-- __root__ Submodule -->
		<summary><b>__root__</b></summary>
		<blockquote>
			<table>
			<tr>
				<td><b><a href='https://github.com/LeonardoVS30/TikTokVideoMakerFinal/blob/master/TikTokVideoMakerFinal.csproj'>TikTokVideoMakerFinal.csproj</a></b></td>
				<td>Define la estructura y dependencias del proyecto para MSBuild.</td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/LeonardoVS30/TikTokVideoMakerFinal/blob/master/Form1.resx'>Form1.resx</a></b></td>
				<td>Archivo de recursos XML para el formulario principal (imágenes, strings, etc.).</td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/LeonardoVS30/TikTokVideoMakerFinal/blob/master/packages.config'>packages.config</a></b></td>
				<td>Define las dependencias de paquetes NuGet, como FFMpegCore.</td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/LeonardoVS30/TikTokVideoMakerFinal/blob/master/Form1.Designer.cs'>Form1.Designer.cs</a></b></td>
				<td>Código autogenerado por el diseñador de Windows Forms que inicializa los controles de la UI.</td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/LeonardoVS30/TikTokVideoMakerFinal/blob/master/App.config'>App.config</a></b></td>
				<td>Archivo de configuración de la aplicación .NET.</td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/LeonardoVS30/TikTokVideoMakerFinal/blob/master/Program.cs'>Program.cs</a></b></td>
				<td>Contiene el método <code>Main</code>, el punto de entrada principal de la aplicación.</td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/LeonardoVS30/TikTokVideoMakerFinal/blob/master/Form1.cs'>Form1.cs</a></b></td>
				<td>Contiene la lógica principal y los manejadores de eventos para la interfaz de usuario.</td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/LeonardoVS30/TikTokVideoMakerFinal/blob/master/TikTokVideoMakerFinal.sln'>TikTokVideoMakerFinal.sln</a></b></td>
				<td>Archivo de solución de Visual Studio que agrupa todos los proyectos.</td>
			</tr>
			</table>
		</blockquote>
	</details>
	<details> <!-- Properties Submodule -->
		<summary><b>Properties</b></summary>
		<blockquote>
			<table>
			<tr>
				<td><b><a href='https://github.com/LeonardoVS30/TikTokVideoMakerFinal/blob/master/Properties/AssemblyInfo.cs'>AssemblyInfo.cs</a></b></td>
				<td>Contiene metadatos del ensamblado como versión, copyright y título.</td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/LeonardoVS30/TikTokVideoMakerFinal/blob/master/Properties/Settings.Designer.cs'>Settings.Designer.cs</a></b></td>
				<td>Clase autogenerada para acceder a la configuración de la aplicación.</td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/LeonardoVS30/TikTokVideoMakerFinal/blob/master/Properties/Settings.settings'>Settings.settings</a></b></td>
				<td>Archivo XML para definir la configuración de la aplicación.</td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/LeonardoVS30/TikTokVideoMakerFinal/blob/master/Properties/Resources.resx'>Resources.resx</a></b></td>
				<td>Archivo de recursos por defecto de la aplicación.</td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/LeonardoVS30/TikTokVideoMakerFinal/blob/master/Properties/Resources.Designer.cs'>Resources.Designer.cs</a></b></td>
				<td>Clase autogenerada para un acceso tipado a los recursos.</td>
			</tr>
			</table>
		</blockquote>
	</details>
</details>

---
## 🚀 Getting Started

### ☑️ Prerequisites

Asegúrate de tener instalado el siguiente software en tu sistema:

-   **.NET Framework 4.7.2 o superior:** Necesario para ejecutar la aplicación. Normalmente ya viene incluido en las versiones modernas de Windows.
-   **Visual Studio 2022 (Opcional):** Necesario si deseas compilar el proyecto desde el código fuente. Asegúrate de tener la carga de trabajo ".NET desktop development" instalada.

### ⚙️ Installation

#### Para Usuarios

1.  Ve a la sección de **[Releases](https://github.com/LeonardoVS30/TikTokVideoMakerFinal/releases)** en este repositorio.
2.  Descarga el archivo `.zip` de la última versión.
3.  Descomprime el archivo en una carpeta de tu elección.
4.  Ejecuta `TikTokVideoMakerFinal.exe`.

#### Para Desarrolladores

1.  Clona el repositorio en tu máquina local:
    ```sh
    git clone https://github.com/LeonardoVS30/TikTokVideoMakerFinal.git
    ```
2.  Navega al directorio del proyecto:
    ```sh
    cd TikTokVideoMakerFinal
    ```
3.  Abre el archivo `TikTokVideoMakerFinal.sln` con Visual Studio 2022.
4.  Restaura las dependencias de NuGet (normalmente se hace automáticamente, si no, ve a `Compilar` > `Recompilar solución`).

### 🤖 Usage

1.  Inicia la aplicación.
2.  Haz clic en **"Añadir GIF"** para seleccionar uno o más GIFs.
3.  Organiza la secuencia usando los botones **"Subir"**, **"Bajar"** y **"Quitar"**.
4.  Selecciona un GIF de la lista y ajusta sus **repeticiones**.
5.  Haz clic en **"Seleccionar Audio..."** para elegir la banda sonora.
6.  Ajusta la **duración final** del video en segundos.
7.  Haz clic en **"GENERAR VIDEO"**.
8.  Espera a que termine el proceso. El vídeo resultante se guardará en tu Escritorio.

---
### 🧪 Testing
Run the test suite using the following command:
**Using `nuget`** &nbsp; [<img align="center" src="https://img.shields.io/badge/C%23-239120.svg?style={badge_style}&logo=c-sharp&logoColor=white" />](https://docs.microsoft.com/en-us/dotnet/csharp/)

---
## 📌 Project Roadmap
-   [X] **`Fundación`**: Implementar la lógica para combinar múltiples GIFs con repeticiones y audio en un video de duración fija.
-   [ ] **`Selección de Audio`**: Permitir al usuario seleccionar un fragmento específico del archivo de audio (ej. del segundo 30 al 45).
-   [ ] **`Superposición de Texto`**: Añadir la capacidad de poner un texto simple sobre el video.
-   [ ] **`Previsualización`**: Mostrar una previsualización aproximada de la secuencia de GIFs.

---

## 🔰 Contributing

Las contribuciones son lo que hace que la comunidad de código abierto sea un lugar increíble para aprender, inspirar y crear. Cualquier contribución que hagas será **muy apreciada**.

-   **💬 [Join the Discussions](https://github.com/LeonardoVS30/TikTokVideoMakerFinal/discussions)**: Comparte tus ideas, da tu opinión o haz preguntas.
-   **🐛 [Report Issues](https://github.com/LeonardoVS30/TikTokVideoMakerFinal/issues)**: Envía errores que encuentres o solicita nuevas características.
-   **💡 [Submit Pull Requests](https://github.com/LeonardoVS30/TikTokVideoMakerFinal/blob/main/CONTRIBUTING.md)**: Revisa los PRs abiertos y envía los tuyos.

<details closed>
<summary>Guía de Contribución</summary>

1.  **Haz un Fork** del repositorio.
2.  **Crea una nueva rama**: `git checkout -b feature/AmazingFeature`
3.  **Haz tus cambios**: Desarrolla y prueba tus cambios localmente.
4.  **Haz Commit** de tus cambios: `git commit -m 'Add some AmazingFeature'`
5.  **Haz Push** a tu rama: `git push origin feature/AmazingFeature`
6.  **Abre un Pull Request**.

</details>

<details closed>
<summary>Gráfico de Contribuidores</summary>
<br>
<p align="left">
   <a href="https://github.com/LeonardoVS30/TikTokVideoMakerFinal/graphs/contributors">
      <img src="https://contrib.rocks/image?repo=LeonardoVS30/TikTokVideoMakerFinal">
   </a>
</p>
</details>

---

## 🎗 License

This project is licensed under the [MIT License](https://github.com/LeonardoVS30/TikTokVideoMakerFinal/blob/master/LICENSE) - see the [LICENSE file](https://github.com/LeonardoVS30/TikTokVideoMakerFinal/blob/master/LICENSE) for details.

---

## 🙌 Acknowledgments

- List any resources, contributors, inspiration, etc. here.

---
