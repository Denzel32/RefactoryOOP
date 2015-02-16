using UnityEngine;
using System.Collections;

public class EnemieShoot : MonoBehaviour {

	//private float reloadTime;
	//public float timeReload;
	public GameObject bulletPrefab;
	public  float shootRange;
	private Transform Turret;
	private Transform Nozzle;


	// Use this for initialization
	void Start () {
		//reloadTime = 0;

		Transform[] transforms = this.gameObject.GetComponentsInChildren<Transform> ();
		foreach (Transform t in transforms) {
		if(t.gameObject.name == "Turret")
			{
				Turret = t;
			}
		if(t.gameObject.name == "Nozzle")
			{
				Nozzle = t;
			}

		}
	}
}
