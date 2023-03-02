using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hour7exercise3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Fibonacci Sequence Placements:\n");
		
		for (int k = 0; k < 20; k++)
		{
			print((k+1) + "th place: " + fib(k).ToString());
		}

        print("End of exercise 3!");
    }

    // Recursive fibonacci sequence calculator
    int fib(int n)
	{
		if (n <= 1)
			return n;
		return fib(n - 1) + fib(n - 2);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
