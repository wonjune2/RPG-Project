using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform target;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = target.position;
    }
}
