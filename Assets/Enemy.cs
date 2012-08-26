using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	
	private int initX, initZ;
	public float speed;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.back * speed * Time.deltaTime);
	}
}
