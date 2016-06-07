using UnityEngine;
using System.Collections;
namespace Leap.Unity.PinchUtility
{
    public class Movemanager : MonoBehaviour
    {
        public GameObject left,right;
        public GameObject RTS;
        bool state = false;
        private LeapRTS manager;
        // Use this for initialization
        void Start()
        {
            manager =RTS.GetComponent<LeapRTS>();
        }

        // Update is called once per frame
        void Update()
        {

        }
        void OnTriggerEnter(Collider other)
        {
            Debug.Log("Touching the box");
            if (other.gameObject == left || other.gameObject == right)
            {
                manager.enabled = state;
                state = !state;
            }


        }
    }
}
