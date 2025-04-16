using System.Diagnostics;
using UnityEngine;

using Debug = UnityEngine.Debug;


public class Scorer : MonoBehaviour
{

    public int hits = 0;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            hits++;
            Debug.Log("You've bumped into something new this many times: " + hits);
        }       
        
    }
}
