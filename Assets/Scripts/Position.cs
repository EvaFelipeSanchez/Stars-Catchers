using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{

    public class Move : MonoBehaviour
    {
        float Player;
        void Start()
        {
            print("Thanks for buying this, if you need any support, email support@dilapidatedmeow.com. " +
                "Please note I cannot help with scripting related problems.");
        }

        void Update()
        {
            Player += Time.deltaTime / 125;

            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y, Player), 0.05f);

        }
    }
}
