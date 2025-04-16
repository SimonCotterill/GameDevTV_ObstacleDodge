using System.Diagnostics;
using UnityEngine;

public class DroppingTimer : MonoBehaviour
{
    [SerializeField] float timeToWait = 3f;

    MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;

    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myMeshRenderer.enabled = false;

        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.useGravity = false;
    }

    void Update()
    {
        if(Time.time > timeToWait)
        {
            //UnityEngine.Debug.Log("Time since starting is: " + Time.time);

            myMeshRenderer.enabled = true;
            myRigidbody.useGravity = true;
        }
        
    }

}
