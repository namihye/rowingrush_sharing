using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    public GameObject _Boat;
    float BoatDistance;
    Vector3 FirstDistance = new Vector3(0,0,0);

    public void FixedUpdate(){
        BoatDistance = Vector3.Distance(FirstDistance, _Boat.transform.position);
        //Debug.Log(BoatDistance);
        
    }

    void LateUpdate(){
        if (BoatDistance>100){
            _Boat.GetComponent<BoatController>().enabled = false;
            
        }
        
    }
}
