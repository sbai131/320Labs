using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sketch : MonoBehaviour {

	public GameObject myPrefab;
	

	void Start () {
		
		int totalCubes = 30;
		
		float totalDistance = 2.9f;
		
		for ( int i = 0; i < totalCubes; i++ )
		{
		float perc = i / (float)totalCubes;
		float sin = Mathf.Sin(perc * Mathf.PI/2);
			
		//float x = 1.8f + sin * totalDistance;
		//float y = 5.0f;
		//float z = 0.0f;
		float x = (Random.value-Random.value) * 4;
		float y = (Random.value-Random.value) * 4 + 5;
		float z = (Random.value-Random.value) * 4;
		var newCube = (GameObject)Instantiate(myPrefab, new Vector3(x,y,z), Quaternion.identity);
		newCube.GetComponent<CubeScript>().SetSize(0.45f * (1.0f - perc));
		newCube.GetComponent<CubeScript>().rotateSpeed = .2f + perc * 4.0f;
		
		}
	}
	

	void Update () {
		
	}
}
