using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progress : MonoBehaviour
{
    public static Progress Progress_Instance;
    [SerializeField] public GameObject RawImage;
    [SerializeField] public GameObject RawImage1;
    [SerializeField] public GameObject Text;
    [SerializeField] public GameObject milestoneHolder;

    public GameObject[] milestone;
    private int allMilestones;
    private int n_collected = 0;
    private int workProductsLaysAside = 0;

    void Awake()
    {
        if (Progress_Instance == null)
        {
            Progress_Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        disableVisualization();
    }


    public void enableVisualization()
    {
        Progress.Progress_Instance.RawImage.SetActive(true);
        Progress.Progress_Instance.RawImage1.SetActive(true);
        Progress.Progress_Instance.Text.SetActive(true);
        Progress.Progress_Instance.milestoneHolder.SetActive(true);
    }

    public void disableVisualization()
    {
        Progress.Progress_Instance.RawImage.SetActive(false);
        Progress.Progress_Instance.RawImage1.SetActive(false);
        Progress.Progress_Instance.Text.SetActive(false);
        Progress.Progress_Instance.milestoneHolder.SetActive(false);
    }


    

    public int getN_Collected()
    {
        return n_collected;
    }
    public void setN_Collected(int nc)
    {
        n_collected = nc;
    }
    public void SubN_Collected()
    {
        n_collected--;
    }
    public void AddN_Collected()
    {
        n_collected++;
    }

    public int getWorkProductsLaysAside()
    {
        return workProductsLaysAside;
    }
    public void setWorkProductsLaysAside(int wpla)
    {
        workProductsLaysAside = wpla;
    }
    public void AddWorkProductsLaysAside()
    {
        workProductsLaysAside++;
    }

    public int getAllMilestones()
    {
        return allMilestones;
    }
    public void setAllMilestones(int milestones)
    {
        allMilestones = milestones;
    }


}
