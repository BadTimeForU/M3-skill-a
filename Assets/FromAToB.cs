using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromAToB : MonoBehaviour
{
    [SerializeField] GameObject A;
    [SerializeField] GameObject B;
    [SerializeField] GameObject Player;

    Vector3 DifferenceVector;
    float distance;
    Vector3 Direction;

    float t = 0;
    float duration; 

    bool AToB = true;
    void Start()
    {
        DifferenceVector = B.transform.position - A.transform.position;
        distance = DifferenceVector.magnitude;
        Direction = DifferenceVector.normalized;
        Player.transform.position = A.transform.position;
        duration = distance / 1;
    }

    // Update is called once per frame
    void Update()
    {

        if (t >= duration)
        {
            AToB = !AToB;
            t = 0;
        }

        if (AToB)
        {
            DifferenceVector = B.transform.position - A.transform.position;
        }else
        {
            DifferenceVector = A.transform.position - B.transform.position;
        }

        Direction =DifferenceVector.normalized;
        Player.transform.position += Direction * Time.deltaTime;

       
       
        t += Time.deltaTime;

    }
}
