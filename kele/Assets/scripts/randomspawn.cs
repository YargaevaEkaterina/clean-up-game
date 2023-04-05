using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomspawn : MonoBehaviour
{
    [SerializeField] GameObject btnPrefab;
    [SerializeField] Transform btnParent;
    [Tooltip("Максимальное кол-во элементов на сценe")] [SerializeField] int maxCount;
    private int alreadyCount;
    private int points;
    public GameObject sad;
    public GameObject normal;

    // Start is called before the first frame update
    void Start()
    {
        InstantiateObjects();
        points = 0;
        sad.SetActive (true);
        normal.SetActive (false);
    }

    // Update is called once per frame
    public void InstantiateObjects()
    {
        for (int i = alreadyCount; i < maxCount; i++)
        {
            GameObject go = Instantiate(btnPrefab, 
                new Vector2(Random.Range(-Screen.width/2, Screen.width/2), 
                    Random.Range(-Screen.height/2, Screen.height/2)), Quaternion.identity);
            go.transform.SetParent(btnParent, false);
            alreadyCount++;
        }
    }
    public void DestroyObjectToSpawn(GameObject obj)
    {
        Destroy(obj);
        if (alreadyCount != 1){
            alreadyCount--;
            points ++;
        }
        else {
            alreadyCount--;
            points ++;
            ChangeForPoints();
        }
    }

    public void ChangeForPoints()
    {
        if (points == 10){
            sad.SetActive (false);
            normal.SetActive (true);
        }


    }
}
