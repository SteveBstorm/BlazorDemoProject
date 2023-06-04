1) Donner les différentes approches du Blazor (WASM, Server-side, Asp-Hosted)

--> Wasm => Produit un projet final sur base d'un index.html hébergeable sur n'importe quel serveur http (similaire Angular)

--> Server-side => Nécéssite un serveur .Net core, génère les pages coté serveur avant de les envoyés au navigateur (similaire php/asp)

--> ASP Hosted => Une api tourne sur le serveur et communique constament avec le client WASM via Websocket

---> Suggérer le WebAssembly pur dans un premier temps


2) Expliquer la structure du projet

--> Les différents dossiers et fichier importants (App.razor, index.html, Program.cs)

3) Passer dans le layout et le navMenu (repertoire Shared)

--> Explications rapide du routing 
    @page et <NavLink>

4) Commencer les démos 1, 2 et 3

5) Exercices Quizz

6) Démo 4, 5 et 6

7) Exercice Todo / Article / Autre...

    1 composant affichant une liste (label + click)

    1 composant (même page) formulaire d'entrée (avec validation)

    1 composant (même page) Détail mis à jour sur le click dans la liste

--> Demander de mettre en pratique les pricipes de Cycle de vie pour initialiser la liste, le formulaire et transmettre les données

