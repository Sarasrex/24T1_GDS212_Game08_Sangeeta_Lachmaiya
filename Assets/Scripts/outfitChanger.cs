using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitChanger : MonoBehaviour
{
    public SpriteRenderer bodyPart;

    public List<Sprite> options = new List<Sprite>();

    private int currentOption = 0;

    public PlayerPrefsManager playerPrefsManager;


    private void Start()
    {
        //Load from playerPrefsManager

        if (gameObject.name == "HairButton")
        {
            currentOption = playerPrefsManager.LoadHair();
            Debug.Log(gameObject.name + currentOption);
        }

        if (gameObject.name == "FaceButton")
        {
            currentOption = playerPrefsManager.LoadFace();
            Debug.Log(gameObject.name + currentOption);
        }
        
        if (gameObject.name == "LeftArmButton")
        {
            currentOption = playerPrefsManager.LoadLeftArm();
            Debug.Log(gameObject.name + currentOption);
        }
        
        if (gameObject.name == "RightArmButton")
        {
            currentOption = playerPrefsManager.LoadRightArm();
            Debug.Log(gameObject.name + currentOption);
        }

        if (gameObject.name == "TopsButton")
        {
            currentOption = playerPrefsManager.LoadTops();
            Debug.Log(gameObject.name + currentOption);
        }
        
        if (gameObject.name == "BottomsButton")
        {
            currentOption = playerPrefsManager.LoadBottoms();
            Debug.Log(gameObject.name + currentOption);
        }
        
        if (gameObject.name == "LeftShoeButton")
        {
            currentOption = playerPrefsManager.LoadLeftShoe();
            Debug.Log(gameObject.name + currentOption);
        }
        
        if (gameObject.name == "RightShoeButton")
        {
            currentOption = playerPrefsManager.LoadRightShoe();
            Debug.Log(gameObject.name + currentOption);
        }

        bodyPart.sprite = options[currentOption];
    }


    public void NextOption()
    {
        currentOption++;

        if (currentOption >= options.Count)
        {
            currentOption = 0;
        }

        bodyPart.sprite = options[currentOption];
        if (gameObject.name == "HairButton")
        {
            playerPrefsManager.SetCurrentHair(currentOption);
            // add another if statement for every other button
        }

        if (gameObject.name == "FaceButton")
        {
            playerPrefsManager.SetCurrentFace(currentOption);
        }

        if (gameObject.name == "LeftArmButton")
        {
            playerPrefsManager.SetCurrentLeftArm(currentOption);
        }

        if (gameObject.name == "RightArmButton")
        {
            playerPrefsManager.SetCurrentRightArm(currentOption);
        }

        if (gameObject.name == "TopsButton")
        {
            playerPrefsManager.SetCurrentTops(currentOption);
        }

        if (gameObject.name == "BottomsButton")
        {
            playerPrefsManager.SetCurrentBottoms(currentOption);
        }

        if (gameObject.name == "LeftShoeButton")
        {
            playerPrefsManager.SetCurrentLeftShoe(currentOption);
        }

        if (gameObject.name == "RightShoeButton")
        {
            playerPrefsManager.SetCurrentRightShoe(currentOption);
        }
    }
}
