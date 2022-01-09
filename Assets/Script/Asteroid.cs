using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour //소행성이 행할 수 있는 것들
{
    public GameObject PaticleObj;

    private void OnTriggerEnter(Collider other)
    {
        PaticleObj.SetActive(true);
        transform.GetComponent<MeshRenderer>().enabled = false;
        Invoke("DestObj", 3);
    }

    void DestObj()
    {
        Destroy(this.gameObject);
    }
}
