using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGeneration : MonoBehaviour
{
    [SerializeField] float waitTime;
    [SerializeField] GameObject branch;
    private void Start()
    {
        generate();
    }
    public void generate()
    {
        float x = Random.Range(.5f, 3.7f);
        float y = Random.Range(.5f, 3.7f);
        Instantiate(branch, transform.position, transform.rotation);
        StartCoroutine(wait());
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(waitTime);
        generate();
    }
}