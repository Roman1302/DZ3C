/* Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
формула D=sqrt((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2) */

Console.WriteLine("Программа вычисления растояние между двух точек в 3D пространстве");
Console.WriteLine("Введите координаты ПЕРВОЙ точки через пробел (x1 y1 z1): ");
string[] nums1Strings = Console.ReadLine().Split();
int[] nums1 = new int[nums1Strings.Length];
for(int i1 = 0; i1 < nums1Strings.Length; i1++)
    nums1[i1] = Convert.ToInt32(nums1Strings[i1]);
int x1 = nums1[0];
int y1 = nums1[1];
int z1 = nums1[2];

Console.WriteLine("Введите координаты ВТОРОЙ точки через пробел (x2 y2 z2): ");
string[] nums2Strings = Console.ReadLine().Split();
int[] nums2 = new int[nums2Strings.Length];
for(int i2 = 0; i2 < nums2Strings.Length; i2++)
    nums2[i2] = Convert.ToInt32(nums2Strings[i2]);
int x2 = nums2[0];
int y2 = nums2[1];
int z2 = nums2[2];
     
     double d = Math.Pow((Math.Pow(x2 - x1, 2) +
                         Math.Pow(y2 - y1, 2) +
                         Math.Pow(z2 - z1, 2) *
                                   1.0), 0.5);
    Console.WriteLine("\n" + d.ToString("N2"));
