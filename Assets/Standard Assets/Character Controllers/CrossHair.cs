using UnityEngine;
using System.Collections;

public class CrossHair : MonoBehaviour {

	private Rect position;
	public Texture2D texture;

	// Use this for initialization
	void Start () {
		position = new Rect ((Screen.width - texture.width) / 2, (Screen.height - texture.height) / 2, texture.width, texture.height);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		GUI.DrawTexture (position, texture);
	}
}
