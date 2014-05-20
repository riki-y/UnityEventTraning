using UnityEngine;
using System.Collections;

public class tagObjectClassification : MonoBehaviour {

	void Start () {
		GameObject.Find("GUI Text").guiText.text = "Collision Event sample";
	}
	
	void Update () {
		GameObject cube = GameObject.Find("Cube");
		cube.transform.Rotate(1f, -1f, -1f);
		if (Input.GetKey(KeyCode.LeftArrow )) {
			rigidbody.AddForce(new Vector3(-1f, 0,  1f));
		}
		if (Input.GetKey(KeyCode.RightArrow)) {
			rigidbody.AddForce(new Vector3( 1f, 0, -1f));
		}
		if (Input.GetKey(KeyCode.UpArrow   )) {
			rigidbody.AddForce(new Vector3( 1f, 0,  1f));
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			rigidbody.AddForce(new Vector3(-1f, 0, -1f));
		}
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "Player") {
			collision.gameObject.renderer.material.color = Color.yellow;
		}
	}
}
