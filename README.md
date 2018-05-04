# Cours de C#

## Création de la structure

`mkdir Isen.Cs && cd Isen.Cs`  
`dotnet new sln`  
Création du projet de type console :  
`mkdir Isen.Cs.ConsoleApp && cd Isen.Cs.ConsoleApp`  
`dotnet new console`  
Création du projet de type librairie:  
`mkdir Isen.Cs.Library && cd Isen.Cs.Library`  
`dotnet new classlib` 
Création du projet de type test unitaires (depuis la racine) :  
`mkdir Isen.Cs.Tests && cd Isen.Cs.Tests`  
`dotnet new xunit`  
### Référencement des projets
Ajouter au projet console une référence vers le projet Library  
Depuis le dossier du projet console:  
`dotnet add reference ..\Isen.Cs.Library\Isen.Cs.Library.csproj`  

Ajouter au projet Test une référence vers le projet Library  
Depuis le dossier du projet Test:  
`dotnet add reference ..\Isen.Cs.Library\Isen.Cs.Library.csproj`  
Pour retirer la référence, remplacer `add` par `remove`  

### Indiquer au sln la présence des 3 projets  
Depuis la racine de la solution:
`dotnet sln add Isen.Cs.Library\Isen.Cs.Library.csproj`  
`dotnet sln add Isen.Cs.ConsoleApp\Isen.Cs.ConsoleApp.csproj`  
`dotnet sln add Isen.Cs.Tests\Isen.Cs.Tests.csproj`  

### Parenthèse spécifique à Visual Studio (et pas visual studio code)
On peut créer des "dossiers de solution", qui sont des dossiers virtuels  
(non reflétés dans le filesytem)  
Rangements proposé :
- `src` pour les projets library et console  
- `tests`pour les projets de tests  
- `sln`pour tous les fichiers hors porjets à la racine de la solution  

### Ménage
Effacer les fichiers .cs générés automatiquement, à  
l'exception de celui du projet Console.

### Build pour vérifier 
Il y a 3 étapes, qui s'appellent entre elles, lors d'un build:  
* `dotnet restore` : restaurer les packages "NuGet" distants (mécanisme équivalent à `npm`).
* `dotnet build` : compiler les projets
* `dotnet run` : éxécuter le projet, s'il est exécutable:
    * Exécuter dans la console, pour un projet console
    * Lancer un serveur web, pour un projet web.

### Initial commit
Créer un projet sur Github ou Gitlab.  
Depuis la racine du projet :  
`git init`  
Trouver un .gitignore pour un projet .net Core :  
lien...  
Créer un fichier .gitignore:  
`touch .gitignore`  
Remplir ce fichier avec le contenu exemple.  
`git add .`  
`git commit -m "initial commit, project structure"`  
`git remote add origin https://github.com/mistermania/ISEN-CS.git `  
`git push origin master`  
Ajouter un tag de version 0.1  
`git tag v0.1` 
`git push origin v0.1`  

## Ajout d'exercices 'Hors Projet'
Dans le projet Library: 
* Creer un dossier Lessons
* Creer une classe 01_Types (fichier 01_Types.cs)  

Inclure toute la structure d'une classe :   
* `using` (imports du java)
* `namespace` (package du java)
* `class` 

Coder la classe (voir code).
L'appeler dans le main().

### B_Enumerations
Ce chapitre passe en revue les `enum`.  
Dans le projet Library, créer cette classe.  

### C_Arrays
Aperçu des passages par valeur ou référence.  
Ce chapitre traite des tableaux "primitifs" du style `object[]` ou `object[][]`.  
Créer la classe C_Arrays avec une méthode d'éxécution et l'appeler dans le main.