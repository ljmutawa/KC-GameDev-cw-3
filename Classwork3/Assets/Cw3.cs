using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cw3 : MonoBehaviour
{
    //hero
    string heroName = "Laila";
    float heroPower = 52.7f;
    //villian
    string villainName = "Salma";
    float villainPower = 38.2f;

    float playerSpeed; 

    // Start is called before the first frame update
    void Start()
    {

        if (heroPower < villainPower)
        {
            print(villainName + " has more power!");
        }
        else if (heroPower > villainPower)
        {
            print(heroName + " has more power!");
        }
        else
        {
            print("both are equally as powerful.");
        }

        SetSpeed(2.5f);
        CompareSpeed(7549, 94793);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetSpeed(float speed)
    {
        print(playerSpeed);
        playerSpeed = speed;
        print(playerSpeed);
    }

    void CompareSpeed(int speedX, int speedY)
    {
        if (speedX > speedY)
        {
            print("Object X is moving faster.");
        }
        else if (speedX < speedY)
        {
            print("Object Y is moving faster.");
        }
        else
        {
            print("Both objects are moving at the same speed.");
        }
    }
}
