using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    public GameObject[] destination;
    public int number;
    public float time2;

    private void Start()
    {
        GetComponent<NavMeshAgent>().SetDestination(destination[number].transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, destination[number].transform.position) < 3f && time2 > 3f)
        {
            number++;
            if (number >= destination.Length)
                number = 0;

            GetComponent<NavMeshAgent>().SetDestination(destination[number].transform.position);
            time2 = 0;
        }

        time2 = Time.deltaTime + time2;
    }
}
