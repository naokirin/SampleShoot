using UnityEngine;
using System.Collections;

public class MyShip : MonoBehaviour {
	public Bullet bulletPrefab;
	public float bulletSpeed;
	public double fireRate;
	public double nextFire;
	public float speed;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Fire1") && Time.time > nextFire) {
			Bullet bullet = (Bullet)Instantiate(bulletPrefab, transform.position, Quaternion.identity);
			Vector3 bulletVelocity = transform.forward  * bulletSpeed;
			bullet.rigidbody.velocity = bulletVelocity;
			nextFire = Time.time + fireRate;
		}
		float axisHorizontal = Input.GetAxis("Horizontal");
		float axisVertical = Input.GetAxis ("Vertical");
        transform.Translate(Vector3.right * axisHorizontal * speed * Time.deltaTime + Vector3.forward * axisVertical * speed * Time.deltaTime);
		/*float maxSpeed = 1;
		float currentSpeed = GetComponent<CharacterController>().velocity.x;
		transform.localRotation.eulerAngles.Set(
			transform.localRotation.eulerAngles.x,
			transform.localRotation.eulerAngles.y,
			-45  * currentSpeed / maxSpeed);*/
	}
}
