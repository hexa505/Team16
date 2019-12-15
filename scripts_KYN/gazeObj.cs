using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gazeObj : MonoBehaviour
{
    public GameObject Player;
    public GameObject Cube;
    private float Dist;

    public void gazeAtObj(GameObject pop)
    {
        float min = 5;
        //cubeDistance = Vector3.Distance(Player.transform.position, Cube.transform.position);
        //Debug.Log(cubeDistance);
        Dist = Vector3.Distance(Player.transform.position, Cube.transform.position);
        if (Dist < min)
        {

            pop.SetActive(true);

        }

    }
    /*
    private void CanPickUp()
    {
        pickupActivated = true;
      
    }
    */

    public void gazeNotObj(GameObject pop)
    {

        pop.SetActive(false);


    }

}
