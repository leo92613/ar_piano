using UnityEngine;
using System.Collections;
using Leap;

public class Backtomenu : MonoBehaviour
{
    public GameObject left, right;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Touching the box");
        if (other.gameObject == left || other.gameObject == right)
            Application.LoadLevel("Welcome page");

    }
    void Update()
    {

    }
}