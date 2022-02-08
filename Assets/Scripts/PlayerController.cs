using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private List<GameObject> _zipperObjectList = new List<GameObject>();

    [SerializeField] private GameObject _zipper;

    [SerializeField] private int _iyiToplanabilirDeger;

    [SerializeField] private int _kotuToplanabilirDeger;

    [SerializeField] private GameObject _karakterPaketi;

    [SerializeField] private Slider _zipperLevelSlider;

    [SerializeField] private int _buyumeDegeri;

    [SerializeField] private GameObject _engelEfekt;

    private int _elmasSayisi;

    private GameObject _player;

    private UIController _uiController;

    private int _toplananElmasSayisi;

    public static int _zipperLevel;

    private int _zipperNumber;

    private int _oyunSonuZipperDeger;
    private float _oyunSonuAzalmaDeger;



    void Start()
    {
        LevelStart();

        _uiController = GameObject.Find("UIController").GetComponent<UIController>();

    }

    private void Update()
    {
        if (GameController._oyunuBeklet && GameController._oyunAktif)
        {
            if (_zipper.transform.localScale.x > 100)
            {
                StartCoroutine("OyunSonuKuculme");
            }
            else
            {

            }

        }
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
            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);

            _zipperLevel += _iyiToplanabilirDeger;

            _zipper.transform.localScale += new Vector3(_buyumeDegeri, _buyumeDegeri, _buyumeDegeri);

            //_zipperLevelSlider.value += _iyiToplanabilirDeger;

            /*
            if (_zipperLevel < 100)
            {
               

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
            */

            Destroy(other.gameObject);
        }
        else if (other.tag == "DegersizEsya")
        {
            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);

            _zipperLevel -= _kotuToplanabilirDeger;

            _zipper.transform.localScale -= new Vector3(_buyumeDegeri, _buyumeDegeri, _buyumeDegeri);

            _engelEfekt.SetActive(true);

            Invoke("EngelEfektKapat", 0.5f);

            if (GameController._oyunuBeklet == false)
            {
                if (_zipper.transform.localScale.x <= 100)
                {
                    if (GameController._oyunAktif)
                    {
                        GameController._oyunAktif = false;
                        Invoke("LoseScreenAc", 1f);
                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }
            else
            {

            }
            //_zipperLevelSlider.value -= _kotuToplanabilirDeger;

            /*
            if (_zipperLevel > 0)
            {
               

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

                if (GameController._oyunAktif)
                {
                    GameController._oyunAktif = false;
                    Invoke("LoseScreenAc", 1f);
                }
                else
                {

                }

            }
            */
            //Destroy(other.gameObject);
        }
        else if (other.tag == "Kapi")
        {
            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);

            if (other.gameObject.GetComponent<KapiScript>()._topla)
            {
                _zipper.transform.localScale += new Vector3(other.gameObject.GetComponent<KapiScript>()._kapiDegeri * _buyumeDegeri, other.gameObject.GetComponent<KapiScript>()._kapiDegeri * _buyumeDegeri, other.gameObject.GetComponent<KapiScript>()._kapiDegeri * _buyumeDegeri);

                _zipperLevel += _iyiToplanabilirDeger * other.gameObject.GetComponent<KapiScript>()._kapiDegeri;
            }
            else if (other.gameObject.GetComponent<KapiScript>()._cikart)
            {
                _zipperLevel -= _kotuToplanabilirDeger * other.gameObject.GetComponent<KapiScript>()._kapiDegeri;

                if (_zipper.transform.localScale.x - other.gameObject.GetComponent<KapiScript>()._kapiDegeri * _buyumeDegeri < 100)
                {
                    if (GameController._oyunAktif)
                    {
                        GameController._oyunAktif = false;
                        Invoke("LoseScreenAc", 1f);
                    }
                    else
                    {

                    }
                }
                else
                {
                    _zipper.transform.localScale -= new Vector3(other.gameObject.GetComponent<KapiScript>()._kapiDegeri * _buyumeDegeri, other.gameObject.GetComponent<KapiScript>()._kapiDegeri * _buyumeDegeri, other.gameObject.GetComponent<KapiScript>()._kapiDegeri * _buyumeDegeri);
                }

            }
            else
            {

            }
        }
        else if (other.tag == "IyiGateGiris")
        {
            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);
            Time.timeScale = 0.5f;
            _player = GameObject.FindWithTag("Player");
            _player.transform.localPosition = new Vector3(-2, _player.transform.localPosition.y, _player.transform.localPosition.z);
            GameController._oyunuBeklet = true;
            Debug.Log("IyiGateGiris");
        }
        else if (other.tag == "IyiGateGiris")
        {
            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);
            Time.timeScale = 0.5f;
            _player = GameObject.FindWithTag("Player");
            _player.transform.localPosition = new Vector3(-2, _player.transform.localPosition.y, _player.transform.localPosition.z);
            GameController._oyunuBeklet = true;
            Debug.Log("IyiGateGiris");
        }
        else if (other.tag == "IyiGateOrta")
        {
            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);
            Debug.Log("IyiGateOrta");
        }
        else if (other.tag == "IyiGateCikis")
        {
            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);
            Time.timeScale = 1f;
            GameController._oyunuBeklet = false;
            Debug.Log("IyiGateCikis");
        }
        else if (other.tag == "OrtaGateGiris")
        {
            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);
            Time.timeScale = 0.5f;
            _player = GameObject.FindWithTag("Player");
            _player.transform.localPosition = new Vector3(0, _player.transform.localPosition.y, _player.transform.localPosition.z);
            GameController._oyunuBeklet = true;
            Debug.Log("OrtaGateGiris");
        }
        else if (other.tag == "OrtaGateOrta")
        {
            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);
            Debug.Log("OrtaGateOrta");
        }
        else if (other.tag == "OrtaGateCikis")
        {
            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);
            Time.timeScale = 1f;
            GameController._oyunuBeklet = false;
            Debug.Log("OrtaGateCikis");
        }
        else if (other.tag == "KotuGateGiris")
        {
            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);
            Time.timeScale = 0.5f;
            _player = GameObject.FindWithTag("Player");
            _player.transform.localPosition = new Vector3(2, _player.transform.localPosition.y, _player.transform.localPosition.z);
            GameController._oyunuBeklet = true;
            Debug.Log("KotuGateGiris");
        }
        else if (other.tag == "KotuGateOrta")
        {
            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);
            Debug.Log("KotuGateOrta");
        }
        else if (other.tag == "KotuGateCikis")
        {
            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);
            Time.timeScale = 1f;
            GameController._oyunuBeklet = false;
            Debug.Log("KotuGateCikis");
        }
        else if (other.tag == "FinishCizgisi")
        {
            //Time.timeScale = 0.5f;
            _player = GameObject.FindWithTag("Player");
            _player.transform.localPosition = new Vector3(0, _player.transform.localPosition.y, _player.transform.localPosition.z);


            _oyunSonuZipperDeger = (int)((_zipper.transform.localScale.x - 100) / 10);
            _oyunSonuAzalmaDeger = (_oyunSonuZipperDeger / 10);

            GameController._oyunuBeklet = true;
            //Debug.Log("OrtaGateGiris");
        }
        else if (other.tag == "X1Collider")
        {
            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);

            if (_zipper.transform.localScale.x <= 100)
            {
                GameController._oyunAktif = false;
                _uiController.LevelSonuElmasSayisi(_zipperLevel * 1);
                Invoke("WinScreenAc", 1f);
            }
            else
            {

            }
        }
        else if (other.tag == "X2Collider")
        {
            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);

            if (_zipper.transform.localScale.x <= 100)
            {
                GameController._oyunAktif = false;
                _uiController.LevelSonuElmasSayisi(_zipperLevel * 2);
                Invoke("WinScreenAc", 1f);
            }
            else
            {

            }
        }
        else if (other.tag == "X3Collider")
        {
            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);

            if (_zipper.transform.localScale.x <= 100)
            {
                GameController._oyunAktif = false;
                _uiController.LevelSonuElmasSayisi(_zipperLevel * 3);
                Invoke("WinScreenAc", 1f);
            }
            else
            {

            }
        }
        else if (other.tag == "X4Collider")
        {
            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);

            if (_zipper.transform.localScale.x <= 100)
            {
                GameController._oyunAktif = false;
                _uiController.LevelSonuElmasSayisi(_zipperLevel * 4);
                Invoke("WinScreenAc", 1f);
            }
            else
            {

            }
        }
        else if (other.tag == "X5Collider")
        {
            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);

            if (_zipper.transform.localScale.x <= 100)
            {
                GameController._oyunAktif = false;
                _uiController.LevelSonuElmasSayisi(_zipperLevel * 5);
                Invoke("WinScreenAc", 1f);
            }
            else
            {

            }
        }
        else if (other.tag == "X6Collider")
        {
            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);

            if (_zipper.transform.localScale.x <= 100)
            {
                GameController._oyunAktif = false;
                _uiController.LevelSonuElmasSayisi(_zipperLevel * 6);
                Invoke("WinScreenAc", 1f);
            }
            else
            {

            }
        }
        else if (other.tag == "X7Collider")
        {
            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);

            if (_zipper.transform.localScale.x <= 100)
            {
                GameController._oyunAktif = false;
                _uiController.LevelSonuElmasSayisi(_zipperLevel * 7);
                Invoke("WinScreenAc", 1f);
            }
            else
            {

            }
        }
        else if (other.tag == "X8Collider")
        {
            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);

            if (_zipper.transform.localScale.x <= 100)
            {
                GameController._oyunAktif = false;
                _uiController.LevelSonuElmasSayisi(_zipperLevel * 8);
                Invoke("WinScreenAc", 1f);
            }
            else
            {

            }
        }
        else if (other.tag == "X9Collider")
        {
            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);

            if (_zipper.transform.localScale.x <= 100)
            {
                GameController._oyunAktif = false;
                _uiController.LevelSonuElmasSayisi(_zipperLevel * 9);
                Invoke("WinScreenAc", 1f);
            }
            else
            {

            }
        }
        else if (other.tag == "X10Collider")
        {
            MoreMountains.NiceVibrations.MMVibrationManager.Haptic(MoreMountains.NiceVibrations.HapticTypes.MediumImpact);


            GameController._oyunAktif = false;
            _uiController.LevelSonuElmasSayisi(_zipperLevel * 10);
            _zipper.transform.localScale = new Vector3(100, 100, 100);
            Invoke("WinScreenAc", 1f);

        }
        else
        {

        }
    }

    private void EngelEfektKapat()
    {
        _engelEfekt.SetActive(false);
    }

    private void WinScreenAc()
    {
        _uiController.WinScreenPanelOpen();
    }

    private void LoseScreenAc()
    {
        _uiController.LoseScreenPanelOpen();
    }


    IEnumerator OyunSonuKuculme()
    {
        _zipper.transform.localScale -= new Vector3(0.75f, 0.75f, 0.75f);

        yield return new WaitForSeconds(0.1f);
    }



    public void LevelStart()
    {
        GameController._oyunuBeklet = false;
        _toplananElmasSayisi = 1;
        _zipperLevel = 1;
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
        _zipper.transform.localScale = new Vector3(100, 100, 100);
    }



}
