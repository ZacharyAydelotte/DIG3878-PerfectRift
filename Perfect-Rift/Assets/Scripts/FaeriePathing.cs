using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FaeriePathing : MonoBehaviour
{
    public NavMeshAgent faerie;
    public GameObject destination, faerieDust;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            faerieDust.SetActive(true);
            faerie.SetDestination(destination.GetComponent<Transform>().position);
        }

        if (faerieDust.transform.position == destination.transform.position)
        {
            Destroy(faerie);
        }
    }
}
