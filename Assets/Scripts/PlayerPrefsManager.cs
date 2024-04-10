using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// This script will save and load the players data from player prefs
/// </summary>
public class PlayerPrefsManager : MonoBehaviour
{
    public int currentHair = 0;
    public int currentFace = 0;
    public int currentLeftArm = 0;
    public int currentRightArm = 0;
    public int currentTops = 0;
    public int currentBottoms = 0;
    public int currentLeftLeg = 0;
    public int currentRightLeg = 0;
    public int currentLeftShoe = 0;
    public int currentRightShoe = 0;


    // The below method saves each piece of clothing the players chooses

    public void SetCurrentHair(int chosenHair)
    {
        currentHair = chosenHair;
        Save();
    }    
    
    public void SetCurrentFace(int chosenFace)
    {
        currentFace = chosenFace;
        Save();
    }

    public void SetCurrentLeftArm(int chosenLeftArm)
    {
        currentLeftArm = chosenLeftArm;
        Save();
    }
    
    public void SetCurrentRightArm(int chosenRightArm)
    {
        currentRightArm = chosenRightArm;
        Save();
    }

    public void SetCurrentTops(int chosenTops)
    {
        currentTops = chosenTops;
        Save();
    }

    public void SetCurrentBottoms(int chosenBottoms)
    {
        currentBottoms = chosenBottoms;
        Save();
    }

    public void SetCurrentLeftLeg(int chosenLeftLeg)
    {
        currentLeftLeg = chosenLeftLeg;
        Save();
    }
    
    public void SetCurrentRightLeg(int chosenRightLeg)
    {
        currentRightLeg = chosenRightLeg;
        Save();
    }

    public void SetCurrentLeftShoe(int chosenLeftShoe)
    {
        currentLeftShoe = chosenLeftShoe;
        Save();
    }

    public void SetCurrentRightShoe(int chosenRightShoe)
    {
        currentRightShoe = chosenRightShoe;
        Save();
    }


    // The save method attached to the rig
    void Save()
    {
        PlayerPrefs.SetInt("player hair", currentHair);
        PlayerPrefs.SetInt("player face", currentFace);
        PlayerPrefs.SetInt("player left arm", currentLeftArm);
        PlayerPrefs.SetInt("player rightrm", currentRightArm);
        PlayerPrefs.SetInt("player tops", currentTops);
        PlayerPrefs.SetInt("player bottoms", currentBottoms);
        PlayerPrefs.SetInt("player left leg", currentLeftLeg);
        PlayerPrefs.SetInt("player right leg", currentRightLeg);
        PlayerPrefs.SetInt("player left shoe", currentLeftShoe);
        PlayerPrefs.SetInt("player right leg", currentRightShoe);
    }
    

    // The below methods collects the players previously selected and saved clothing (choice of sprite) preferences

    public int LoadHair()
    {
        return PlayerPrefs.GetInt("player hair");
    } 
    
    public int LoadFace()
    {
        return PlayerPrefs.GetInt("player face");
    }  
    
    public int LoadLeftArm()
    {
        return PlayerPrefs.GetInt("player left arm");
    }  
    
    public int LoadRightArm()
    {
        return PlayerPrefs.GetInt("player right arm");
    }
    
    public int LoadTops()
    {
        return PlayerPrefs.GetInt("player tops");
    }
    
    public int LoadBottoms()
    {
        return PlayerPrefs.GetInt("player bottoms");
    }
    
    public int LoadLeftLeg()
    {
        return PlayerPrefs.GetInt("player left leg");
    }

    public int LoadRightLeg()
    {
        return PlayerPrefs.GetInt("player right leg");
    }
    
    public int LoadLeftShoe()
    {
        return PlayerPrefs.GetInt("player left shoe");
    }

    public int LoadRightShoe()
    {
        return PlayerPrefs.GetInt("player right shoe");
    }
}
