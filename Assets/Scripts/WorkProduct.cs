using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WorkProduct : MonoBehaviour
{

    private int ID;
    public string description;
    public Sprite icon;
    private bool pickedUp;
    private bool twice = false;

    public int getID()
    {
        return ID;
    }

    public string getDescription()
    {
        return description;
    }

    public bool getPickedUp()
    {
        return pickedUp;
    }
    public void setPickedUp(bool PU)
    {
        pickedUp = PU;
    }

    public bool getTwice()
    {
        return twice;
    }

    public void setTwice(bool tw)
    {
        twice = tw;
    }

}
