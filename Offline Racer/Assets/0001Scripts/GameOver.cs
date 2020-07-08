using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "dead")
        {
            panel1.SetActive(true);
            panel2.SetActive(false);
        }
    }
}
