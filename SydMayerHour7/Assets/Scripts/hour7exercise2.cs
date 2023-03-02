using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hour7exercise2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Start of exercise 2!");
        for (int j = 1; j <= 100; j++)
		{
			if (j % 3 == 0 || j % 5 == 0)
            {
                print("Programming is awesome");
            }
			else {
                print(j.ToString());
            }
		}
        print("End of exercise 2!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
