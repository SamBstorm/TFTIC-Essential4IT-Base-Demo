const int TAILLE_X = 3;
const int TAILLE_Y = 3;

string[,] grille = new string[TAILLE_X, TAILLE_Y];

for (int i = 0; i < TAILLE_X; i++)
{
	for (int j = 0; j < TAILLE_Y; j++)
	{
		grille[i, j] = "X";
	}
}

grille[1, 1] = "O";

for (int i = 0; i < TAILLE_X; i++)
{
    for (int j = 0; j < TAILLE_Y; j++)
    {
        Console.Write(grille[i, j]);
    }
    Console.WriteLine();
}