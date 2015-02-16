using UnityEngine;
using System.Collections;

public class Enemy : Tank {
	public  float shootRange;
	private Transform Turret;
	private Transform Nozzle;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void determineTarget()
	{

	}

	void checkIfSeesPlayer()
	{
		Ray myRay = new Ray ();
		myRay.origin = Turret.position;
		myRay.direction = Turret.forward;
		
		RaycastHit hitInfo;
		
		if(Physics.Raycast(myRay, out hitInfo,shootRange))
		{
			
			string hitObjectName = hitInfo.collider.gameObject.name;
			
			if(hitObjectName == "TankPlayer")
				{
					Instantiate(bulletPrefab,Nozzle.position,Nozzle.rotation);
					reloadTimer();
					
				}
		}
	}
}
