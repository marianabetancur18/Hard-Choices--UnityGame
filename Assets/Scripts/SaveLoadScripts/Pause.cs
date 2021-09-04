using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BayatGames.SaveGameFree;

public class Pause : MonoBehaviour
{
    public static Pause Pause_Instance;

    [SerializeField] public GameObject RawImage;
    [SerializeField] public GameObject ButtonExit;
    [SerializeField] public GameObject ButtonSave;
    [SerializeField] public GameObject ButtonLoad;
    [SerializeField] public GameObject ButtonHistory;
    [SerializeField] public GameObject textPause;
    [SerializeField] public GameObject RawImage1;
    [SerializeField] public GameObject ButtonResume;
    [SerializeField] public GameObject XButton;

    public bool aux = false;
    public bool aux1 = false;
    public bool LoadPosition = false;
    public bool SavePosition = false;
    public bool resumeAux = false;
    public bool HistoryAux = false;
    public bool SaveData = false;
    public bool NextResume = false;
    public bool History = false;
    public int HistoryLastVersion = -1;



    void Awake()
    {
        if (Pause_Instance == null)
        {
            Pause_Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        disableVisualization();
    }

    public void enableVisualization()
    {
        Pause.Pause_Instance.RawImage.SetActive(true);
        Pause.Pause_Instance.ButtonExit.SetActive(true);
        Pause.Pause_Instance.ButtonSave.SetActive(true);
        Pause.Pause_Instance.ButtonLoad.SetActive(true);
        Pause.Pause_Instance.ButtonHistory.SetActive(true);
        Pause.Pause_Instance.textPause.SetActive(true);
        Pause.Pause_Instance.RawImage1.SetActive(true);
        Pause.Pause_Instance.ButtonResume.SetActive(true);
        Pause.Pause_Instance.ButtonHistory.SetActive(true);
        Pause.Pause_Instance.XButton.SetActive(true);
    }

    public void disableVisualization()
    {
        Pause.Pause_Instance.RawImage.SetActive(false);
        Pause.Pause_Instance.ButtonExit.SetActive(false);
        Pause.Pause_Instance.ButtonSave.SetActive(false);
        Pause.Pause_Instance.ButtonLoad.SetActive(false);
        Pause.Pause_Instance.ButtonHistory.SetActive(false);
        Pause.Pause_Instance.textPause.SetActive(false);
        Pause.Pause_Instance.RawImage1.SetActive(false);
        Pause.Pause_Instance.ButtonResume.SetActive(false);
        Pause.Pause_Instance.ButtonHistory.SetActive(false);
        Pause.Pause_Instance.XButton.SetActive(false);
    }


    public void OnButtonExitPauseMenu()
    {
        aux = true;
        Resume.Resume_Instance.disableVisualization();
    }
    public void OnButtonLoadGameplay()
    {
        //SaveLoadController.SaveLoadController_instance.LoadGameplayInformation();
        LoadPosition = true;
        Debug.Log("Se pudo cargar la información de el ultimo punto de guardado del juego");
    }
    public void OnButtonSaveGameplay()
    {
        SavePosition = true;
        Debug.Log("Se pudo guardar la información de el ultimo punto del juego");
        //SaveData = true;
    }
    public void OnButtonExit()
    {
        //SavePosition = true;
        SaveData = true;
        Debug.Log("Se pudo guardar la información de la partida finalizada");
        aux1 = true;
        //Application.Quit();
    }

    public void OnNextResume()
    {
        Debug.Log(HistoryLastVersion);
        History = true;
        if (HistoryLastVersion == -1)
        {
            HistoryLastVersion = SaveSystem.version;
            //NextResume = true;
        }
        else
        {
            int auxLastversion = HistoryLastVersion - 1;
            Debug.Log("Cierra el menu de pausa y vuelve a abrir para visualizar la historia de la partida finalizada numero "+ auxLastversion);
            if (HistoryLastVersion == 0)
            {
                HistoryLastVersion = SaveSystem.version;
            }
            else
            {
                NextResume = true;
                HistoryLastVersion--;
                Debug.Log("Se pudo cargar la información de las partidas finalizadas");
            }
            
        }
        
    }

    public void OnButtonHistory()
    {
        if (!History)
        {
            HistoryLastVersion = int.Parse(SaveGame.Load<string>("LastVersión.txt", "version"));
            HistoryLastVersion++;
            Debug.Log(HistoryLastVersion + " este");
        }
        Resume.Resume_Instance.TittleText.text = "HISTORY";
        HistoryAux = !HistoryAux;
        if(HistoryAux)
        {
            Resume.Resume_Instance.enableVisualization();
        }
        else
        {
            Resume.Resume_Instance.disableVisualization();
        }
    }

    public void OnButtonResume()
    {
        Resume.Resume_Instance.TittleText.text = "RESUME";
        resumeAux = !resumeAux;
        if (resumeAux)
        {
            //asignar aca los valores de cada uno
            
            Resume.Resume_Instance.identifierText.text = SaveGame.Load<string>("GameplayInformation" + SaveLoadController.SaveLoadController_instance.identifier + ".txt", "identifier");
            Resume.Resume_Instance.completenessText.text = SaveGame.Load<string>("GameplayInformation4" + SaveLoadController.SaveLoadController_instance.identifier + ".txt", "completeness");
            Resume.Resume_Instance.consistencyErrorsNumberText.text = SaveGame.Load<string>("GameplayInformation5" + SaveLoadController.SaveLoadController_instance.identifier + ".txt", "consistencyErrorsNumber");
            Resume.Resume_Instance.ProbabilityOfConsistencyErrorText.text = SaveGame.Load<string>("GameplayInformation6" + SaveLoadController.SaveLoadController_instance.identifier + ".txt", "ProbabilityOfConsistencyError");
            Resume.Resume_Instance.numberOfWorkProductsLaysAsideText.text = SaveGame.Load<string>("GameplayInformation9" + SaveLoadController.SaveLoadController_instance.identifier + ".txt", "numberOfWorkProductsLaysAside");
            Resume.Resume_Instance.WinnerIDText.text = SaveGame.Load<string>("GameplayInformation7" + SaveLoadController.SaveLoadController_instance.identifier + ".txt", "WinnerID");
            
            Resume.Resume_Instance.enableVisualization();
        }
        else
        {
            Resume.Resume_Instance.disableVisualization();
        }
    }

}
