using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject Starprefab;
    public GameObject Starprefab2;
    public GameObject Starprefab3;
    public GameObject Starprefab4;
    public int counterint = 0;

    public float respawnTime = 1.0f;
    public float respawnTime2 = 8.0f;
    public float respawnTime3 = 16.0f;
    public float respawnTime4 = 16.0f;

    public Vector3 center;
    public Vector3 size;

    public float StartTime = 30.0f;
    public bool timerOn = false;

    // Start is called before the first frame update
    void Start()
    {
        if (StartTime <= 0.0f)
        {
            timerOn = true;
        }

        if (timerOn)
        {
            StartCoroutine(starsWave1());
            StartCoroutine(starsWave2());
            StartCoroutine(starsWave3());
            StartCoroutine(starsWave4());
        }



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SpawnStar();
        }

        if (StartTime > 0.0f)
        {
            StartTime -= Time.deltaTime;
        }




    public void SpawnStar()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
        Instantiate(Starprefab, pos, Quaternion.identity);
        counterint++;
    }

    public void SpawnStar2()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
        Instantiate(Starprefab2, pos, Quaternion.identity);
        counterint++;
    }

    public void SpawnStar3()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
        Instantiate(Starprefab3, pos, Quaternion.identity);
        counterint++;
    }

    public void SpawnStar4()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
        Instantiate(Starprefab4, pos, Quaternion.identity);
        counterint++;
    }



    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawCube(center, size);
    }


    
    IEnumerator starsWave1()
    {

         while (true)
            {
                yield return new WaitForSeconds(respawnTime);
                SpawnStar();
            }
        
    }

    IEnumerator starsWave2()
    {

            while (true)
            {
                yield return new WaitForSeconds(respawnTime2);
                SpawnStar2();
            }
        
    }

    IEnumerator starsWave3()
    {

            while (true)
            {
                yield return new WaitForSeconds(respawnTime3);
                SpawnStar3();
            }
        
    }

    IEnumerator starsWave4()
    {

            while (true)
            {
                yield return new WaitForSeconds(respawnTime4);
                SpawnStar4();
            }
        
    }



}


