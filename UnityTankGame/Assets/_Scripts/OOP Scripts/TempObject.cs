using UnityEngine;
using System.Collections;

public class TempObject : MonoBehaviour {
    public float maxLife;
	private float lifeTime;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    lifeTime += Time.deltaTime;
		if (lifeTime > maxLife)
		{
			Destroy (this.gameObject);
		}
	}
	
}
