using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

using Debug = UnityEngine.Debug;

public class Mover : MonoBehaviour
{
    [SerializeField] float movementSpeed = 0.50f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }


    void PrintInstructions()
    {
        Debug.Log("welcome");
        Debug.Log("move with arrow keys");
        Debug.Log("avoid stuff");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
        float yValue = 0.00f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;

        transform.Translate(xValue, yValue, zValue);
    }
}
