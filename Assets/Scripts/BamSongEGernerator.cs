using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamSongEGernerator : MonoBehaviour {

    public GameObject BamSongE_Prefab;

    private AudioSource adr;
	// Use this for initialization
	void Start () {
        adr = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            adr.Play();
            GameObject bse = Instantiate(BamSongE_Prefab) as GameObject;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;

            bse.GetComponent<BamSongEController>().Shoot(worldDir.normalized * 2000);
        }
	}
}
