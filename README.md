---
## Link to HTML Converter
## Overview
The Link to HTML Converter is a Windows Forms application that reads a specially formatted text file (exporttab.txt) from the desktop, parses the links,
and generates an HTML file (links.html) containing a list of clickable links. The generated HTML file is saved to the desktop and automatically opened in the default web browser.

## Features
* Parses links from a text file in Markdown-style format:
```
[Title](URL).
```
* Generates an HTML file with a customizable title and a styled list of links.
* Automatically opens the generated HTML file in the default browser.
* Provides user-friendly error messages for missing or invalid input files.
 
## Requirements
* .NET 9
* Windows operating system

## Installation
1. Clone or download the repository.
2. Open the solution in Visual Studio 2022.
3. Build the project to ensure all dependencies are restored.

## Usage
1. Create a text file named exporttab.txt on your desktop. The file should contain links in the following format:
 ```
   [Google](https://www.google.com)
   [GitHub](https://github.com)
```
2. Run the application.
3. Enter a title for the HTML page in the provided text box.
4. Click the "Generate" button.
5. The application will:
   * Parse the links from exporttab.txt.
   * Generate an HTML file named links.html on your desktop.
   * Open the HTML file in your default browser.

## Error Handling
* If exporttab.txt is not found on the desktop, the application will display an error message.
* If no valid links are found in the file, the application will notify the user.
---
