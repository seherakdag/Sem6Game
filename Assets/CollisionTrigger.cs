using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTrigger : MonoBehaviour
{

        public GameObject ClosedDoor;
        public GameObject trigger;
        public float smooth;

        void Start()
        {

            trigger = GameObject.Find("trigger");
            ClosedDoor = GameObject.Find("ClosedDoor");
            ClosedDoor.SetActive(true);
        }

        void OnTriggerEnter(Collider Crowbar)
        {

            if (Crowbar.tag == "Crowbar")
                ClosedDoor.SetActive(false);
            Debug.Log("button activated");
        }
    }
