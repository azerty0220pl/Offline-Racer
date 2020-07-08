using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class Trigger : MonoBehaviour
{
    public GameObject player;
    public GameObject panel1;
    public GameObject panel2;
    public string playerName;
    public int scene;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == playerName)
        {
            player.GetComponent<NavMeshAgent>().enabled = true;
            player.GetComponent<AI>().enabled = true;
            player.GetComponent<Rigidbody>().velocity = Vector3.zero;
            panel2.SetActive(false);
            panel1.SetActive(true);
        }
    }

    public void SceneLoad()
    {
        SceneManager.LoadScene(scene);
    }
}
