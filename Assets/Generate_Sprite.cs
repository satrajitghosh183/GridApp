using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate_Sprite : MonoBehaviour
{   


     public GameObject prefab;
   
 void Update()
     {
         if (Input.GetMouseButtonDown(0))
         {
             Debug.Log("Left mouse clicked");
             RaycastHit hit;
             Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
 
             if (Physics.Raycast(ray, out hit))
             {
                 if (hit.transform.name == "floor")
                 {
                     Instantiate(prefab, hit.point, Quaternion.identity);
                     print("My object is clicked by mouse");
                 }
             }
         }
     }


}
