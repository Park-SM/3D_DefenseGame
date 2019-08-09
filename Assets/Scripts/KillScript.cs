using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillScript : MonoBehaviour {

    private AudioSource adr;
    private Text KillText;
    private int KillCount = 0;
	// Use this for initialization
	void Start () {
        adr = GetComponent<AudioSource>();
        KillText = GetComponent<Text>();
        KillText.text = "KILL: " + KillCount;
	}
	
    public void Kill()
    {
        adr.Play();
        KillCount++;
        KillText.text = "KILL: " + KillCount;
    }
}
