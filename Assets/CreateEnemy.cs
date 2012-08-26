using UnityEngine;
using System.Collections;

public class CreateEnemy : MonoBehaviour {
	
	public Enemy enemyPrefab;
	public double nextCreation;
	public double creationRate;
	
	// Use this for initialization
	void Start () {
		Random.seed = Time.frameCount;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextCreation) {
			Enemy enemy = (Enemy)Instantiate (enemyPrefab, new Vector3 ((float)Random.Range (-10, 10), (float)0.0, (float)10.0), Quaternion.identity);
			nextCreation = Time.time + creationRate;
		}
	}
}
