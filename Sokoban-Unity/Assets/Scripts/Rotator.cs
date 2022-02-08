using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    [SerializeField] public Transform myTransform;

    // Start is called before the first frame update
    void Start()
    {
        myTransform.Rotate(60, 60, 60);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
