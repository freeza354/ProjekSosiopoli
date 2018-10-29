using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointData : MonoBehaviour {

    public static int[] pointBenar = new int[37];
    public static int[] pointSalah = new int[37];

	// Use this for initialization
	void Start () {
        for (int i = 0; i < 37; i++)
        {
            if (i == 6 || i == 12 || i == 12 || i == 30)
            {
                pointBenar[i] = 15;
                pointSalah[i] = 5;
            }
            else
            {
                pointBenar[i] = 0;
                pointSalah[i] = 0;
            }

        }
    }
	
	// Update is called once per frame
	void Update () {


    }
}
