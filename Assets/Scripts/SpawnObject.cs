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
    public bool timerOn = true;

    public Timer timeleft;

    // Start is called before the first frame update
    void Start()
    {
        timerOn = true;
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

        if (StartTime <= 0.0f)
        {

            if (timerOn)
            {
               
                StartCoroutine(starsWave1());
                StartCoroutine(starsWave2());
                StartCoroutine(starsWave3());
                StartCoroutine(starsWave4());
                
                timerOn = false;
            }
        }

        if (timeleft.TimeLeft <= 0.0f)
        {
   
            StartCoroutine(DestroyAllInstances1());
            StartCoroutine(DestroyAllInstances2());
            StartCoroutine(DestroyAllInstances3());
            StartCoroutine(DestroyAllInstances4());
        }

        if (StartTime > 0.0f)
        {
            StartCoroutine(DestroyAllInstances1());
            StartCoroutine(DestroyAllInstances2());
            StartCoroutine(DestroyAllInstances3());
            StartCoroutine(DestroyAllInstances4());
        }



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

         while (timeleft.TimeLeft > 0.0f)
            {
                yield return new WaitForSeconds(respawnTime);
                SpawnStar();
            }
        
    }

    IEnumerator starsWave2()
    {

            while (timeleft.TimeLeft > 0.0f)
            {
                yield return new WaitForSeconds(respawnTime2);
                SpawnStar2();
            }


        
    }

    IEnumerator starsWave3()
    {

            while (timeleft.TimeLeft > 0.0f)
            {
                yield return new WaitForSeconds(respawnTime3);
                SpawnStar3();
            }
        
    }

    IEnumerator starsWave4()
    {

            while (timeleft.TimeLeft > 0.0f)
            {
                yield return new WaitForSeconds(respawnTime4);
                SpawnStar4();
            }
        
    }

 IEnumerator DestroyAllInstances1()
    {
        yield return null;  // Espera un frame para asegurarte de que todas las instancias estén activas

        GameObject[] instances1 = GameObject.FindObjectsOfType<GameObject>();  // Encuentra todas las instancias de GameObject en la escena

        foreach (GameObject instance1 in instances1)
        {
            if (instance1 != this.gameObject && instance1.name == Starprefab.name + "(Clone)")
            {
                Destroy(instance1);  // Destruye la instancia si cumple con las condiciones
            }
        }
    }

    IEnumerator DestroyAllInstances2()
    {
        yield return null;  // Espera un frame para asegurarte de que todas las instancias estén activas

        GameObject[] instances2 = GameObject.FindObjectsOfType<GameObject>();  // Encuentra todas las instancias de GameObject en la escena

        foreach (GameObject instance2 in instances2)
        {
            if (instance2 != this.gameObject && instance2.name == Starprefab2.name + "(Clone)")
            {
                Destroy(instance2);  // Destruye la instancia si cumple con las condiciones
            }
        }
    }

    IEnumerator DestroyAllInstances3()
    {
        yield return null;  // Espera un frame para asegurarte de que todas las instancias estén activas

        GameObject[] instances3 = GameObject.FindObjectsOfType<GameObject>();  // Encuentra todas las instancias de GameObject en la escena

        foreach (GameObject instance3 in instances3)
        {
            if (instance3 != this.gameObject && instance3.name == Starprefab3.name + "(Clone)")
            {
                Destroy(instance3);  // Destruye la instancia si cumple con las condiciones
            }
        }
    }

    IEnumerator DestroyAllInstances4()
    {
        yield return null;  // Espera un frame para asegurarte de que todas las instancias estén activas

        GameObject[] instances4 = GameObject.FindObjectsOfType<GameObject>();  // Encuentra todas las instancias de GameObject en la escena

        foreach (GameObject instance4 in instances4)
        {
            if (instance4 != this.gameObject && instance4.name == Starprefab4.name + "(Clone)")
            {
                Destroy(instance4);  // Destruye la instancia si cumple con las condiciones
            }
        }
    }






}


