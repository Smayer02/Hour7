using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hour7exercise1 : MonoBehaviour
{
    int sum = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 2; i <= 499; i += 2)
		{
			sum += i;
		}
		print("Sum of the even numbers between 2 and 499: " + sum.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
