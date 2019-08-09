using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Generator : MonoBehaviour {

    public GameObject enemy_object;
    public float AppearanceTime = 2;

    private float AppearanceTime_frame = 0;	
	// Update is called once per frame
	void Update () {
		if ((AppearanceTime_frame += Time.deltaTime) >= AppearanceTime)
        {
            transform.position = new Vector3(Random.Range(-45, 46), 0, 25f);
            GameObject NewObject = Instantiate(enemy_object, transform) as GameObject;
            NewObject.transform.parent = null;

            AppearanceTime_frame = 0;
            if (AppearanceTime > 0.3f) AppearanceTime -= 0.1f;
        }
	}
}
