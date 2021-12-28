using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private List<GameObject> _zipperObjectList = new List<GameObject>();

    [SerializeField] private int _iyiToplanabilirDeger;

    [SerializeField] private int _kotuToplanabilirDeger;

    [SerializeField] private GameObject _karakterPaketi;

    [SerializeField] private Slider _zipperLevelSlider;

    private int _elmasSayisi;

    private GameObject _player;

    private UIController _uiController;

    private int _toplananElmasSayisi;

    private int _zipperLevel;

    private int _zipperNumber;



    void Start()
    {
        LevelStart();

        _uiController = GameObject.Find("UIController").GetComponent<UIController>();

    }




    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Elmas")
        {
            _elmasSayisi += 1;
            _toplananElmasSayisi += 1;
            PlayerPrefs.SetInt("ElmasSayisi", _elmasSayisi);
            Destroy(other.gameObject);
        }
        else if (other.tag == "IyiToplanabilir")
        {
            if (_zipperLevel < 100)
            {
                _zipperLevel += _iyiToplanabilirDeger;
                _zipperLevelSlider.value += _iyiToplanabilirDeger;

                if (_zipperLevel < 20)
                {
                    _zipperObjectList[4].SetActive(false);
                    _zipperObjectList[3].SetActive(false);
                    _zipperObjectList[2].SetActive(false);
                    _zipperObjectList[1].SetActive(false);
                    _zipperObjectList[0].SetActive(true);

                    if (_zipperLevelSlider.value == 20)
                    {
                        _zipperLevelSlider.value = 0;
                    }
                    else
                    {

                    }
                }
                else if (_zipperLevel >= 20 && _zipperLevel < 40)
                {
                    _zipperObjectList[4].SetActive(false);
                    _zipperObjectList[3].SetActive(false);
                    _zipperObjectList[2].SetActive(false);
                    _zipperObjectList[0].SetActive(false);
                    _zipperObjectList[1].SetActive(true);

                    if (_zipperLevelSlider.value == 20)
                    {
                        _zipperLevelSlider.value = 0;
                    }
                    else
                    {

                    }
                }
                else if (_zipperLevel >= 40 && _zipperLevel < 60)
                {
                    _zipperObjectList[4].SetActive(false);
                    _zipperObjectList[3].SetActive(false);
                    _zipperObjectList[0].SetActive(false);
                    _zipperObjectList[1].SetActive(false);
                    _zipperObjectList[2].SetActive(true);

                    if (_zipperLevelSlider.value == 20)
                    {
                        _zipperLevelSlider.value = 0;
                    }
                    else
                    {

                    }
                }
                else if (_zipperLevel >= 60 && _zipperLevel < 80)
                {
                    _zipperObjectList[4].SetActive(false);
                    _zipperObjectList[0].SetActive(false);
                    _zipperObjectList[2].SetActive(false);
                    _zipperObjectList[1].SetActive(false);
                    _zipperObjectList[3].SetActive(true);

                    if (_zipperLevelSlider.value == 20)
                    {
                        _zipperLevelSlider.value = 0;
                    }
                    else
                    {

                    }
                }
                else if (_zipperLevel >= 80)
                {
                    _zipperObjectList[0].SetActive(false);
                    _zipperObjectList[3].SetActive(false);
                    _zipperObjectList[2].SetActive(false);
                    _zipperObjectList[1].SetActive(false);
                    _zipperObjectList[4].SetActive(true);
                }
                else
                {

                }
            }
            else
            {
                _zipperLevel = 100;
                _zipperLevelSlider.value = 20;
            }

            Destroy(other.gameObject);
        }
        else if (other.tag == "KotuToplanabilir")
        {
            if (_zipperLevel > 0)
            {
                _zipperLevel -= _kotuToplanabilirDeger;
                _zipperLevelSlider.value -= _kotuToplanabilirDeger;

                if (_zipperLevel < 20)
                {
                    _zipperObjectList[4].SetActive(false);
                    _zipperObjectList[3].SetActive(false);
                    _zipperObjectList[2].SetActive(false);
                    _zipperObjectList[1].SetActive(false);
                    _zipperObjectList[0].SetActive(true);

                    if (_zipperLevelSlider.value == 20)
                    {
                        _zipperLevelSlider.value = 0;
                    }
                    else
                    {

                    }
                }
                else if (_zipperLevel >= 20 && _zipperLevel < 40)
                {
                    _zipperObjectList[4].SetActive(false);
                    _zipperObjectList[3].SetActive(false);
                    _zipperObjectList[2].SetActive(false);
                    _zipperObjectList[0].SetActive(false);
                    _zipperObjectList[1].SetActive(true);

                    if (_zipperLevelSlider.value == 20)
                    {
                        _zipperLevelSlider.value = 0;
                    }
                    else
                    {

                    }
                }
                else if (_zipperLevel >= 40 && _zipperLevel < 60)
                {
                    _zipperObjectList[4].SetActive(false);
                    _zipperObjectList[3].SetActive(false);
                    _zipperObjectList[0].SetActive(false);
                    _zipperObjectList[1].SetActive(false);
                    _zipperObjectList[2].SetActive(true);

                    if (_zipperLevelSlider.value == 20)
                    {
                        _zipperLevelSlider.value = 0;
                    }
                    else
                    {

                    }
                }
                else if (_zipperLevel >= 60 && _zipperLevel < 80)
                {
                    _zipperObjectList[4].SetActive(false);
                    _zipperObjectList[0].SetActive(false);
                    _zipperObjectList[2].SetActive(false);
                    _zipperObjectList[1].SetActive(false);
                    _zipperObjectList[3].SetActive(true);

                    if (_zipperLevelSlider.value == 20)
                    {
                        _zipperLevelSlider.value = 0;
                    }
                    else
                    {

                    }
                }
                else if (_zipperLevel >= 80)
                {
                    _zipperObjectList[0].SetActive(false);
                    _zipperObjectList[3].SetActive(false);
                    _zipperObjectList[2].SetActive(false);
                    _zipperObjectList[1].SetActive(false);
                    _zipperObjectList[4].SetActive(true);
                }
                else
                {

                }
            }
            else
            {
                _zipperLevel = 0;
                _zipperLevelSlider.value = 0;
            }

            Destroy(other.gameObject);
        }
        else if (other.tag == "IyiGateGiris")
        {
            Time.timeScale = 0.5f;
            _player = GameObject.FindWithTag("Player");
            _player.transform.localPosition = new Vector3(-2, _player.transform.localPosition.y, _player.transform.localPosition.z);
            GameController._oyunuBeklet = true;
            Debug.Log("IyiGateGiris");
        }
        else if (other.tag == "IyiGateOrta")
        {
            Debug.Log("IyiGateOrta");
        }
        else if (other.tag == "IyiGateCikis")
        {
            Time.timeScale = 1f;
            GameController._oyunuBeklet = false;
            Debug.Log("IyiGateCikis");
        }
        else if (other.tag == "OrtaGateGiris")
        {
            Time.timeScale = 0.5f;
            _player = GameObject.FindWithTag("Player");
            _player.transform.localPosition = new Vector3(0, _player.transform.localPosition.y, _player.transform.localPosition.z);
            GameController._oyunuBeklet = true;
            Debug.Log("OrtaGateGiris");
        }
        else if (other.tag == "OrtaGateOrta")
        {
            Debug.Log("OrtaGateOrta");
        }
        else if (other.tag == "OrtaGateCikis")
        {
            Time.timeScale = 1f;
            GameController._oyunuBeklet = false;
            Debug.Log("OrtaGateCikis");
        }
        else if (other.tag == "KotuGateGiris")
        {
            Time.timeScale = 0.5f;
            _player = GameObject.FindWithTag("Player");
            _player.transform.localPosition = new Vector3(2, _player.transform.localPosition.y, _player.transform.localPosition.z);
            GameController._oyunuBeklet = true;
            Debug.Log("KotuGateGiris");
        }
        else if (other.tag == "KotuGateOrta")
        {
            Debug.Log("KotuGateOrta");
        }
        else if (other.tag == "KotuGateCikis")
        {
            Time.timeScale = 1f;
            GameController._oyunuBeklet = false;
            Debug.Log("KotuGateCikis");
        }
        else if (other.tag == "FinishCizgisi")
        {
            //Time.timeScale = 0.5f;
            _player = GameObject.FindWithTag("Player");
            _player.transform.localPosition = new Vector3(0, _player.transform.localPosition.y, _player.transform.localPosition.z);
            GameController._oyunuBeklet = true;
            //Debug.Log("OrtaGateGiris");
        }
        else if (other.tag == "X1Collider")
        {
            if (_zipperLevel < 20)
            {
                GameController._oyunAktif = false;
                Invoke("WinScreenAc", 1f);
            }
            else
            {

            }
        }
        else if (other.tag == "X2Collider")
        {
            if (_zipperLevel >= 10 && _zipperLevel < 20)
            {
                GameController._oyunAktif = false;
                Invoke("WinScreenAc", 1f);
            }
            else
            {

            }
        }
        else if (other.tag == "X3Collider")
        {
            if (_zipperLevel >= 20 && _zipperLevel < 30)
            {
                GameController._oyunAktif = false;
                Invoke("WinScreenAc", 1f);
            }
            else
            {

            }
        }
        else if (other.tag == "X4Collider")
        {
            if (_zipperLevel >= 30 && _zipperLevel < 40)
            {
                GameController._oyunAktif = false;
                Invoke("WinScreenAc", 1f);
            }
            else
            {

            }
        }
        else if (other.tag == "X5Collider")
        {
            if (_zipperLevel >= 40 && _zipperLevel < 50)
            {
                GameController._oyunAktif = false;
                Invoke("WinScreenAc", 1f);
            }
            else
            {

            }
        }
        else if (other.tag == "X6Collider")
        {
            if (_zipperLevel >= 50 && _zipperLevel < 60)
            {
                GameController._oyunAktif = false;
                Invoke("WinScreenAc", 1f);
            }
            else
            {

            }
        }
        else if (other.tag == "X7Collider")
        {
            if (_zipperLevel >= 60 && _zipperLevel < 70)
            {
                GameController._oyunAktif = false;
                Invoke("WinScreenAc", 1f);
            }
            else
            {

            }
        }
        else if (other.tag == "X8Collider")
        {
            if (_zipperLevel >= 70 && _zipperLevel < 80)
            {
                GameController._oyunAktif = false;
                Invoke("WinScreenAc", 1f);
            }
            else
            {

            }
        }
        else if (other.tag == "X9Collider")
        {
            if (_zipperLevel >= 80 && _zipperLevel < 90)
            {
                GameController._oyunAktif = false;
                Invoke("WinScreenAc", 1f);
            }
            else
            {

            }
        }
        else if (other.tag == "X10Collider")
        {
            if (_zipperLevel >= 90)
            {
                GameController._oyunAktif = false;
                Invoke("WinScreenAc", 1f);
            }
            else
            {

            }
        }
        else
        {

        }
    }

    private void WinScreenAc()
    {
        _uiController.WinScreenPanelOpen();
    }

    private void LoseScreenAc()
    {
        _uiController.LoseScreenPanelOpen();
    }




    public void LevelStart()
    {
        GameController._oyunuBeklet = false;
        _toplananElmasSayisi = 1;
        _zipperLevel = 0;
        _zipperLevelSlider.value = 0;
        _zipperNumber = 0;
        _zipperObjectList[4].SetActive(false);
        _zipperObjectList[3].SetActive(false);
        _zipperObjectList[2].SetActive(false);
        _zipperObjectList[1].SetActive(false);
        _zipperObjectList[0].SetActive(true);
        _elmasSayisi = PlayerPrefs.GetInt("ElmasSayisi");
        _karakterPaketi.transform.position = new Vector3(0, 0, 0);
        _karakterPaketi.transform.rotation = Quaternion.Euler(0, 0, 0);
        _player = GameObject.FindWithTag("Player");
        _player.transform.localPosition = new Vector3(0, 0.25f, 0);
    }



}
