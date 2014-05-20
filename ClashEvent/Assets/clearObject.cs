using UnityEngine;
using System.Collections;

public class clearObject : MonoBehaviour {
	int counter = 0;
	GameObject obj = null;

	void Start () {
		GameObject.Find("GUI Text").guiText.text = "Collision Event Sample";
	}
	
	void Update () {
		GameObject cube = GameObject.Find("Cube");
		if (obj != null) {
			if (counter++ > 100) {
				obj.SetActive(true);
				obj = null;
			}
		}
		try {
			cube.transform.Rotate(1f, -1f, -1f);
		} catch(System.NullReferenceException e){}

		if (Input.GetKey(KeyCode.LeftArrow )) {
			rigidbody.AddForce (new Vector3(-1f, 0,  1f));
		}
		if (Input.GetKey(KeyCode.RightArrow)) {
			rigidbody.AddForce (new Vector3( 1f, 0, -1f));
		}
		if (Input.GetKey(KeyCode.UpArrow   )) {
			rigidbody.AddForce (new Vector3( 1f, 0,  1f));
		}
		if (Input.GetKey(KeyCode.DownArrow )) {
			rigidbody.AddForce (new Vector3(-1f, 0, -1f));
		}
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "Player") {
			if (obj != null) {
				obj.SetActive(true);
			}
			collision.gameObject.SetActive(false);
			obj = collision.gameObject;
			counter = 0;
		}
	}
}
