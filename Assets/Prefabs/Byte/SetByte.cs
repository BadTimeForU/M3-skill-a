using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetByte : MonoBehaviour
{
    [SerializeField] Byte myByte;
    [SerializeField] int newValue;

    void Update()
    {
        myByte.SetValue(myByte);
    }


}