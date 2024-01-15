using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Tapparelle : MonoBehaviour
{
    
    [SerializeField] private float maxAngle;
    [SerializeField] private Vector3 rotationVector;
    [SerializeField] private string nome;
    [SerializeField] private string descrizione;
    [SerializeField] private string costruttore;
    [SerializeField] private string marca;
    [SerializeField] private string modello;
    [SerializeField] private double OpeningPercentage;
    private float actualRotation;

    [SerializeField] private double requestedRotation;

    [SerializeField] private int fineCorsaMassimo;
    [SerializeField] private int fineCorsaMinimo;
    [SerializeField] private float rotationTime;
     private float rotation ;
    

    [SerializeField] private Transform firstBlind;
    [SerializeField] private Transform secondBlind;
    [SerializeField] private Transform thirdBlind;
    [SerializeField] private Transform fourthBlind;
    [SerializeField] private Transform fifthBlind;
    [SerializeField] private Transform sixthBlind;
    [SerializeField] private Transform seventhBlind;
 


    // Start is called before the first frame update
    void Start()
    {
  
    }
    private void FixedUpdate()

    {
       

        checkRotation();
       


    }
   
    private void checkRotation()
    {
        actualRotation = firstBlind.localEulerAngles.z;


       
       
        if (requestedRotation > fineCorsaMassimo || requestedRotation < fineCorsaMinimo || actualRotation == requestedRotation)
        {
            rotation = 0;
        }
        
      

        else if (actualRotation < requestedRotation)
        {
            rotation = maxAngle / rotationTime;

        }

        else if(actualRotation > requestedRotation+1)
        {
            rotation = -(maxAngle / rotationTime);
        }


        firstBlind.Rotate(rotationVector, Mathf.Round(rotation));
        secondBlind.Rotate(rotationVector, Mathf.Round(rotation));
        thirdBlind.Rotate(rotationVector, Mathf.Round(rotation));
        fourthBlind.Rotate(rotationVector, Mathf.Round(rotation));
        fifthBlind.Rotate(rotationVector, Mathf.Round(rotation));
        sixthBlind.Rotate(rotationVector, Mathf.Round(rotation));
        seventhBlind.Rotate(rotationVector, Mathf.Round(rotation));
        rotation = 0;

        OpeningPercentage = Math.Round(actualRotation)/100;
    }

}