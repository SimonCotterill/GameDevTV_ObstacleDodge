using System.Runtime.CompilerServices;
using UnityEngine;

public class Spinner : MonoBehaviour
{

    [SerializeField] float xValue = 0f;
    [SerializeField] float yValue = 1f;
    [SerializeField] float zValue = 0f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(xValue, yValue, zValue);
    }
}
