## On Mac:

Run command: `dotnet run`

## Fonctionnement

En lançant l'application, vous avez fait le demande pour une nouvelle carte.

Vous avez le choix entre 2 actions sur le prompt:

- Selon l'état de la carte, vous pouvez l'activé ou la désactivé (Tapez 1)
- Voir l'historique des états de la carte (Tapez 2)

## Explication

Program.cs: l'entrée de l'application.

CarteBancaire.cs: Classe d'une Carte Bancaire.

Parcours.cs: Gestion des différents flux d'actions. (ex: activer ou désactiver la CB).

EtatHistorique.cs: Gestion de l'historique.
