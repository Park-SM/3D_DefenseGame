using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour {

    private KillScript KillScript;
    private EnergyGageScript EnergyGage;
    private NavMeshAgent nav;
    private GameObject player;
    // Use this for initialization
    void Start () {
        KillScript = GameObject.Find("KillLog").GetComponent<KillScript>();
        EnergyGage = GameObject.Find("EnergyGage_e").GetComponent<EnergyGageScript>();
        player = GameObject.Find("Player");
        nav = GetComponent<NavMeshAgent>();
    }

    void OnTriggerEnter(Collider other)
    {
       if (other.tag == "Bullet")
        {
            KillScript.Kill();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

       if (other.tag == "castle")
        {
            EnergyGage.HaveDamage(0.1f);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
        if (nav.destination != player.transform.position) nav.SetDestination(player.transform.position);
        else nav.SetDestination(transform.position);
    }
}
