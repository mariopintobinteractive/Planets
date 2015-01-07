using UnityEngine;
using System.Collections;

public class PlanetRotation : MonoBehaviour {
	Vector3 rotation = new Vector3(0,0.2f,0);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate(rotation);
	}
}
