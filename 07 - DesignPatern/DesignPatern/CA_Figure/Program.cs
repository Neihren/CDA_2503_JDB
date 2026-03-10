using CA_Figure;
using CL_Figure;

IVisiteurDeForme visiteur = new VisiteurConsolePourForme();
Cercle c1 = new(10, 8, 6);
Cercle c2 = new(4, 9, 2);
Rectangle r1 = new(10, 5, 12, 4);
Rectangle r2 = new(48, 12, 2, 16);
Formes f1 = new(10, 11);
f1.AjouterForme(c1);
f1.AjouterForme(c2);
f1.AjouterForme(r1);
f1.AjouterForme(r2);

f1.Accept(visiteur);