using UnityEngine;
using System.Collections;

public class ArrayTest : MonoBehaviour {
		
	// Use this for initialization
	void Start () {
	
		int z = 56;
		int[] array1 = {0, 1, 2, 3, 4, 5, z};
		int x = 0;
	
		do
		{
		    Debug.Log(array1[x].ToString());
		    x++;
		} 
		while(x < 7);
		
		// An array of strings
		string[] array2 = {"hello", "world"};
		int y = 0;
		
		while (y < 2)
		{
		    Debug.Log(array2[y]);
		    y++;
		}

		
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
