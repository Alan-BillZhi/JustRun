using UnityEngine;
using System.Collections;

public class CreateObstacle : MonoBehaviour {

	public GameObject obstaclePrefab;

	private float currentTime = 0;
	private float interval = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		currentTime += Time.deltaTime;
		if(currentTime > interval){
			currentTime = 0;

			Instantiate(obstaclePrefab, new Vector3(7, -0.24f, 0), Quaternion.identity);

		}
	}
}
