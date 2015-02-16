using UnityEngine;
using System.Collections;

public class Tank : DestructableObject {
	private float reloadTime;
	public float timeReload;
	public GameObject bulletPrefab;
    private Transform Turret;
    private Transform Nozzle;


	// Use this for initialization
	void Start () {
		reloadTime = 0;
        Transform[] transforms = GetComponentsInChildren<Transform>();
        foreach (Transform t in transforms)
        {
            if (t.gameObject.name == "Turret")
            {
                Turret = t.gameObject;
            }
            if (t.gameObject.name == "Nozzle")
            {
                Nozzle = t.gameObject;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void findNozzelTurret()
	{

	}

	void aimTurret ()
	{

	}

	protected void reloadTimer ()
	{
		reloadTime += Time.deltaTime;
		if (reloadTime >= timeReload)
		{
			reloadTime = 0;
		}
	}

	void fireBullet() 
	{
		
	}


}
