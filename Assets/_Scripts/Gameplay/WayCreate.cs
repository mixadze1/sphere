using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayCreate : MonoBehaviour
{
    [SerializeField] private List<GameObject> wayPrefab;
    [SerializeField] private GameObject Finish;
    [SerializeField] private Transform way;
    [SerializeField] private Vector3 offSet; 
    private int count;
    private void Start()
    {
        StartCoroutine(spawnWay());
    }
    IEnumerator spawnWay()
    {
        for (count = 0; count < wayPrefab.Count; count++)
        {
            yield return new WaitForSeconds(0.1f);
            Instantiate(wayPrefab[count], way.position,Quaternion.identity);                   
            way.position += offSet; 
        }
        Instantiate(Finish, way.position, Quaternion.identity);
    }
  
}
