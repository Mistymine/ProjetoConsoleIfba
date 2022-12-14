using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicCam : MonoBehaviour
{
   [Header("Camera")]
   public GameObject camera2;

   private void OnTriggerEnter(Collider other)
   {

    switch (other.gameObject.tag)
    {
        case "CamTrigger":
            camera2.SetActive(true);
            break;
    }
   }

   private void OnTriggerExit(Collider other)
   {
        switch(other.gameObject.tag)
        {
            case "CamTrigger":
                camera2.SetActive(false);
                break;
        }

   }


   

}
