using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Byte   : MonoBehaviour 
{
    [SerializeField] Bit[] bits = new Bit[8];
    [SerializeField] private int value = 0;
    void Update()
    {
        BinToDec();
    }

    private void BinToDec()
    {
        this.value = 0;
        if (bits[0].state) this.value += 1;
        if (bits[1].state) this.value += 2;
        if (bits[2].state) this.value += 4;
        if (bits[3].state) this.value += 8;
        if (bits[4].state) this.value += 16;
        if (bits[5].state) this.value += 32;
        if (bits[6].state) this.value += 64;
        if (bits[7].state) this.value += 128;
    }

    public void SetValue(int newValue)
    {
        if(newValue > 255)
        {
            newValue = 255;
        }
        value = newValue;

        if (newValue >= 128)
        {
            bits[7].state = true;
            newValue -= 128;
        }
        else
        {
            bits[7].state = false;
        }
    }
}
