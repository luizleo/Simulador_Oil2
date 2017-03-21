using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilStainPositionController : MonoBehaviour {


	public Vector3 currentPos;



	// Use this for initialization
	void Start () {
		currentPos = gameObject.transform.position;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//just checks for now if its position changes(TODO: make this optimized, this is too impractical)

		if (currentPos != gameObject.transform.position)
		{
			//moved
			//Debug.Log(gameObject.name + " changed position");
			OilStainManager.instance.StainChangedPosition (gameObject);
			currentPos = gameObject.transform.position;
		}



		//Debug.Log (gameObject.name + " position is " + gameObject.transform.position.x + " " + gameObject.transform.position.y + " " + gameObject.transform.position.z);
	}
}
