using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMovement : MonoBehaviour
{
    public GameObject Head;
    public GameObject cam;
    public GameObject SpaceShip;

    float CurrRot; //현재 회전값
    float PrevRot; //과거 회전값
    float DeltRot; //회전값 차

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Head.transform.Translate(cam.transform.forward * Time.deltaTime * 6.5f);
        tile();


    }

    void tile()
    {
        CurrRot = cam.transform.eulerAngles.y;
        DeltRot = CurrRot - PrevRot;
        PrevRot = CurrRot;

        if (DeltRot > 0)
        {
            SpaceShip.transform.localRotation = 
                Quaternion.Lerp(SpaceShip.transform.localRotation, 
                Quaternion.Euler(SpaceShip.transform.localRotation.x, SpaceShip.transform.localRotation.y, -45), Time.deltaTime);
        }
        else if (DeltRot < 0)
        {
            SpaceShip.transform.localRotation =
                Quaternion.Lerp(SpaceShip.transform.localRotation,
                Quaternion.Euler(SpaceShip.transform.localRotation.x, SpaceShip.transform.localRotation.y, 45), Time.deltaTime);
        }
        else
        {
            SpaceShip.transform.localRotation =
                Quaternion.Lerp(SpaceShip.transform.localRotation,
                Quaternion.Euler(SpaceShip.transform.localRotation.x, SpaceShip.transform.localRotation.y, 0), Time.deltaTime * 1.5f);
        }
    
      
    }
}
