using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateOrtaScript : MonoBehaviour
{

    [SerializeField] private bool _iyiGate;

    [SerializeField] private bool _ortaGate;

    [SerializeField] private bool _kotuGate;

    [SerializeField] private List<GameObject> _iyiGateObjects = new List<GameObject>();

    [SerializeField] private List<GameObject> _ortaGateObjects = new List<GameObject>();

    [SerializeField] private List<GameObject> _kotuGateObjects = new List<GameObject>();

    void Start()
    {
        if (_iyiGate)
        {
            for (int i = 0; i < _iyiGateObjects.Count; i++)
            {
                _iyiGateObjects[i].SetActive(false);
            }
        }
        else if (_ortaGate)
        {
            for (int i = 0; i < _ortaGateObjects.Count; i++)
            {
                _ortaGateObjects[i].SetActive(false);
            }
        }
        else if (_kotuGate)
        {
            for (int i = 0; i < _kotuGateObjects.Count; i++)
            {
                _kotuGateObjects[i].SetActive(false);
            }
        }
        else
        {

        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (_iyiGate)
            {
                int deger = 0;
                deger = Random.Range(0, _iyiGateObjects.Count - 1);

                _iyiGateObjects[deger].SetActive(true);
            }
            else if (_ortaGate)
            {
                int deger = 0;
                deger = Random.Range(0, _ortaGateObjects.Count - 1);

                _ortaGateObjects[deger].SetActive(true);
            }
            else if (_kotuGate)
            {
                int deger = 0;
                deger = Random.Range(0, _kotuGateObjects.Count - 1);

                _kotuGateObjects[deger].SetActive(true);
            }
            else
            {

            }
        }
    }
}
