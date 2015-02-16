using UnityEngine;
using System.Collections;

public class Bullet : TempObject {
    public float speed;
    public GameObject exploPrefab;

	// Use this for initialization
	void Start () {
	
	}                                   
	
	// Update is called once per frame
	void Update () {
        float delta = Time.deltaTime;
        transform.Translate(Vector3.forward * speed * delta);
	}

    void OnCollisionEnter(Collision coll)
    {
        Instantiate(exploPrefab, this.transform.position, this.transform.rotation);

        Destroy(this.gameObject);
    }
}
