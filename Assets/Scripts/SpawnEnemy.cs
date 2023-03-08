using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private GameObject _zombieprefab;

    Camera cam;
    Vector3 point;

    private float x;
    private float y;

    private void Start()
    {
        cam = Camera.main;
        point = new Vector3();

        StartCoroutine(spawn());
    }

    private void Update()
    {
        x = Random.Range(-500, 500);
        y = Random.Range(-500, 500);

        point = cam.ScreenToWorldPoint(new Vector3(x, y, 10));
    }

    void Repit()
    {
        StartCoroutine(spawn());
    }

    private IEnumerator spawn()
    {
        yield return new WaitForSeconds(3);
        Instantiate(_zombieprefab,point, Quaternion.identity);
        Repit();
    }
}
