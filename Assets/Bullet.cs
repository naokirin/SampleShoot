using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Mathf.Abs(transform.position.x) > 10 || Mathf.Abs(transform.position.y) > 10 || Mathf.Abs(transform.position.z) > 10) {
			Destroy(gameObject);
		}
	}
}
