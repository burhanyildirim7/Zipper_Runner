using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour
{
    public static bool cutted = false;


    private void OnCollisionEnter(Collision collision)
    {
        if (!cutted && GameController._oyunAktif)
        {
            Cutter.Cut(collision.transform, transform.localPosition);
            cutted = true;
            Invoke("CuttedFalse", 0.01f);
        }
    }

    private void CuttedFalse()
    {
        cutted = false;
    }
}