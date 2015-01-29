using UnityEngine;
using System.Collections;

public class Clicking : MonoBehaviour {
	public Rigidbody platform;
	public float range = 1000f;

	private bool fire = false;
	private Vector3 centre;


	// Use this for initialization
	void Start () {
		centre = new Vector3 (Screen.width / 2, Screen.height / 2);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			fire = true;
		}
	}

	void FixedUpdate() {
		if (fire) {
			fire = false;
			RaycastHit raycastHit;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(centre), out raycastHit)) {
				if (raycastHit.transform.gameObject.layer == LayerMask.NameToLayer("moldable")) {
					Debug.Log(platform.renderer.bounds.size.z);
					Rigidbody tempPlatform = (Rigidbody)Instantiate(platform, raycastHit.point - raycastHit.normal * (platform.renderer.bounds.size.z / 2), Quaternion.LookRotation(raycastHit.normal, Vector3.up));
				}
			}
		}
	}
}
