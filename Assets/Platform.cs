using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour {

	public float speed;
	public float time;
	private float t;

	// Use this for initialization
	void Start () {;
		t = Time.time;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - t < time) {
			transform.position += transform.forward * (speed * Time.deltaTime);
		}
	}

}
