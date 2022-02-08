using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolScript : MonoBehaviour
{
    private float _hiz;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController._zipperLevel < 5)
        {
            transform.Translate(Vector3.left * Time.deltaTime * 0.5f);
        }
        else if (PlayerController._zipperLevel >= 5 && PlayerController._zipperLevel < 10)
        {
            transform.Translate(Vector3.left * Time.deltaTime * 1f);
        }
        else
        {
            _hiz = PlayerController._zipperLevel / 10;

            transform.Translate(Vector3.left * Time.deltaTime * _hiz);
        }

    }
}
