using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resume : MonoBehaviour
{
    public static Resume Resume_Instance;

    [SerializeField] public GameObject Text;
    [SerializeField] public GameObject RawImage;
    [SerializeField] public GameObject RawImage1;
    [SerializeField] public GameObject RawImage2;
    [SerializeField] public GameObject identifier;
    [SerializeField] public GameObject completeness;
    [SerializeField] public GameObject consistencyErrorsNumber;
    [SerializeField] public GameObject ProbabilityOfConsistencyError;
    [SerializeField] public GameObject numberOfWorkProductsLaysAside;
    [SerializeField] public GameObject WinnerID;
    [SerializeField] public GameObject ButtonNext;
    [SerializeField] public GameObject identifierT;
    [SerializeField] public GameObject completenessT;
    [SerializeField] public GameObject consistencyErrorsNumberT;
    [SerializeField] public GameObject ProbabilityOfConsistencyErrorT;
    [SerializeField] public GameObject numberOfWorkProductsLaysAsideT;
    [SerializeField] public GameObject WinnerIDT;



    public Text identifierText;
    public Text completenessText;
    public Text consistencyErrorsNumberText;
    public Text ProbabilityOfConsistencyErrorText;
    public Text numberOfWorkProductsLaysAsideText;
    public Text WinnerIDText;
    public Text TittleText;

    void Awake()
    {
        if (Resume_Instance == null)
        {
            Resume_Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        disableVisualization();
    }

    public void enableVisualization()
    {
        Resume.Resume_Instance.Text.SetActive(true);
        Resume.Resume_Instance.RawImage.SetActive(true);
        Resume.Resume_Instance.RawImage1.SetActive(true);
        Resume.Resume_Instance.RawImage2.SetActive(true);
        Resume.Resume_Instance.identifier.SetActive(true);
        Resume.Resume_Instance.completeness.SetActive(true);
        Resume.Resume_Instance.consistencyErrorsNumber.SetActive(true);
        Resume.Resume_Instance.ProbabilityOfConsistencyError.SetActive(true);
        Resume.Resume_Instance.numberOfWorkProductsLaysAside.SetActive(true);
        Resume.Resume_Instance.WinnerID.SetActive(true);
        Resume.Resume_Instance.ButtonNext.SetActive(true);
        Resume.Resume_Instance.identifierT.SetActive(true);
        Resume.Resume_Instance.completenessT.SetActive(true);
        Resume.Resume_Instance.consistencyErrorsNumberT.SetActive(true);
        Resume.Resume_Instance.ProbabilityOfConsistencyErrorT.SetActive(true);
        Resume.Resume_Instance.numberOfWorkProductsLaysAsideT.SetActive(true);
        Resume.Resume_Instance.WinnerIDT.SetActive(true);

    }

    public void disableVisualization()
    {
        Resume.Resume_Instance.Text.SetActive(false);
        Resume.Resume_Instance.RawImage.SetActive(false);
        Resume.Resume_Instance.RawImage1.SetActive(false);
        Resume.Resume_Instance.RawImage2.SetActive(false);
        Resume.Resume_Instance.identifier.SetActive(false);
        Resume.Resume_Instance.completeness.SetActive(false);
        Resume.Resume_Instance.consistencyErrorsNumber.SetActive(false);
        Resume.Resume_Instance.ProbabilityOfConsistencyError.SetActive(false);
        Resume.Resume_Instance.numberOfWorkProductsLaysAside.SetActive(false);
        Resume.Resume_Instance.WinnerID.SetActive(false);
        Resume.Resume_Instance.ButtonNext.SetActive(false);
        Resume.Resume_Instance.identifierT.SetActive(false);
        Resume.Resume_Instance.completenessT.SetActive(false);
        Resume.Resume_Instance.consistencyErrorsNumberT.SetActive(false);
        Resume.Resume_Instance.ProbabilityOfConsistencyErrorT.SetActive(false);
        Resume.Resume_Instance.numberOfWorkProductsLaysAsideT.SetActive(false);
        Resume.Resume_Instance.WinnerIDT.SetActive(false);

    }
}
