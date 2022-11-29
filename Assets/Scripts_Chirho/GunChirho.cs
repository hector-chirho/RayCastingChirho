using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunChirho : MonoBehaviour
{
    public float rangeChirho = 100f;
    public Camera fpsCameraChirho;
    public GameObject effectBloodChirho;
    public GameObject effectImpactChirho;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            DispararChirho();
        }
    }
    void DispararChirho()
    {
        RaycastHit hitChirho;
        if(Physics.Raycast(fpsCameraChirho.transform.position,fpsCameraChirho.transform.forward, out hitChirho, rangeChirho))
        {
            if(hitChirho.transform.CompareTag("EnemyChirho"))
            {
                GameObject bloodChirho = Instantiate(effectBloodChirho, hitChirho.point,Quaternion.LookRotation(hitChirho.normal));
                Destroy(bloodChirho,0.5f);
            }
            if(hitChirho.transform.CompareTag("ConcretoChirho"))
            {
                GameObject impactChirho = Instantiate(effectImpactChirho, hitChirho.point,Quaternion.LookRotation(hitChirho.normal));
                Destroy(impactChirho,0.5f);
            }
        }
    }
}
