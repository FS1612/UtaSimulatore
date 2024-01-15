using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ventola : MonoBehaviour
{
    [SerializeField] private Vector3 rotationVector;
    [SerializeField] private Transform firstBlind;
    [SerializeField] private float rotationTime;
    [SerializeField] private float maxAngle;
    private float rotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotation = maxAngle / rotationTime;
        firstBlind.Rotate(rotationVector, Mathf.Round(rotation));

    }
}
