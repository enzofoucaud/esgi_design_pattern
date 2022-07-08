Le pattern Bridge est utilisé pour séparer le comportement de l'implémentation de l'interface et de l'objet.

On s'intéresse à la demande d'immatriculation de la voiture.
Le formulaire de demande de immatriculation possède deux implémentations différentes:

FormulaireImmat

FormulaireImmatHTML
FormulaireImmatAPP

Au départ le système est concu pour la France uniquement
Cependant on veut créer une sous classe pour la Suisse FormulaireImmatCH
Elle aussi abstraite pour avoir les deux implémentations
