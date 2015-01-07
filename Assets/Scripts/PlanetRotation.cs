using UnityEngine;
using System.Collections;

public class PlanetRotation : MonoBehaviour {
	Vector3 rotation = new Vector3(0,1,0);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate(rotation);
	}
}
