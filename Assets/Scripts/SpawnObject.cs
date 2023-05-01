using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject Starprefab;
    public int counterint = 0;
    //public float respawnTime = 1.0f;



    public Vector3 center;
    public Vector3 size;

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine( starsWave());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SpawnStar();
        }
    }


    public void SpawnStar()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
        Instantiate(Starprefab, pos, Quaternion.identity);
        counterint++;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawCube(center, size);
    }


    /*
    IEnumerator starsWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
           SpawnStar();
        }
    }
    */


}


