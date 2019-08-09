using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamSongEController : MonoBehaviour {

    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();
    }

    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, 2);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
