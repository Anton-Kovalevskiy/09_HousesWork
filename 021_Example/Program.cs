/*Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

// Решение задачи №21

int[] coordsX = new int[2];
int[] coordsY = new int[2];
int[] coordsZ = new int[2];
for (int i = 0; i < 2; i++)
{
    Console.Write($"Введите координату {i+1}-й точки X{i+1} -> ");
    coordsX[i] = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите координату {i+1}-й точки Y{i+1} -> ");
    coordsY[i] = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите координату {i+1}-й точки Z{i+1} -> ");
    coordsZ[i] = Convert.ToInt32(Console.ReadLine());
}
double length = Math.Sqrt(Math.Pow(coordsX[0]-coordsX[1], 2) + Math.Pow(coordsY[0]-coordsY[1], 2) + Math.Pow(coordsZ[0]-coordsZ[1], 2));
Console.Write($"Расстояние между двумя введенными точками {Math.Round(length, 2)}");