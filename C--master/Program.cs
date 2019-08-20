using System;

namespace EjercicioExamen2
{
    class Program
    {
        static void Main(string[] args)
        {

        int[] intArray = new int[]{1, 3, 6, 4, 1, 2};
        int sol=SolucionProblema(intArray);
        Console.Write(sol);
        }  
            public int SolucionProblema(int[] A) {
            int minValue = A[0];
        do {
            for (int i = 0; i < A.Length; i++) {
                if (A[i] < minValue) {
                    minValue = A[i];
                }
            }
        } while (contains(A, ++minValue) == true);
              return minValue;
    }
    public static bool contains(int[] arr, int item) {
        foreach (int n in arr) {
            if (item == n) {
                return true;
            }
        }
        return false;
    }
}
    }
