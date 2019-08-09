using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnergyGageScript : MonoBehaviour {

    private Image EnergyGage_bar;
    private Image GameOver;
    private bool IsOver = false;
    // Use this for initialization
    void Start()
    {
        GameOver = GameObject.Find("GameOver").GetComponent<Image>();
        EnergyGage_bar = GetComponent<Image>();
    }

    public void HaveDamage(float range)
    {
        EnergyGage_bar.fillAmount -= range;
        if (EnergyGage_bar.fillAmount <= 0) IsOver = true;
    }

    void Update()
    {
        if (IsOver) GameOver.fillAmount += Time.deltaTime;
        if (IsOver && GameOver.fillAmount >= 1f) SceneManager.LoadScene("OverScene");
    }
}