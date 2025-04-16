using System;
using System.Diagnostics;
using UnityEngine;

using Debug = UnityEngine.Debug;

public class ObstacleHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit";
            Debug.Log("something hit me");
        }
        
    }
}
