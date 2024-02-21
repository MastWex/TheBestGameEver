using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Middle : MonoBehaviour
{
    public Transform PointA;
    public Transform PointB;
    public float K;
    void Start()
    {
        
    }

    void Update()
    {
        //        transform.position = (PointA.position + PointB.position) / 2;
        transform.position = Vector3.Lerp(PointA.position, PointB.position, K);
    }
}
