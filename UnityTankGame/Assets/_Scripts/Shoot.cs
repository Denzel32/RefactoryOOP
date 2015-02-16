using UnityEngine;
using System.Collections;

public class Shoot : Tank {

	public GameObject bulletPrefab;
	private GameObject Turret;
	private GameObject Nozzle;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
		{
			Quaternion rotation = Quaternion.Euler(Vector3.up * Turret.transform.rotation.eulerAngles.y);
			Instantiate(bulletPrefab, Nozzle.transform.position, rotation);
		}
	}
}