# Link to HTML Converter

## Overview
The Link to HTML Converter is a Windows Forms application that reads a specially formatted text file exporttab.txt from the desktop, parses the links,
and generates an HTML file links.html containing a list of clickable links. The generated HTML file is saved to the desktop and automatically opened in the default web browser.
I created this program for 2 reasons; to play with C# applications, and I have the bad habit of building too many browser tabs that I end up keeping open and wasting resources.
This program is to help me clean that up, and make one or perhaps more link files that I can use instead and group.  This will be an evolving simple thing for me to play with

## Future Features that I am thinking of...
* none at the moment, but I suspect there will be many code updates as I play with this

## Features
* Parses links from a text file in Markdown-style format [Title](URL).
* Generates an HTML file with a customizable title and a styled list of links.
* Automatically opens the generated HTML file in the default browser.
* Provides user-friendly error messages for missing or invalid input files.

## Requirements
* Designed to work with the output of the Export Tab URLs extension
  * https://microsoftedge.microsoft.com/addons/detail/export-tab-urls/onpflfgcgdbgglmcblipdjedomnpobpj

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
